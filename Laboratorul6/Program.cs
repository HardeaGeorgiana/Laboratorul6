using System;

namespace Laboratorul6
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();            
        }

        static void Ex1()
        {
            /*  Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
           metoda care va calcula volumul acestuia.
           Folositi o clasa care va modela un dulap.
           - Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
           - Cele trei campuri vor fi initializate cu ajutorul constructorului
           - Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
           Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
           afisati rezultatul.

        */

            Dulap dulap1 = new Dulap(1, 5 ,9);

            Console.WriteLine($"Volumul dulapului este {dulap1.volum}");
        }
        static void Ex2()
        {
            /*  Scrieti un program care va modela un autoturism. Un autoturism va avea o
                marca (string), un numar de inmatriculare (string), precum si o
                capacitate cilindrica(int).
                Autoturismul va avea:
                     - Campurile corespunzatoare caracteristicilor autoturismului.
                     - Un constructor care va initializa campurile acestuia
                     - O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
                numarDeInmatriculare, capacitateCilindrica”.
                Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
                xml pentru metodele publice.
                Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
                metodele “Tipareste”

             */

            Autoturism auto1 = new Autoturism("opel", "BC 02 KLP", 2000);
            Autoturism auto2 = new Autoturism("dacia", "B 100 OPI", 1000);

            auto1.Tipareste();
            auto2.Tipareste();
        }
    }
}
