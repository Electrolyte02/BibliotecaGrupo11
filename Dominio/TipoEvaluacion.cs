using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrupo11.Dominio
{
    internal class TipoEvaluacion
    {
        public int IdTipoEvaluacion { get; set; }
        public string DescTipoEvaluacion { get; set; }

        public TipoEvaluacion()
        {
            IdTipoEvaluacion = 0;
            DescTipoEvaluacion = string.Empty;
        }
        public TipoEvaluacion(int id,string desc)
        {
            IdTipoEvaluacion = id;
            DescTipoEvaluacion = desc;
        }

        public override string ToString()
        {
            return DescTipoEvaluacion;
        }
    }
}
