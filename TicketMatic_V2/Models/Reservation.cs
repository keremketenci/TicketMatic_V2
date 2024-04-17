using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TicketMatic_V2.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public string seatNo { get; set; }

        // Relationships
        public int sessionId { get; set; }
        public int userId { get; set; }
    }
}
