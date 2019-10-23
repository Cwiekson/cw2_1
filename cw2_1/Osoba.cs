using System;
using System.Collections.Generic;
using System.Text;

namespace cw2_1
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        internal plec value;
         public enum plec {K,M };
        public int obliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
        public void Przedrostek()
        {
            if (value == plec.M) Console.WriteLine("Dyrektorem jest Pan " + this.imie + " " + this.nazwisko);
            else Console.WriteLine("Dyrektorem jest Pani " + this.imie + " " + this.nazwisko);
        }


    }
}
