using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class clsUsuarios : IEntidad
    {
        private int id;
        private string username;
        private string contraseña;

        public clsUsuarios(int id, string usuario, string clave)
        {
            this.id = id;
            this.username = usuario;
            this.contraseña = clave;
        }

        public clsUsuarios(string username, string contraseña)
        {
            this.username = username;
            this.contraseña = contraseña;
        }

        public clsUsuarios()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

    }
}
