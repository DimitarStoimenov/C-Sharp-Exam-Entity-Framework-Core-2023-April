using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Boardgames.Data.Models
{
    public class Seller
    {
        public Seller()
        {
            this.BoardgamesSellers = new HashSet<BoardgameSeller>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Address { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Website { get; set; }
        public ICollection<BoardgameSeller> BoardgamesSellers { get; set; }
    }

//     Id – integer, Primary Key
// Name – text with length[5…20] (required)
// Address – text with length[2…30] (required)
// Country – text(required)
// Website – a string (required). First four characters are "www.", followed by upper and / lower/ letters, digits or '-' and the last three characters are ".com".
// BoardgamesSellers – collection of type BoardgameSeller
}
