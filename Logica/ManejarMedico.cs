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
    public class ManejarMedico : IMetodos
    {
        IDBManager manejar;
        public ManejarMedico()
        {
            manejar = new BDMetodos();
        }
        public void Alta (IEntidad entidad)
        {
            clsMedico med = (clsMedico)entidad;
            try
            {
                
                manejar.Ejecutar("insert into medico (nombre,apellido,dni,matricula,especialidad) values('" + med.Nombre + "','" + med.Apellido + "'," + med.Dni + "," + med.Matricula + ",'" + med.Especialidad + "');SELECT @@identity;");
              
            }
            catch( SqlException ex)
            {
                throw ex;
            }

        }

        public void Baja(IEntidad entidad)
        {
            clsMedico med = (clsMedico)entidad;
            try
            {
                manejar.Ejecutar("delete from  medico where idmedico="+med.Id);
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
                dt = DBManager.Consultar("select * from medico");
                foreach(DataRow x in dt.Rows)
                {
                    clsMedico A = new clsMedico();
                    A.Id = Convert.ToInt32(x["idmedico"]);
                    A.Nombre = x["nombre"].ToString();
                    A.Apellido = x["apellido"].ToString();
                    A.Especialidad = x["especialidad"].ToString();
                    A.Matricula = Convert.ToInt32( x["matricula"] );
                    A.Dni = Convert.ToInt32(x["dni"]);
                    list.Add(A);
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
            clsMedico med = (clsMedico)entidad;
            try
            {
                manejar.Ejecutar("update medico set apellido='" + med.Apellido + "',nombre='" + med.Nombre + "',dni=" + med.Dni + ",matricula=" + med.Matricula + ",especialidad='" + med.Especialidad + "' where idmedico="+med.Id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }

        }

        public IEntidad buscarPorId(int id)
        {
            clsMedico med = new clsMedico();
            DataTable aux = new DataTable();
            
            try
            {
                aux =manejar.Consultar("select * from medico where idMedico="+id);
                med.Id = Convert.ToInt32(aux.Rows[0]["idMedico"]);
                med.Apellido = aux.Rows[0]["apellido"].ToString();
                med.Nombre = aux.Rows[0]["nombre"].ToString();
                med.Matricula = Convert.ToInt32(aux.Rows[0]["matricula"]);
                med.Dni = Convert.ToInt32(aux.Rows[0]["dni"]);
                med.Especialidad = aux.Rows[0]["especialidad"].ToString();

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return med;

        }

        IDBManager DBManager = new BDMetodos();

        private clsMedico getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsMedico)))
                return (clsMedico)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

    }
}
