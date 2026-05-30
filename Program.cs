using System;

namespace BMW
{
    class Program
    {
        static void Main()
        {
            BMW e46 = new BMW ();
            e46.setDate ("e46 " , 3000 , "manuala");

            BMW e39 = new BMW();
            e39.setDate  ("e39 ", 3500 ,"manuala");
        }
    }
}