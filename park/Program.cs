namespace park
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("felajanlas.txt");
            List<Felajanlas> felajanlasok = new List<Felajanlas>();
            string? db = Convert.ToString(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(' ');
                felajanlasok.Add(new Felajanlas(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToChar(sor[2])));
            }
            sr.Close();
            Console.WriteLine($"2. feladat\nA felajánlások száma: {felajanlasok.Count()}\n");
            Console.WriteLine("3. feladat\nA bejárat bal és jobb oldalát is beültető(k) sorszáma(i):");
            for (int i = 0; i < felajanlasok.Count; i++)
            {
                if (felajanlasok[i].Tol > felajanlasok[i].Ig)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\n4. feladat\nSorszám: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            int felajanlasdb = 0;
            foreach (var item in felajanlasok)
            {
                if (item.Tol <= sorszam && item.Ig >= sorszam)
                {
                    felajanlasdb++;
                }
            }
            Console.WriteLine($"Felajánlások száma: {felajanlasdb}");
            foreach (var item in felajanlasok)
            {
                if (item.Tol <= sorszam && item.Ig >= sorszam)
                {
                    Console.WriteLine($"A virágágyás színe, ha csak az első felajánló ültet: {item.Szin}");
                    break;
                }
            }
            HashSet<char> szinek = new HashSet<char>();
            foreach (var item in felajanlasok)
            {
                if (item.Tol <= sorszam && item.Ig >= sorszam)
                {
                    szinek.Add(Convert.ToChar(item.Szin));
                }
            }
            if (szinek.Count > 0)
            {
                Console.Write($"A virágágyás színei:");
                foreach (var item in szinek)
                {
                    Console.Write($" {item}");
                }
            }
            Console.WriteLine($"5. feladat");
            string lehetoseg1 = "Minden ágyás beültetésére van jelentkező.";
            string lehetoseg2 = "Átszervezéssel megoldható a beültetés.";
            string lehetoseg3 = "A beültetés nem oldható meg.";
            
        }
    }
}
