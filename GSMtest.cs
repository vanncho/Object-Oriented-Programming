namespace _01.Define_Class
{
    using System;

    class GSMtest
    {
        static void Main(string[] args)
        {
            GSM[] telefon = new GSM[3];

            telefon[0] = new GSM("E52", "Nokia", 525.20m, "Ivan", "Ivanov", BatteryType.LiIon, 15, 3, "1080 x 1920", 24000000);
            telefon[1] = new GSM("A5000", "Lenovo");
            telefon[2] = GSM.IPhone4S;
            
            foreach (var phone in telefon)
            {
                Console.WriteLine(phone);
            }

        }
    }
}
