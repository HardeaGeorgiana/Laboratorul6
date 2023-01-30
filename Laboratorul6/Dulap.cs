using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul6
{
    class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;
        public int volum;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
            this.volum = CalculeazaVolum();
        }
        private int CalculeazaVolum()
        {
            return lungime * latime * inaltime;
        }
    }
}
