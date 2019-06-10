using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Fractions
    {
        private double a;
        private double b;


        public Fractions(int v1, int v2)
        {
            this.a = v1;
            this.B = v2;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value==0?1:value; }

        public override string ToString()
        {
            return "  "+A + "\n ----- \n  "+B;
        }

       
        

    }
}
