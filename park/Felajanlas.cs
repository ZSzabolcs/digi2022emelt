using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    public class Felajanlas
    {
        private int? tol;
        private int? ig;
        private char? szin;

        public Felajanlas(int? tol, int? ig, char? szin)
        {
            this.Tol = tol;
            this.Ig = ig;
            this.Szin = szin;
        }

        public int? Tol { get => tol; set => tol = value; }
        public int? Ig { get => ig; set => ig = value; }
        public char? Szin { get => szin; set => szin = value; }
    }
}
