namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.DataProcessor.ExportDto;
    using Newtonsoft.Json;

    public class Serializer
    {
       public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
       {
           

            var prisonrsInbox = context.Creators
                .Where(x => x.Boardgames.Any())
                .ToArray()
                .Select(x => new ExportCreatorsDto
                {
                    BoardgamesCount = x.Boardgames.Count(),
                    CreatorName = $"{x.FirstName} {x.LastName}",
                    Boardgames = x.Boardgames.Select(x => new BoardgameDto
                    {
                        BoardgameName = x.Name,
                        BoardgameYearPublished = x.YearPublished
                    })
                    .ToArray()

                    
                    

                })
                .OrderByDescending(x => x.BoardgamesCount)
                .ThenBy(x => x.CreatorName)
                .ToList();

            var result = XmlConverter.Serialize(prisonrsInbox, "Creators");
            return result;
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellersDto = context.Sellers.
              Where(x => x.BoardgamesSellers.Any(x => x.Boardgame.YearPublished >= year && 
              x.Boardgame.Rating <= rating))
              .ToArray()
              .Select(x => new
              {
                 Name = x.Name,
                 Website = x.Website,


                 Boardgames = x.BoardgamesSellers
                 .Where(x => x.Boardgame.YearPublished >= year && x.Boardgame.Rating <= rating)
                 .Select(x => new
                  {
                      Name = x.Boardgame.Name,
                      Rating = x.Boardgame.Rating,
                      Mechanics= x.Boardgame.Mechanics,
                      Category = x.Boardgame.CategoryType.ToString() ,
                 })
                  .OrderByDescending(x => x.Rating)
                  .ThenBy(x => x.Name)
                  .ToList(),
                  

              })
              .OrderByDescending(x => x.Boardgames.Count())
              .ThenBy(x => x.Name)
              .Take(5)
              .ToList();

            var result = JsonConvert.SerializeObject(sellersDto, Formatting.Indented);
            return result;

        }
    }
}