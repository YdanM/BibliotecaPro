

using BibliotecaPro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaPro.Lector.Domain.Entities
{
    public class Lector : AuditiEntity<int>
    {
        [Column("IdLector")]
        public override int Id { get; set; }
    }
}
