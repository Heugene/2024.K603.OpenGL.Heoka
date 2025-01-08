using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public abstract class Function
    {
        public decimal Xmin { get; set; } 
        public decimal Xmax { get; set; }

        public int N { get; set; }

        public decimal Step { get { return (Xmax - Xmin)/(N - 1); } }

        public Color Colour { get; set; } = Color.Red;
        public int LineSize { get; set; } = 2;

        public Function(decimal Xmin, decimal Xmax, int N) 
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;
            this.N = N;
        }
    }
}
