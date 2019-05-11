using Magazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    class ManagerPracownikow
    {
        public List<Pracownik> Pracownicy;
        public int iloscPracownikow = 0;

        public ManagerPracownikow()
        {
            Pracownicy = new List<Pracownik>();
        }

        public void DodajPracownikow(int iloscPracownikow)
        {
            this.iloscPracownikow += iloscPracownikow;
            for (int i = 0; i < iloscPracownikow; i++)
            {
                Pracownicy.Add(new Pracownik());
            }
        }

        public class Pracownik : Agent
        {
            public Pracownik() : base()
            {
                nazwa = "id " + id + ", pracownik magazynowy";
            }

            public override void Update()
            {
            }
        }

    }
}
