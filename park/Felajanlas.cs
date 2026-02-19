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
        private string? tol;
        private string? ig;
        private char? szin;

        public Felajanlas(string? db, string? tol, string? ig, char? szin)
        {
            this.Db = db;
            this.Tol = tol;
            this.Ig = ig;
            this.Szin = szin;
        }

        public string? Db { get => db; set => db = value; }
        public string? Tol { get => tol; set => tol = value; }
        public string? Ig { get => ig; set => ig = value; }
        public char? Szin { get => szin; set => szin = value; }
    }
}
