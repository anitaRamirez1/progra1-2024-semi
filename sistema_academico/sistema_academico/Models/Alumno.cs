﻿using System.ComponentModel.DataAnnotations;

namespace sistema_academico.Models
{
    public class Alumno
    {
        [Key ]
        public int idAlumno { get; set; }
        public string codigo { get; set; } 
        public string nombre { get; set; } 
        public string direccion { get; set; } 
        public string telefono { get; set; } 
    }
}
