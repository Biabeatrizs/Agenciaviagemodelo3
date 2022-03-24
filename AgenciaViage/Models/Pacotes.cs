using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViage.Models
{  
    [Table("Pacotes")]
    public class Pacotes
    {
       [Key]
       [Column("IdPacotes")]
       [Display(Name ="IdPacotes")]
       public int IdPacotes { get; set; }

       [Column("Origem")]
       [Display(Name = "Origem")]
       public string Origem { get; set; }


       [Column("Destino")]
       [Display(Name = "Destino")]
       public string Destino { get; set; }

       [Column("Preço")]
       [Display(Name = "Preço")]
       public double Preço { get; set; }

       [Column("DataIda")]
       [Display(Name = "Data (Ida)")]
       public DateTime DataIda { get; set; }


       [Column("DataVolta")]
       [Display(Name = "Data (Volta)")]
       public DateTime DataVolta { get; set; }

    }
}
