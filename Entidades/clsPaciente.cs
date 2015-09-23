using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class clsPaciente : IEntidad
    {
        int id;

        long dni;

        string nombre;

        string apellido;

        long telefono;

        public clsPaciente()
        { }

        public clsPaciente(long dni, string nombre, string apellido, long telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public clsPaciente(int id, long dni, string nombre, string apellido, long telefono)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
