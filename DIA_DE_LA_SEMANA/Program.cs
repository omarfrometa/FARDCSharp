using System;

namespace DIA_DE_LA_SEMANA
{
    class MainClass
    {
        public static DateTime vFecha;

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la fecha:");
            vFecha = Convert.ToDateTime(Console.ReadLine());
            string NombreDia = vFecha.ToString("dddd");
            Console.WriteLine("EL NOMBRE DEL DIA ES: " + NombreDia);
            Console.ReadKey();
        }
    }
}
