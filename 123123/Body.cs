using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Body
    {
        public double a { get; set; } = 0;
        public double b { get; set; } = 0;
        public double c { get; set; } = 0;
        public double d { get; set; } = 0;

        public Body(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void Max()
        {

            double max = Math.Max(Math.Max(a, b), Math.Max(c, d));

        }
        public double Area()
        {
            return (a + b + c + d) / 2;
        }


        public string Print()
        {

            return $"{(a + b + c + d) / 4}\n" +
                   $"{Math.Max(Math.Max(a, b), Math.Max(c, d))}";

        }
    }
}

    





