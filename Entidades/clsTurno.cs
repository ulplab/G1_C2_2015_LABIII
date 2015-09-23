using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class clsTurno : IEntidad
    {
        int id;

        int idMedico;

        int idPaciente;

        int nroTurno;

        DateTime fecha;

        int idUsuario;

        bool estado = false;       

        public clsTurno(int id, int idMedico, int idPaciente, DateTime fecha, int idUsuario)
        {
            this.id = id;
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.nroTurno = 0;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
        }

        public clsTurno(int idMedico, int idPaciente, DateTime fecha, int idUsuario)
        {
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.nroTurno = 0;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
        }

        public clsTurno()
        {

        }

        public int NroTurno
        {
            get { return nroTurno; }
            set { nroTurno = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }


        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
