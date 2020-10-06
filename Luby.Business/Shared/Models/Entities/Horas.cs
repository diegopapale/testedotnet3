using System;
using System.Collections.Generic;
using System.Text;

namespace Luby.Business.Shared.Models.Entities
{
    public class Horas
    {
        public int Id { get; set; }
        public int IdProgramador { get; set; }
        public decimal Qtde { get; set; }
        public DateTime Data { get; set; }
    }
}
