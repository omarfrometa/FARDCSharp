using System;
using LiteDB;

namespace Agenda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("PROGRAMA DE CIUDADANOS");

            Console.WriteLine("QUE DESEAS HACER");
            Console.WriteLine("1. Preciona (N) para agregar un ciudadano");
            Console.WriteLine("2. Preciona (L) para listar los ciudadanos");

            string linea = Console.ReadLine();
            if (linea.ToLower().Equals("n"))
            {
                AddNew();
            }
            else if (linea.ToLower().Equals("l"))
            {
                List();
            }
            else
            {
                Console.WriteLine("OPCION INVALIDA");
                Start();
            }
        }

        public static void AddNew()
        {
            using (var db = new LiteDatabase(@"ciudadanos.db"))
            {
                var ciudadanos = db.GetCollection<Models.CiudadanoModel>("ciudadanos");
                var ciudadano = new Models.CiudadanoModel();

                Console.WriteLine();
                Console.WriteLine("NUEVO CIUDADANO");
                Console.WriteLine();

                Console.WriteLine("Cedula:");
                ciudadano.Cedula = Console.ReadLine();

                if(string.IsNullOrEmpty(ciudadano.Cedula))
                {
                    Console.WriteLine("Digita la Cedula pues esta en blanco:");
                    ciudadano.Cedula = Console.ReadLine();
                }

                Console.WriteLine("Nombres:");
                ciudadano.Nombre = Console.ReadLine();

                Console.WriteLine("Apellidos:");
                ciudadano.Apellidos = Console.ReadLine();

                Console.WriteLine("Telefono:");
                ciudadano.Telefono = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("------ RESUMEND DE LA CAPTURA --------");
                Console.WriteLine("Nombre: " + ciudadano.Nombre + " " + ciudadano.Apellidos);
                Console.WriteLine("Cedula: " + ciudadano.Cedula);
                Console.WriteLine("Telefono: " + ciudadano.Telefono);

                ciudadanos.Insert(ciudadano);

                Console.WriteLine();
                Console.WriteLine("CIUDADANO GUARDADO");

                Start();
            }
        }

        public static void List()
        {
            using (var db = new LiteDatabase(@"ciudadanos.db"))
            {
                var ciudadanos = db.GetCollection<Models.CiudadanoModel>("ciudadanos");
                var results = ciudadanos.Find(Query.All(Query.Descending));

                Console.WriteLine();
                Console.WriteLine("LISTADO DE CIUDADANOS");
                Console.WriteLine();

                foreach (var ciudadano in results)
                {
                    Console.WriteLine();

                    Console.WriteLine("ID: " + ciudadano.Id);
                    Console.WriteLine("Nombre: " + ciudadano.Nombre + " " + ciudadano.Apellidos);
                    Console.WriteLine("Cedula: " + ciudadano.Cedula);
                    Console.WriteLine("Telefono: " + ciudadano.Telefono);
                    Console.WriteLine();
                }

                Start();
            }
        }
    }
}
