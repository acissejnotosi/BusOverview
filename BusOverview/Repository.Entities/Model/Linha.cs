using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusOverview.Model
{
    public class Linha
    {
        [Key]
        public int LinhaId { get; set; }
        public string NomeLinha { get; set; }
        public int NumParadas { get; set; }
        public int NumBuracos { get; set; }
        public int NumLomnbadas { get; set; }
        public int NumSemnaforo { get; set; }
        public double Peso { get; set; }
    }
}
