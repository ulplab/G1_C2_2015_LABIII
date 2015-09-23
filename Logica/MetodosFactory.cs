using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades;

namespace Logica
{
    public class MetodosFactory : IMetodosFactory
    {
        public IMetodos getMetodos(MetodoType tipo)
        {
            IMetodos metodo = null;
            switch (tipo)
            {
                case MetodoType.medicos:
                    metodo = new ManejarMedico();break;
                case MetodoType.pacientes:
                    metodo = new ManejaPaciente();break;
                case MetodoType.usuarios:
                    metodo = new ManejaUsuarios();break;
                case MetodoType.turnos:
                    metodo = new ManejaTurnos();break;
                    
            }
            return metodo;
        }
    }
}
