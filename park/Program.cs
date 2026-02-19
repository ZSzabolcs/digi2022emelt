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
                felajanlasok.Add(new Felajanlas(db, Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToChar(sor[2])));
            }
            sr.Close();
            Console.WriteLine($"2. feladat\nA felajánlások száma: {db}\n");
            Console.WriteLine("3.feladat\n");
            foreach (var item in felajanlasok)
            {
                if (item.Tol > item.Ig)
                {
                    Console.Write();
                }
            }
        }
    }
}
