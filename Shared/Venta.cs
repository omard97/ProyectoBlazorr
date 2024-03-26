using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlazor.Shared
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string NombreCliente { get; set; } = string.Empty;
        public double? ValorProducto { get; set; }

        public double? EfectivoCliente { get; set; }
        public double? Cambio { get; set; }
        public int Transferecnia { get; set; } = 0;

    }
}
