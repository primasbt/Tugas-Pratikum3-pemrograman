using System;

namespace taxi
{
    class Car
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.Driver = "Joe";
            taxi.OnDuty = true;
            taxi.JumlahPelanggan = 10;

            taxi.TaxiInfo();
            taxi.JemputPenumpang();
            taxi.DropOff();

            Console.ReadKey();
        }
    }
}