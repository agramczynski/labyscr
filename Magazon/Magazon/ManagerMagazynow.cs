using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    class ManagerMagazynow
    {
        public List<Magazyn> Magazyny;

        public ManagerMagazynow()
        {
            Magazyny = new List<Magazyn>();
        }

        public void DodajMagazyny(int iloscMagazynow, int pojemnoscMagazynow)
        {
            for (int i = 0; i < iloscMagazynow; i++)
            {
                Magazyny.Add(new Magazyn(pojemnoscMagazynow, null));
            }
        }

        public void DodajMagazyn(string nazwaProduktu, int pojemnoscMagazynow)
        {
                Magazyny.Add(new Magazyn(pojemnoscMagazynow, nazwaProduktu));
        }
        public class Magazyn
        {
            public Queue<ManagerPracownikow.Pracownik> KolejkaDoMagazynu;
            bool wolny = false;
            static int iloscMagazynow = 0;
            public string nazwaProduktu;
            public int idMagazynu;
            public int pojemnosc = 100;
            public int zapelnione = 0;

            public Magazyn(int pojemnosc, string nazwa)
            {
                KolejkaDoMagazynu = new Queue<ManagerPracownikow.Pracownik>();
                idMagazynu = iloscMagazynow;
                iloscMagazynow++;
                if (nazwa != null) nazwaProduktu = nazwa;
                else nazwaProduktu = "Produkt nr " + idMagazynu;
                this.pojemnosc = pojemnosc;
            }

            public void Info()
            {
                Console.WriteLine("Magazyn, który przechowuje " + nazwaProduktu + " ma pojemność: " + pojemnosc);
            }
        }
    }
}