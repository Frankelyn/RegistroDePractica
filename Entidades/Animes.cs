using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnimes.Entidades
{
    public class Animes
    {
        [Key]

        public int AnimeId { get; set; }
        public string nombre { get; set; }

        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}
