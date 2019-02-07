using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JantarFilosofos
{
    class Filosofo
    {
        private bool comendo;

        public Filosofo()
        {
            comendo = false;
        }
        public bool Comendo
        {
            get { return comendo; }
            set { comendo = value; }
        }
    }
}
