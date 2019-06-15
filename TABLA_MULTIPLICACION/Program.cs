using System;

namespace TABLA_MULTIPLICACION
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string var1;
            int var2, resultado, cont;
            
            Console.WriteLine("DIGITE UN VALOR A GENERAR TABLA");
            var1 = Console.ReadLine();
            var2 = Convert.ToInt32(var1);
            cont = 0;
            while (cont < 13)
            {
                resultado = var2 * cont;
                    Console.WriteLine(var2 +" X " +cont.ToString() +" = "+
                    Convert.ToString(resultado));
                cont++;
             
            }
            Console.ReadLine();
        }
    }
}
