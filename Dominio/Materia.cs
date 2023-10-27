using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrupo11.Dominio
{
    internal class Materia
    {
        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }

        public Materia()
        {
            IdMateria = 0;
            NombreMateria = string.Empty;
        }
        public Materia(int id,string nom)
        {
            IdMateria = id;
            NombreMateria = nom;
        }

        public override string ToString()
        {
            return NombreMateria;
        }
    }
}
