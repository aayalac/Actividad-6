using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_6.Entities;

namespace Actividad_6.Educativos
{
    internal class Bodega<T> : IBodega<T> where T : Entity
    {
        private List<T> Registros { get; set; }

        public Bodega()
        {
           Registros = new List<T>();
        }

        public void Registrar(T obj)
        {
            
            obj.Id = "Ticket001";

            Registros.Add(obj);
        }
    }
}
