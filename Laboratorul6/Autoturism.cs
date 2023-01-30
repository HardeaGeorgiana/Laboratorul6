using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul6
{
    class Autoturism
    {
        private string marca;
        private string nrDeInmatriculare;
        private int capCilindrica;

        public Autoturism(string marca, string nrDeInmatriculare, int capCilindrica)
        {
            this.marca = marca;
            this.nrDeInmatriculare = nrDeInmatriculare;
            this.capCilindrica = capCilindrica;
        }

        public void Tipareste()
        {
            Console.WriteLine($"marca: {this.marca} \n numar de inmatriculare: {this.nrDeInmatriculare} \n capacitate cilindrica: {this.capCilindrica}");
        }

    }
}
