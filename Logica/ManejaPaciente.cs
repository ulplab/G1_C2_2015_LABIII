using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Logica
{
    public class ManejaPaciente: IMetodos
    {
      IDBManager manejar;
        public ManejaPaciente()
        {
            manejar = new BDMetodos();
        }

        public void Alta (IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;
            try
            {
                manejar.Ejecutar("insert into paciente (nombre,apellido,dni,telefono) values('" + pac.Nombre + "','" + pac.Apellido + "'," + pac.Dni + "," +pac.Telefono+ ");SELECT @@identity;");
            }
            catch( SqlException ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;
            try
            {
                manejar.Ejecutar("delete from  paciente where idpaciente="+pac.Id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public List<IEntidad> Todo()
        {
            List<IEntidad> list= new List<IEntidad>();
            DataTable dt = new DataTable();
            try
            {
                dt = DBManager.Consultar("select * from paciente");
                foreach(DataRow x in dt.Rows)
                {
                    clsPaciente P = new clsPaciente();
                    P.Id = Convert.ToInt32(x["idpaciente"]);
                    P.Nombre = x["nombre"].ToString();
                    P.Apellido = x["apellido"].ToString();
                    P.Dni = Convert.ToInt64(x["dni"]);
                    P.Telefono = Convert.ToInt64(x["telefono"]);
                    list.Add(P);
                }
            }
            catch (SqlException ex)
            {
               throw ex;
            }
            return list;
        }

        public void Modificacion(IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;
            try
            {
                manejar.Ejecutar("update paciente set apellido='" + pac.Apellido + "',nombre='" + pac.Nombre + "',dni=" + pac.Dni + "',telefono=" + " where idpaciente=" + pac.Id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public IEntidad buscarPorId(int id)
        {
            DataTable aux = new DataTable();
            clsPaciente P = new clsPaciente();
            try
            {
                aux =manejar.Consultar("select * from paciente where idPaciente="+id);
                P.Id = Convert.ToInt32(aux.Rows[0]["idPaciente"]);
                P.Nombre = aux.Rows[0]["nombre"].ToString();
                P.Apellido = aux.Rows[0]["apellido"].ToString();
                P.Dni = Convert.ToInt64(aux.Rows[0]["dni"]);
                P.Telefono = Convert.ToInt64(aux.Rows[0]["telefono"]);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return P;
        }

        IDBManager DBManager = new BDMetodos();

        private clsPaciente getCast(IEntidad e)
         {
             if (e.GetType().Equals(typeof(clsPaciente)))
                 return (clsPaciente)e;
             else
                 throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
         }
    }
}
