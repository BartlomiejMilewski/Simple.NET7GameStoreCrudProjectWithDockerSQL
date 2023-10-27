using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPIv3NET7.Api.Dtos;

namespace GameStoreAPIv3NET7.Entities
{
    public static class EntityExtensions
    {
        public static GameDto AsDto(this Game game)
        {
            return new GameDto(
                game.Id,
                game.Name,
                game.Genre,
                game.Price,
                game.ReleaseDate,
                game.ImageUri
            );
        }
    }
}