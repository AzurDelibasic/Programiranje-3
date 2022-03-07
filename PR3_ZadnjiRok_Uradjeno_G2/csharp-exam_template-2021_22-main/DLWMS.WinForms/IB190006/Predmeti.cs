using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB190006
{
    [Table("Predmeti")]
    public class Predmeti
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual List<PredmetiSeminarski> SlikeSeminarskih { get; set; } = new List<PredmetiSeminarski>();

        public override string ToString()
        {
            return Naziv;
        }
    }

}
