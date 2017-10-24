using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Practica7
{
    [Table("Mis Datos")]
  public  class TESHDatos
    {
        int Id;
        string nombre;
        string apellido;
        string direccion;
        int telefono;
        string carrera;
        string semestre;
        string correo;
        string github;


        [PrimaryKey, Column("ID"), MaxLength(8)]
        public int ID
        {


            get { return Id ; }
            set { Id  = value; }
        }

        [MaxLength(30)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [MaxLength(30)]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        [MaxLength(50)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [MaxLength(10)]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [MaxLength(40)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [MaxLength(2)]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [MaxLength(30)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [MaxLength(20)]
        public string GitHub
        {
            get { return github; }
            set { github = value; }
        }
    }
}
