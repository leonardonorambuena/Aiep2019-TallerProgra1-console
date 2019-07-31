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


  if(NotaAprobacion && Exigencia && PuntajeMaximo) {
    let result = []
    for(let i = 0; i <= PuntajeMaximo; i++) {
      let nota = 0
      if (i < (ExigenciaPorcentaje * PuntajeMaximo)) {
        nota = parseFloat((NotaAprobacion - NotaMinima) * (i / (ExigenciaPorcentaje * PuntajeMaximo)) + parseInt(NotaMinima)).toFixed(1)
      } else {
        nota = (NotaMaxima - NotaAprobacion) * (i - (ExigenciaPorcentaje * PuntajeMaximo))/ (PuntajeMaximo * (1 - ExigenciaPorcentaje))
        nota = parseFloat(nota + parseInt(NotaAprobacion)).toFixed(1)
      }
      result.push({
        puntaje:  i,
        nota: nota,
        colorText: nota < 4 ? 'red' : 'blue'  
      })
    }
    renderTable(result)
  }
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
