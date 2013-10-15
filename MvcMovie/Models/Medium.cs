using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public abstract class Medium
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        /*
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOut { get; set; }
         */

        // set nullable so not required (default to 0) 
        public int? SciFiVotes { get; set;  }
        public int? FantasyVotes { get; set; }

    }

    /* need this for abstract class?
    public class MediumDBContext : DbContext
    {
        public DbSet<Medium> Media { get; set; }
    }
     */
}