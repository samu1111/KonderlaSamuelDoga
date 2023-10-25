using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga1
{
    internal class Bolygok
    {

        public string Nev { get; set; }
        public int Holdak { get; set; }
        public double Arany { get; set; }


        public Bolygok(string sor) {
            string[] adat = sor.Split(';');
            Nev  = adat[0];
            Holdak = int.Parse(adat[1]);
            Arany = double.Parse(adat[2].Replace('.', ','));
        
        
        
        }

    }
}
