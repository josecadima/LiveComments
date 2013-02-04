using System;
using System.Linq;
using System.Web.Http;
using KnockoutDemo.Data;
using KnockoutDemo.Data.DTOs;

namespace KnokoutDemo.WebApi.Controllers
{
    public class GameCommentsController : ApiController
    {
        public GameScoreDTO GetGameScore(Guid id)
        {
            using (var context = new EntityContext())
            {
                var result = from trans in context.GameTransmitions
                             where trans.Id == id
                             select trans;

                return new GameScoreDTO()
                {
                    TeamName1 = "AssureSoft",
                    TeamScore1 = 8,
                    TeamName2 = "TEKHNE",
                    TeamScore2 = 7,
                    Date = DateTime.Now,
                    Status = "EN VIVO" //EN VIVO / FINALIZADO / EMPTY
                };
            }
        }

        [HttpPost]
        public Object SetGameComment([FromBody]GameCommentDTO comment)
        {
            if (comment != null)
                return new { Message = comment.Comment };

            return new { Message = "Comment parameter is null" };
        }
    }
}
