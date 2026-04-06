

namespace ramirez_villarejo_abel_ReparaMAUI.Models
{
    public class Coche
    {
        [Table("VEHICULO")]
        public class Coche
        {
            [Key]
            [Column("ID")]
            public int Id { get; set; }

            [Column("MATRICULA")]
            public string Matricula { get; set; }

            [NotMapped]
            public string Propietario { get; set; }

            [Column("ANTERIOR2000")]
            public bool Anterior2000 { get; set; }

            [Column("MOTIVO")]
            public string Motivo { get; set; }

            [Column("FECHATALLER")]
            public DateTime FechaTaller { get; set; }

            [Column("FECHAALTA")]
            public DateTime? FechaAlta { get; set; }

            [Column("IDCLIENTE")]
            public int IdCliente { get; set; }

            [ForeignKey("IdCliente")]
            public Cliente Cliente { get; set; }
        }
    }
}
