using Boardgames.Data.Models;
using Boardgames.DataProcessor.ImportDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
    [XmlType("Creator")]
    public class ExportCreatorsDto
    {
        [XmlAttribute("BoardgamesCount")]
        public int BoardgamesCount { get; set; }
        [XmlElement("CreatorName")]
        public string CreatorName { get; set; }

        [XmlArray("Boardgames")]
        public BoardgameDto[] Boardgames { get; set; }
    }
    [XmlType("Boardgame")]
    public class BoardgameDto
    {
        [XmlElement("BoardgameName")]
        public string BoardgameName { get; set; }

        [XmlElement("BoardgameYearPublished")]
        public int BoardgameYearPublished { get; set; }
    }

 //   <Creators>
 // <Creator BoardgamesCount = "6" >
 //   < CreatorName > Cade O'Neill</CreatorName>
 //   <Boardgames>
 //     <Boardgame>
 //       <BoardgameName>Bohnanza: The Duel</BoardgameName>
 //       <BoardgameYearPublished>2019</BoardgameYearPublished>
 //     </Boardgame>
 //     <Boardgame>
 //       <BoardgameName>Great Western Trail</BoardgameName>
 //       <BoardgameYearPublished>2018</BoardgameYearPublished>
 //     </Boardgame>
 //     <Boardgame>
 //       <BoardgameName>Indulgence</BoardgameName>
 //       <BoardgameYearPublished>2021</BoardgameYearPublished>
 //     </Boardgame>
 //     <Boardgame>
 //       <BoardgameName>Risk Europe</BoardgameName>
 //       <BoardgameYearPublished>2018</BoardgameYearPublished>
 //     </Boardgame>
 //     <Boardgame>
 //       <BoardgameName>The Grimm Forest</BoardgameName>
 //       <BoardgameYearPublished>2022</BoardgameYearPublished>
 //     </Boardgame>
 //     <Boardgame>
 //       <BoardgameName>Whitehall Mystery</BoardgameName>
 //       <BoardgameYearPublished>2023</BoardgameYearPublished>
 //     </Boardgame>
 //   </Boardgames>
 // </Creator>
}
