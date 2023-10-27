﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrupo11.Dominio
{
    internal class Alumno : Persona
    {
        public int IdAlumno { get; set; }
        public SituacionLaboral SituacionAlumno { get; set; }
        public EstadoCivil EstadoCivilAlumno { get; set; }

        public Alumno():base()
        {
            IdAlumno= 0;
            SituacionAlumno = new SituacionLaboral();
            EstadoCivilAlumno = new EstadoCivil();
        }

        public Alumno(int id,SituacionLaboral sit,EstadoCivil est,string nom,string ape,string dir,
            int alt,string tel,string email, Barrio barrio):base(nom,ape,dir,alt,tel,email,barrio)
        {
            IdAlumno = id;
            SituacionAlumno = sit;
            EstadoCivilAlumno = est;
        }
    }
}