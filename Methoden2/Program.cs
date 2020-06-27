using System;
using System.Runtime.InteropServices;

namespace Methoden2
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto auto = new Auto();
            auto.Marke = "VW";
            auto.PS = 150;
            auto.Räder = 4;
            Console.WriteLine("Meine Auto ist ein "+ auto.Marke+ " . Es hat "+ auto.Räder
            + " Räder und "+auto.PS+" PS.");

            for (int i= 0;i<3;i++)
            {
            auto.Fahren();
            }
            Console.ReadKey();
        }
    }
    class Auto

    {

        //Eigenschaften
        public  int Räder { get; set; }
        public  string  Marke { get; set; }
        public int PS{ get; set; }

    //Methoden

        public void Fahren()
        {

            Console.WriteLine("das Auto mach brumm brumm");
        }

}

}
