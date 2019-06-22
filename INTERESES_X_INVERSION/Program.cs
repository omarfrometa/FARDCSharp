using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INTERESES_X_INVERSION
{
    class Hombre
    {
        private string nombre;
        private float dinero;
        public void Inicio()
        {
            Console.WriteLine("---------BANCO COMOPROGRAMAR.ORG--------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("INGRESE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE SU MONTO DINERO; ");
            dinero = float.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Imprimir()
        {
            Console.WriteLine("---------BANCO COMOPROGRAMAR.ORG--------");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("NOMBRE:    " + nombre);

            if (dinero > 7000)
            {
                Console.WriteLine("USTED NO PUEDE EXCEDER EL MONTO DE S/ 7000");
            }
            else
            {
                Console.WriteLine("INVERSION: " + dinero);
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {

            Hombre per = new Hombre();
            per.Inicio();
            per.Imprimir();

        }
    }
}
