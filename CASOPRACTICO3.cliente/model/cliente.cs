using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOPRACTICO3.cliente.model
{
    public class cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_emision { get; set; }
        public string descripcion { get; set; }
        public string comentario { get; set; }
        public string url { get; set; }
    }
}
