using System;

namespace taxi
{
    class Taxi
    {

        public string Driver { get; set; }
        public bool OnDuty { get; set; }
        public int JumlahPelanggan { get; set; }

        public void TaxiInfo()
        {
            string duty;

            if (OnDuty)
            {
                duty = "ONLINE";
            }
            else
            {
                duty = "OFFLINE";
            }

            Console.WriteLine("Nama Driver: {0}", Driver);
            Console.WriteLine("Status: {0}", duty);
            Console.WriteLine("Jumlah Pelanggan: {0}", JumlahPelanggan);
        }

        public void JemputPenumpang()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", Driver);
        }

        public void DropOff()
        {
            Console.WriteLine("{0} Telah selesai mengantar penumpang", Driver);
        }

    }
}

    
    

   

