function renderizarNotas() {
  let NotaMinima = document.getElementById("NotaMinima").value
  let NotaMaxima = document.getElementById("NotaMaxima").value

  if (NotaMinima > NotaMaxima) {
    alert('La nota minima no puede ser mayo que la nota máxima')
    return 
  } 
  let NotaAprobacion = document.getElementById("NotaAprobacion").value
  let Exigencia = document.getElementById("Exigencia").value
  let PuntajeMaximo = document.getElementById("PuntajeMaximo").value

  let ExigenciaPorcentaje = Exigencia / 100

  let PuntajeObtenido = document.getElementById('PuntajeObtenido').value

  if (PuntajeObtenido > PuntajeMaximo) {
    alert('El puntaje obtenido no puede exceder al puntaje máximo')
    return
  }


  if(NotaAprobacion && Exigencia && PuntajeMaximo) {

    if (PuntajeObtenido) {
      nota = obtenerNota(NotaMinima, NotaMaxima, NotaAprobacion, ExigenciaPorcentaje, PuntajeMaximo,PuntajeObtenido) 
      document.getElementById('ResultadoPuntaje').innerText = `Su nota fue ${nota}`
      return
    }

    let result = []
    for(let i = 0; i <= PuntajeMaximo; i++) {
      let nota = obtenerNota(NotaMinima, NotaMaxima, NotaAprobacion, ExigenciaPorcentaje, PuntajeMaximo,i)      
      result.push({
        puntaje:  i,
        nota: nota,
        colorText: nota < 4 ? 'red' : 'blue'  
      })
    }
    renderTable(result)
  }
}

function obtenerNota(NotaMinima, NotaMaxima, NotaAprobacion,ExigenciaPorcentaje,PuntajeMaximo, PuntoObtenido) {
  let nota = 0
  if (PuntoObtenido < (ExigenciaPorcentaje * PuntajeMaximo)) {
    nota = parseFloat((NotaAprobacion - NotaMinima) * (PuntoObtenido / (ExigenciaPorcentaje * PuntajeMaximo)) + parseInt(NotaMinima)).toFixed(1)
  } else {
    nota = (NotaMaxima - NotaAprobacion) * (PuntoObtenido - (ExigenciaPorcentaje * PuntajeMaximo))/ (PuntajeMaximo * (1 - ExigenciaPorcentaje))
    nota = parseFloat(nota + parseInt(NotaAprobacion)).toFixed(1)
  }

  return nota
}

function renderTable(result) {
  let htmlTable = `<table class="table table-bordered">
                    <tr>
                      <th>Puntaje</th>
                      <th>Nota</th>
                    </tr>
                  `
  for(let nota of result) {
      htmlTable += `<tr>
                      <td>${nota.puntaje}</td>
                      <td style="color:${nota.colorText}">${nota.nota}</td>
                    </tr>`
  }

  htmlTable += `</table>`

  document.getElementById('result').innerHTML = htmlTable

}
