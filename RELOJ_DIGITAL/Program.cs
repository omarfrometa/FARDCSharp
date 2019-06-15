using System;

namespace RELOJ_DIGITAL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte H, M, S;

            Console.SetCursorPosition(15, 2);

            Console.Write("SIMULACION DE UN RELOJ DIGITAL");

            for (H =0; H <= 24; H++)
            {
                for (M = 0; M <= 59; M++)
                {
                    for (S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(25, 15);
                        //Console.WriteLine(""+ H +" : " + M +" : "+ S + "");
                        Console.WriteLine($"{H} : {M} : {S}");

                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }

            Console.SetCursorPosition(25, 15);
            Console.WriteLine("Pulsa una tecla pa' terminar esto!");
            Console.ReadLine();
        }
    }
}
