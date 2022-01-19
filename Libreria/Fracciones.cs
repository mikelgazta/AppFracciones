using System;
using System.Collections.Generic;

namespace AppFracciones
{
    public class Sistema
    {
        public string sumarFracciones(int n1, int d1, int n2, int d2)
        {
            var nr = n1 * d2 + n2 * d1;
            var dr = d2 * d1;
            return $"{nr}/{dr}";
            

        }
        public string multiplicarFracciones(int n1, int d1, int n2, int d2){
            var num= n1*n2;
            var den=d1*d2;
            string suma=$"{num}/{den}";
            return suma;

        }

        
        public string restarFracciones(int n1, int d1,int n2, int d2){
            var num=(n1*d2)-(n2*d1);
            var den=d1*d2;
            return $"{num}/{den}";
        }
    }
}