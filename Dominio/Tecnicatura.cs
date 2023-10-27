using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrupo11.Dominio
{
    internal class Tecnicatura
    {
        public int IdTecnicatura { get; set; }
        public string NombreTecnicatura { get; set; }
        public string TituloTecnicatura { get; set; }
        public List<Materia> MateriasTecnicatura { get; set; }

        public Tecnicatura()
        {
            IdTecnicatura = 0;
            NombreTecnicatura = string.Empty;
            TituloTecnicatura=string.Empty;
            MateriasTecnicatura = new List<Materia>();
        }

        public Tecnicatura(int id,string nom,string tit,List<Materia> lMaterias)
        {
            IdTecnicatura = id;
            NombreTecnicatura = nom;
            TituloTecnicatura = tit;
            MateriasTecnicatura = lMaterias;
        }

        public override string ToString()
        {
            return NombreTecnicatura;
        }
    }
}
