using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVMSQLite.Models
{
    [AddINotifyPropertyChangedInterface]
    [Table("Persona")]
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int IdPersona { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("imc")]
        public double IMC { get; set; }

        [Column("peso")]
        public int Peso { get; set; }

        [Column("altura")]
        public int Altura { get; set; }
    }
}
