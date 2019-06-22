using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALARIO_SEMANAL
{
    class Camisas
    {
        int camisas;
        float precio;
        public void Ingresar()
        {
            Console.WriteLine("INGRESE NUMERO DE CAMISAS");
            camisas = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE PRECIO DE LAS CAMISAS");
            precio = float.Parse(Console.ReadLine());
        }
        public void Trabajo()
        {
            if (camisas >= 3)
            {
                float a = (precio * 20) / 100;
                float b = precio - a;
                Console.WriteLine("DESCUENTO 20% PRECIO ES:  " + b);

            }
            else
            {
                float a = (precio * 01) / 100;
                float b = precio - a;
                Console.WriteLine("DESCUENTO 20% PRECIO ES:  " + b);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Camisas sem = new Camisas();
            sem.Ingresar();
            sem.Trabajo();

        }
    }
}