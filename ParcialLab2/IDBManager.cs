using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces
{
    public enum MetodoType { medicos, pacientes, usuarios, turnos }
    public enum Tipo { alta, baja, modificar }
    public interface IDBManager
    {
        int Ejecutar(String sql);
        int Ejecutar(String spNobre, SqlParameter[] sqlParam);
        DataTable Consultar(String sql);
        DataTable Consultar(String spNobre, SqlParameter[] sqlParam);
    }
}
