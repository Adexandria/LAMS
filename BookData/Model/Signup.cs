using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public class Signup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
       public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Password1 { get; set; }

    }
}
