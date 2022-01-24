using System;
using System.Collections.Generic;

namespace AppFracciones
{
    public class Fraccion
    {
        public int num{get;}
        public int den{get;}

        public Fraccion(int x,int y){
            this.num= x;
            this.den=y;
        }
        public static Fraccion operator +(Fraccion f1, Fraccion f2) {
            return new Fraccion(f1.num*f2.den+f1.den*f2.num,f1.den*f2.den);
        }

        public static Fraccion operator *(Fraccion f1, Fraccion f2){
            return new Fraccion(f1.num*f2.num,f1.den*f2.den);
        }

        public static Fraccion operator -(Fraccion f1, Fraccion f2){
            return new Fraccion(f1.num*f2.den-f1.den*f2.num,f1.den*f2.den);
        }
        public override string ToString()
        {
            return $"{num}/{den}";
        }
    }
}