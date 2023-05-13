using Boardgames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
	[XmlType("Creator")]
    public class ImportCreatorDto
    {
        [Required]
        [StringLength(7 , MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 2)]
        public string LastName { get; set; }

		[XmlArray("Boardgames")]

        public BoardgameDto[] Boardgames { get; set; }
    }
    [XmlType("Boardgame")]

    public class BoardgameDto
	{
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string Name { get; set; }

        [Range(1, 10.00)]
        public double Rating { get; set; }

        [Range(2018, 2023)]
        public int YearPublished { get; set; }

        [Required]
        [XmlElement("CategoryType")]
        [Range(0, 4)]
        public int CategoryType { get; set; }

        [Required]
        public string Mechanics { get; set; }
    }
    //Name – text with length[10…20] (required)
    //Rating – double in range[1…10.00] (required)
    //YearPublished – integer in range[2018…2023] (required)
    //CategoryType – enumeration of type CategoryType, with possible values(Abstract, Children, //Family, Party, Strategy) (required)
    //Mechanics – text(string, not an array) (required)
    //CreatorId – integer, foreign key(required)
    //Creator – Creator

    // FirstName – text with length[2, 7] (required) 
    // LastName – text with length[2, 7] (required)
    // Boardgames – collection of type Boardgame

    // <Creator>
    //	<FirstName>Debra</FirstName>
    //	<LastName>Edwards</LastName>
    //	<Boardgames>
    //		<Boardgame>
    //			<Name>4 Gods</Name>
    //			<Rating>7.28</Rating>
    //			<YearPublished>2017</YearPublished>
    //			<CategoryType>4</CategoryType>
    //			<Mechanics>Area Majority / Influence, Hand Management, Set Collection, Simultaneous Action Selection, Worker Placement</Mechanics>
    //		</Boardgame>
} //
