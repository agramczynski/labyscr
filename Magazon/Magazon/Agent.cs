using Magazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazon
{
    public abstract class Agent : IRunnable
    {
        protected static int licznik = 0;
        protected static int freqMS = 100;
        protected int id;
        public string nazwa;

        public bool HasFinished{ get; set;}


        protected Agent()
        {
            HasFinished = false;
            id = licznik;
            licznik++;
            nazwa = "id " + id + ", nienazwany";
        }
        public abstract void Update();

        public void Run()
        {
            while (!HasFinished)
            {
                Update();
                Thread.Sleep(1000);
            }

        }
    }
}
