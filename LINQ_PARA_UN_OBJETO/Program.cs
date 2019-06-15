using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_PARA_UN_OBJETO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SIN FILTRO");
            List<string> list = new List<string>();

            list.Add("Jose Luis");
            list.Add("Manuel Savinon");
            list.Add("Coronel Jose");
            list.Add("Pedro Martinez");
            list.Add("Jose Feliz");
            list.Add("Jose Manuel Feliz Savinon");

            foreach (var item in list)
            {
                Console.WriteLine($"Estudiante: " + item.ToUpper());
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("FILTRADO POR NOMBRE");
            var list2 = list.Where(x => x.Contains("Jose")).ToList();

            foreach (var item in list2)
            {
                Console.WriteLine($"Estudiante: " + item.ToUpper());
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("FILTRADO POR QUERY");
            var query = from a in list where a.Equals("Coronel Jose") select a;

            foreach (var item in query)
            {
                Console.WriteLine($"Estudiante: " + item.ToUpper());
            }

            Console.ReadLine();
        }
    }
}
