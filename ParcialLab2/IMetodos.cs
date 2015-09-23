using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMetodos
    {
        void Alta(IEntidad entidad);
        void Baja(IEntidad entidad);
        void Modificacion(IEntidad entidad);
        IEntidad buscarPorId(int id); 
        List<IEntidad> Todo();
    }
}
