using System;

namespace cw2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    KlasaMetodyPrzeciazone obiekt = new KlasaMetodyPrzeciazone();
            //    string zwroconaWartosc = null;

            //    zwroconaWartosc = obiekt.jakiTyp();
            //    Console.WriteLine(zwroconaWartosc);

            //    zwroconaWartosc = obiekt.jakiTyp(123);
            //    Console.WriteLine(zwroconaWartosc);
            //    Console.ReadKey();
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1967;
            dyrektor.waga = 86;
            dyrektor.wzrost = 180;
            dyrektor.okulary = true;
            dyrektor.value = Osoba.plec.M;
            // Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", dyrektor.imie, dyrektor.nazwisko, dyrektor.rokUrodzenia,dyrektor.waga,dyrektor.wzrost,dyrektor.okulary,dyrektor.value);
            Console.WriteLine("{0} {1} {2}",dyrektor.imie,dyrektor.nazwisko, dyrektor.obliczWiek());
            dyrektor.Przedrostek();
            Console.ReadKey();
        }
    }
    //class KlasaMetodyPrzeciazone
    //{

    //    public string jakiTyp()
    //    {
    //        return "Nie podano argumentów metody";
    //    }


    //    public string jakiTyp(int zmienna)
    //    {
    //        return "Liczba całkowita";
    //    }

    //    public string jakiTyp(string zmienna)
    //    {
    //        return "Łańcuch znaków";
    //    }
    }
