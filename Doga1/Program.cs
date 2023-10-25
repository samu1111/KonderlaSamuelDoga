using System.IO;
using System.Text;

namespace Doga1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygok> lista = new List<Bolygok>();
            using (StreamReader sr = new StreamReader(path: @"..\..\..\Mappa\solsys.txt", encoding: Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(new Bolygok(sr.ReadLine()));
                }
            }
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"\t3.1: {lista.Count} bolygó van a naprendszerben");
            var atlag = lista.Average(b => b.Holdak);
            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {atlag} holdja van");
            var max = lista.SingleOrDefault(b => b.Arany == lista.Max(c => c.Arany));
            Console.WriteLine($"3.3: A legnagyobb térfogatú bolygó a " + 
                $"{max.Nev}");
            Console.Write($"3.4: Írd be a keresett Bolygó nevét: ");
            var ize = Console.ReadLine();
            Console.WriteLine(lista.SingleOrDefault(b => b.Nev == ize) != null ?
                "Van ilyen bolygó a naprendszerben." :
                "Sajnos nincs ilyen bolygó a naprendszerben. ");

            Console.WriteLine("3.5: Írj be egy egész számot: ");
            var szam = int.Parse(Console.ReadLine());
            var hold = lista.Where(b => b.Holdak > szam).Select(b => b.Nev).ToArray();
            Console.WriteLine($"A következő bolygóknak van {szam}-nál/nél több holdja ");
            foreach (var item in hold)
            {
                Console.Write($"{item}, ");
            }  
            



        }
    }
}