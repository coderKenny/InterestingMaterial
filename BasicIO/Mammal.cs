using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task17
{
    internal class Mammal:MyDiskIOOperations
    {
        int ika;
        string vari, nimi;

        public Mammal(string nimi)
        {
            this.nimi = nimi;
        }

        internal virtual void kavelee()
        {
            Console.WriteLine(this.nimi + " niminen nisäkäs kävelee");

        }

        internal virtual void puhuu()
        {
            Console.WriteLine(this.nimi + " niminen nisäkäs puhuu");
        }

        internal virtual int kertoo_ikansa()
        {
            return this.ika;
        }

        internal virtual void asettaa_ikansa(int ika)
        {
            this.ika = ika;
        }


        public void MySaveToDisk()
        {
            // WriteAllText
            File.WriteAllText("mammal.txt",this.GetType().ToString());
            Console.WriteLine(this.GetType().ToString());
            Console.WriteLine("Data written");
            Apuluokka.InsertWideLineSepatator();
 
        }

        public string MyReadFromDisk()
        {
            // Read in every line in specified file.
            // ... This will store all lines in an array in memory.
            string[] lines = File.ReadAllLines("mammal.txt");

            Console.WriteLine(lines[0]);
        
            Console.WriteLine("Data read");
            Apuluokka.InsertWideLineSepatator();

            return lines[0];
        
        }


    }
}
