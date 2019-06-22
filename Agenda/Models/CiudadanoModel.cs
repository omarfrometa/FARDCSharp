using System;
namespace Agenda.Models
{
    public class CiudadanoModel
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string LugarNacimiento { get; set; }
        public string Telefono { get; set; }
        public bool Vive { get; set; } = false;
    }
}
