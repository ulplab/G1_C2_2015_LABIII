using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades;//arreglado
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Logica
{
    public class ManejaTurnos : IMetodos
    {
       IDBManager manejar;
       public ManejaTurnos()
        {
            manejar = new BDMetodos();
        }

       
        public void Alta (IEntidad entidad)
        {
            clsTurno tur = (clsTurno)entidad;
            int estado = 0;
            if(tur.Estado)
                estado = 1;
            
            try
            {

                manejar.Ejecutar("insert into turno (idUsuario,idPaciente,idMedico,fecha,numero,asistencia) values(" +tur.IdUsuario + ","+tur.IdPaciente + "," + tur.IdMedico + ",'" + tur.Fecha + "'," + tur.NroTurno + ",'" +estado+ "');SELECT @@identity;");
              
            }
            catch( SqlException ex)
            {
                throw ex;
            }

        }
        public void Baja(IEntidad entidad)
        {
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manejar.Ejecutar("delete from  turno where idturno=" + tur.Id);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 23503)
                {
                    throw new Exception("No se puede eliminar el medico debido a que tiene turnos pendientes");

                }
                throw ex;
            }



        }
        public List<IEntidad> Todo()
        {
           List<IEntidad> list= new List<IEntidad>();
            DataTable dt = new DataTable();
            try
            {
                dt = DBManager.Consultar("select * from turno");
                foreach(DataRow x in dt.Rows)
                {
                    clsTurno T = new clsTurno();
                    T.Id = Convert.ToInt32(x["idturno"]);
                    T.IdUsuario = Convert.ToInt32(x["idusuario"]);
                    T.IdMedico =Convert.ToInt32(x["idmedico"]);
                    T.IdPaciente = Convert.ToInt32(x["idpaciente"]);
                    T.Estado = Convert.ToBoolean(x["asistencia"]);
                    T.Fecha = Convert.ToDateTime(x["fecha"]);
                    T.NroTurno = Convert.ToInt32(x["numero"]);
                    list.Add(T);
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
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manejar.Ejecutar("update turno set idUsuario="+tur.IdUsuario+",idpaciente=" + tur.IdPaciente + ",idmedico=" + tur.IdMedico + ",fecha=" + tur.Fecha + "',numero=" + tur.NroTurno + "',asistencia="+tur.Estado + " where idturno=" + tur.Id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            
        }

        public IEntidad buscarPorId(int id)
        {
            DataTable aux = new DataTable();
            clsTurno T = new clsTurno();

            try
            {
                aux =manejar.Consultar("select * from turno where idTurno="+id);
                T.Id = Convert.ToInt32(aux.Rows[0]["idTurno"]);
                T.IdMedico = Convert.ToInt32(aux.Rows[0]["idMedico"]);
                T.IdUsuario =Convert.ToInt32( aux.Rows[0]["idUsuario"]);
                T.IdPaciente = Convert.ToInt32(aux.Rows[0]["idPaciente"]);
                T.Estado = Convert.ToBoolean(aux.Rows[0]["asistencia"]);
                T.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                T.NroTurno = 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return T;

        }

        IDBManager DBManager = new BDMetodos();

        private clsTurno getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsTurno)))
                return (clsTurno)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }
       
    }
}
