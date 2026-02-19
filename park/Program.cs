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
                felajanlasok.Add(new Felajanlas(db, sor[0], sor[1], Convert.ToChar(sor[2])));
            }
            sr.Close();
        }
    }
}
