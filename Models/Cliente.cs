using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ramirez_villarejo_abel_ReparaMAUI.Models
{
    public class Cliente
    {
        [PrimaryKey]
        public int idCliente {  get; set; }
        public string movil {  get; set; }
        public string nombreYApellidos { get; set; }

        public List<Coche> Vehiculos { get; set; } = new List<Coche>();
    }
}
