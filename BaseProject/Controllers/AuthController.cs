using System;
using System.Threading.Tasks;
using BaseProject.Models;
using BaseProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly SignInManager<User> _signInManager;

        private readonly ApplicationDbContext _db;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.UserName == model.UserName && x.DeletedAt == null);
                if (user == null)
                {
                    ModelState.AddModelError("","Intento de inicio fallido");
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                if (result.Succeeded) 
                {
                    await _signInManager.SignInAsync(user,false);
                    return RedirectToAction("Index", "Home");
                }

            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userExist = await _db.Users.AnyAsync(x => x.Email == model.Email && x.DeletedAt == null);

                if (userExist)
                {
                    ViewData["Error"] = "El correo se encuentra registrado";
                    return View(model);
                }

                var user = new User
                {
                    Email = model.Email,
                    UserName = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };


                var result = await _userManager.CreateAsync(user,model.Password);
                if (result.Succeeded) 
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }

               foreach(var err in result.Errors)
               {
                   ModelState.AddModelError(err.Code, err.Description);
               }
               
            }

            return View(model);
        }
    }
}