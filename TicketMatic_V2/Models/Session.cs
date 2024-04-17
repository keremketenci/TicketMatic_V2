using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMatic_V2.Models
{
    public class Session
    {
        public int id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public bool subtitle { get; set; }

        // Relationships
        public int movieId { get; set; }
        public int theaterId { get; set; }
    }
}
