using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcomerce.Shared
{
    public class Producto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string ImagenUrl { get; set; } = string.Empty;
        public decimal Precio { get; set; }

    }
}
