using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Kierownik kierownik = new Kierownik();
            Console.Out.WriteLine(kierownik.nazwa);
            ManagerPracownikow mp = new ManagerPracownikow(5);
            for(int i = 0; i< mp.iloscPracownikow; i++)
            {
                Console.Out.WriteLine(mp.Pracownicy[i].nazwa);
                
            }
            ManagerMagazynow mm = new ManagerMagazynow(5);

            foreach(ManagerMagazynow.Magazyn m in mm.Magazyny)
            {
                m.Info();
            }
            Console.ReadKey();
        }
    }
}
