namespace Guia1.Helpers
{
  public class NumberHelper
  {
    public static bool IsPar(int number)
    {
      return number % 2 == 0;
    }

    public static bool IsPrime(int number)
    {
      if (number < 2) return false;

      for (int i = 2; i < number; i++)
      {
        if (number % i == 0) return false;
      }
      return true;
    }

    public static bool IsPanDigital(long number)
    {
      var numberText = number.ToString();

      for(int i = 0; i <10; i++)
        if (!numberText.Contains(i.ToString()))
          return false;

      return true;
    }

  }
}