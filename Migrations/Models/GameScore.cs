using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Migrations.Models
{
    public class GameScore
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

    }
}