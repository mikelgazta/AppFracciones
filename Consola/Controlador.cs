using System;
using System.Linq;
using AppFracciones;
using System.Collections.Generic;

namespace Consola
{
    class Controlador
    {
        private Vista vista;
        private Sistema sistema;
        private Dictionary<string, Action> casosDeUso;
        public Controlador(Vista vista, Sistema sistema)
        {
            this.vista = vista;
            this.sistema = sistema;
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
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            var suma = sistema.sumarFracciones(n1,n2,d1,d2);
            vista.Mostrar(suma);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        }

        public void multiplicarFracciones()
        {
            var n1 = vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            string multi= sistema.multiplicarFracciones(n1,n2,d1,d2);
            vista.Mostrar(multi);
        }
        public void restarFracciones()
        {
            var n1 = vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var n2 = vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = vista.TryObtenerDatoDeTipo<int>("dame el d2");
            var resto= sistema.restarFracciones(n1,n2,d1,d2);
            vista.Mostrar(resto);
        }
        
    }
}
