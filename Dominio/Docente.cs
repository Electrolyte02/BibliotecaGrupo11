﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrupo11.Dominio
{
    internal class Docente:Persona
    {
        public int IdDocente { get; set; }
        public Titulo TituloDocente { get; set; }

        public Docente():base()
        {
            IdDocente = 0;
            TituloDocente = new Titulo();
        }
        public Docente(int id,Titulo titulo, string nom, string ape, string dir,
            int alt, string tel, string email, Barrio barrio) : base(nom, ape, dir, alt, tel, email, barrio)
        {
            IdDocente = id;
            TituloDocente = titulo;
        }
    }
}
