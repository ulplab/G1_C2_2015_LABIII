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
    public class ManejaUsuarios: IMetodos
    {
        IDBManager manejar;
        public ManejaUsuarios()
        {
            manejar = new BDMetodos();
        }
        public void Alta (IEntidad entidad)
        {
            clsUsuarios usu = (clsUsuarios)entidad;
            try
            {
                manejar.Ejecutar("insert into usuario (username,contraseña) values('" +usu.Username  + "','" + usu.Contraseña+"');SELECT @@identity;");
            }
            catch( SqlException ex)
            {
                throw ex;
            }

        }
        public void Baja(IEntidad entidad)
        {
            clsUsuarios usu = (clsUsuarios)entidad;
            try
            {
                manejar.Ejecutar("delete from usuario where idusuario="+usu.Id);
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
                dt = DBManager.Consultar("select * from usuario");
                foreach(DataRow x in dt.Rows)
                {
                    clsUsuarios U = new clsUsuarios();
                    U.Id = Convert.ToInt32(x["idUsuario"]);
                    U.Username= x["username"].ToString();
                    U.Contraseña = x["contraseña"].ToString();
                    list.Add(U);
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
            clsUsuarios usu = (clsUsuarios)entidad;
            try
            {
                manejar.Ejecutar("update usuario set username='" + usu.Username + "',contraseña='" + usu.Contraseña +" where idUsuario="+usu.Id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }

        }

        public IEntidad buscarPorId(int id)
        {
            clsUsuarios usu = new clsUsuarios();
            DataTable aux = new DataTable();
            
            try
            {
                aux =manejar.Consultar("select * from usuario where idUsuario="+id);
                clsUsuarios U = new clsUsuarios();
                U.Id = Convert.ToInt32(aux.Rows[0]["idUsuario"]);
                U.Username = aux.Rows[0]["username"].ToString();
                U.Contraseña = aux.Rows[0]["contraseña"].ToString();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return usu;
        }

        IDBManager DBManager = new BDMetodos();

        private clsUsuarios getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsUsuarios)))
                return (clsUsuarios)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

    
    }
}
