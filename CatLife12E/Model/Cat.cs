using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLife12E.Model
{
    internal class Cat
    {
        // Tulajdonságok  - auto property
        public string Nev { get; set; }
        public double Suly { get; set; }
        public bool EhesE { get; set; }

        //Üres konstruktor
        public Cat()
        {
        }
                
        //3. Paraméteres konstr.
        public Cat(string nev, double suly, bool ehesE)
        {
            Nev = nev;
            Suly = suly;
            EhesE = ehesE;
        }

        public Cat(string nev, double suly)
        {
            Nev = nev;
            Suly = suly;
            EhesE = true;
        }

        public bool Eszik(double etel)
        {
            if (EhesE)
            {
                Suly = Suly + etel;
                EhesE = false; 
                return true;
            }
                return false;
                        
        }
        
        public void Szalad()
        {
            Suly = Suly - 0.5;
            if (!EhesE)
            {
                EhesE = true;
            }
        }


        public override string ToString()
        {
            string ehseg = "";
            if (EhesE) {
                ehseg = "a macska éhes";
            }
            else
            {
                ehseg = "a macska nem éhes";
            }

            return $"A macska neve: {Nev}, súlya: {Suly}, {ehseg}";
        }








    }
}
