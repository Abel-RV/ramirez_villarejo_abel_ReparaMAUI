using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ramirez_villarejo_abel_ReparaMAUI.Models
{
    public class Coche
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Propietario { get; set; }

        public bool Anterior2000 { get; set; }

        public string Motivo { get; set; }

        public DateTime FechaTaller { get; set; }

        public DateTime? FechaAlta { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
