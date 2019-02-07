using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JantarFilosofos
{
    class Garfo
    {
        private bool emuso;

        public Garfo()
        {

            emuso = false;

        }

        public bool EmUso
        {
            get { return emuso; }
            set { emuso = value; }
        } 
 
    }
}
