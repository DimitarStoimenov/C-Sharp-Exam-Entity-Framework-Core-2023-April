﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class BoardgameSeller
    {
        [ForeignKey(nameof(Boardgame))]
        public int BoardgameId { get; set; }
        public Boardgame Boardgame { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }

//     BoardgameId – integer, Primary Key, foreign key(required)
// Boardgame – Boardgame
// SellerId – integer, Primary Key, foreign key(required)
// Seller – Seller
}
