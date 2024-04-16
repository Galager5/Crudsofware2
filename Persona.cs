using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSofware2
{
    public class Persona
    {
        public int matricula { get; set; } 
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string grado { get; set; }
        public string celular { get; set;}
        public Persona() { }

        public Persona(int id, string nombre, int edad, string celular)
        {
            this.matricula= matricula;
            this.nombres = nombre;
            this.apellidos = apellidos;
            this.grado = grado;
            this.celular = celular;
        }
    }
}
