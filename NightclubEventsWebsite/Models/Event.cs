using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NightclubEventsWebsite.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string EventTitle { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ClubName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string DJName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
    }
}
