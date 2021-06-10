using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppcoreGit1.Models
{[Table("Palyer")]
    public class Player
    {
        [Key]
        public int PId { get; set; }
        public string Pname { get; set; }
        public string PTeam { get; set; }
    }
}
