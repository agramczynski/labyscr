using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    class Kierownik : Agent
    {
        public ManagerMagazynow managerMagazynow;
        public ManagerPakowanie managerPakowanie;
        public ManagerPracownikow managerPracownikow;

        public Kierownik(): base()
        {
            nazwa = "id " + id + ", kierownik";
            managerPracownikow = new ManagerPracownikow();
            managerPakowanie = new ManagerPakowanie();
            managerMagazynow = new ManagerMagazynow();
        }

        public void DodajMagazyny()
        {

        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
