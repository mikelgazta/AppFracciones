using System;
using System.Linq;
using AppFracciones;
using System.Collections.Generic;

namespace Consola
{
    class Controlador
    {
        private Vista vista;
        private Dictionary<string, Action> casosDeUso;
        public Controlador(Vista vista)
        {
            this.vista = vista;
            casosDeUso = new Dictionary<string, Action>(){
                { "Sumar Fracciones", sumarFracciones},
                { "Multiplicar Fracciones", multiplicarFracciones},
                {"Restar Fracciones", restarFracciones},
            };
        }

        // === Ciclo de la Aplicacin ===
        public void Run()
        {
            vista.LimpiarPantalla();
            // Acceso a las Claves del diccionario
            var menu = casosDeUso.Keys.ToList<String>();
            

            while (true)
                try
                {
                    //Limpiamos
                    vista.LimpiarPantalla();
                    // Menu
                    var key = vista.TryObtenerElementoDeLista("Menu de Usuario", menu, "Seleciona una opción");
                    vista.Mostrar("");
                    // Ejecución de la opción escogida
                    casosDeUso[key].Invoke();
                    // Fin
                    vista.MostrarYReturn("Pulsa <Return> para continuar");
                }
                catch { return; }
        }
        public void sumarFracciones()
        {  try{
            var n1 = vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var f1= new Fraccion (n1,d1); 
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            var f2=new Fraccion (n2,d2);
            var suma = f1+f2;
            vista.Mostrar(suma);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        }

        public void multiplicarFracciones()
        {
            var n1 = vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var f1=new Fraccion(n1,d1);
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            var f2=new Fraccion(n2,d2);
            var multi= f1*f2;
            vista.Mostrar(multi);
        }
        public void restarFracciones()
        {
            var n1 = vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var f1=new Fraccion (n1,d1); 
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            var f2= new Fraccion(n2,d2);
            var resto= f1-f2;
            vista.Mostrar(resto);
        }
    }
}
