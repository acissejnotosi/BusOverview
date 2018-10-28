using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusOverview.Model
{
    public class LinhaDetalhe
    {
        [Key]
        public int LinhaDetalheId { get; set; }
        public int LinhaId { get; set; }
        public DateTime DateHora { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
