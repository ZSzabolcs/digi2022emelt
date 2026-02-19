using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    public class Felajanlas
    {
        private string? db;
        private int? tol;
        private int? ig;
        private char? szin;

        public Felajanlas(string? db, int? tol, int? ig, char? szin)
        {
            this.Db = db;
            this.Tol = tol;
            this.Ig = ig;
            this.Szin = szin;
        }

        public string? Db { get => db; set => db = value; }
        public int? Tol { get => tol; set => tol = value; }
        public int? Ig { get => ig; set => ig = value; }
        public char? Szin { get => szin; set => szin = value; }
    }
}
