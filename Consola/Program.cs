using AppFracciones;
using Consola;


var vista =new Vista();
var sistema =new AppFracciones.Sistema();
var controlador =new Controlador(vista, sistema);
controlador.Run();

