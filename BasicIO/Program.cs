using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta;
            string rivi="";
            Mammal nisakas = new Mammal("Nisuli");
            


            nisakas.puhuu();

            Console.WriteLine("Talleta data anna 1, muu numero lue data");
            valinta = int.Parse(Console.ReadLine());

            if (valinta == 1)
                nisakas.MySaveToDisk();

            else
                rivi=nisakas.MyReadFromDisk();

           
            if(valinta!=1)
                Console.WriteLine("Luettu data uudestaan "+rivi+" pääohjelmasta !");

            Apuluokka.Pause();
        }
    }
}
