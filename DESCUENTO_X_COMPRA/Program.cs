using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DESCUENTO_X_COMPRA
{
    class Cliente
    {
        private float descuento;
        private float precio;
        public void Inicio()
        {
            Console.WriteLine("INGRESE PRECIO: ");
            precio = float.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Descuento()
        {
            if (precio > 1000)
            {
                float res = (precio * 20) / 100;
                descuento = precio - res;
                Console.WriteLine("--------TIENDA KEDINN -------");
                Console.WriteLine("DESCUENTO DEL 20% POR SUPERAR S/1000");
                Console.WriteLine("PRECIO ES: " + descuento);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("--------TIENDA KEDINN -------");

                Console.WriteLine("PRECIO ES: " + precio);
                Console.ReadLine();

            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------TIENDA KEDINN -------");
            Cliente clie = new Cliente();
            clie.Inicio();
            clie.Descuento();

        }

    }
}
