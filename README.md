# Crud-con-WindowsForm
Crud de 3 Capas Usando Windows Form solucion, CapaDatos, CapaNegocio, CapaUI

Se relacionan de la siguiente manera.
 CapaDatos <-----------------------------> CapaNegocio <---------------------------------> CapaUI
<div class="wrapper" style="display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 10px;
  grid-auto-rows: minmax(100px, auto);">
  <div class="one" style=" border: 1px solid black;">
 <h5>CapaDatos</h5>
    <ul>
      <li>using System.Data;</li>
      <li>using System.Data.SqlClient;</li>
    </ul>
  </div>
  <div class="two" style=" border: 1px solid black;">
 <h5>CapaNegocio</h5>
    <ul>
      <li>using System.Data;</li>
      <li>using System.Data.SqlClient;</li>
      <li>using CapaDatos;</li>
    </ul>
  </div>
  <div class="three" style=" border: 1px solid black;">
 <h5>CapaUI</h5>
    <ul>
      <li>using CapaNegocio;</li>
    </ul>
  </div>
</div>
<img src="https://github.com/julioj1081/Crud-con-WindowsForm/blob/master/img/ProgramaFIn.png" />
