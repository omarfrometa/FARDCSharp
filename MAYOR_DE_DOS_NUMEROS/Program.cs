using System;

namespace MAYOR_DE_DOS_NUMEROS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MAYOR();
        }
        static void MAYOR()
        {
            int num;
            int num2;
            Console.WriteLine("Escribir el primer numero");
            num = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el segundo numero");
            num2 = Int16.Parse(Console.ReadLine());
            if (num>num2)
            {
                Console.WriteLine("El numero mayor es:" + num);
            }
            else if(num<num2)
            {
                Console.WriteLine("El numero mayor es:" + num2);
            }
            else
            {
                Console.WriteLine("Los numero son iguales");
            }


        }

    }
}
