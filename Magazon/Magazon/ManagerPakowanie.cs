using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    class ManagerPakowanie
    {
        public List<StacjaPakowania> stacjePakowania;

        public ManagerPakowanie()
        {
            stacjePakowania = new List<StacjaPakowania>();
        }
        public void DodajStacje(int iloscStacji)
        {
            for(int i = 0;i<iloscStacji;i++)
            {
                stacjePakowania.Add(new StacjaPakowania());
            }
        }

        public class StacjaPakowania
        {
            public Queue<ManagerPracownikow.Pracownik> kolejkaDoStacji;

            public StacjaPakowania()
            {
                kolejkaDoStacji = new Queue<ManagerPracownikow.Pracownik>();
            }
        }
    }
}
