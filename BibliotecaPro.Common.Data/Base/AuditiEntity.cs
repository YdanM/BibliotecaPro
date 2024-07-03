using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPro.Common.Data.Base
{
    public abstract class AuditiEntity <TType> : BaseEntity <TType>
    {
        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public required string? Descripcion { get; set; }

        public int? Codigo { get; set; }

        public required string? Clave { get; set; }

        public required string? Correo { get; set; }

        //protected BaseEntity()
        //{
        //    this.FechaCreacion = DateTime.Now;
        //} 
    }
}
