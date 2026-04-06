using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ramirez_villarejo_abel_ReparaMAUI.Models
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("IDCLIENTE")]
        public int idCliente { get; set; }

        [Column("MOVIL")]
        public string movil { get; set; }

        [Column("NOMBRE_Y_APELLIDOS")]
        public string nombreYApellidos { get; set; }

        public List<Coche> Vehiculos { get; set; } = new List<Coche>();
    }
}
