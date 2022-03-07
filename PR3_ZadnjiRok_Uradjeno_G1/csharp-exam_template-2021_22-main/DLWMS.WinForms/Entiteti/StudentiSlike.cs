using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiSlike")]
    public class StudentiSlike
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
    }
}
