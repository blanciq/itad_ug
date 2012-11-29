using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ITAD_29_11.Controllers
{
    public class PollController : ApiController
    {
        private static readonly IList<Vote> Votes =
            new List<Vote>
                {
                    new Vote { Answer = "PG", Count = 0},
                    new Vote { Answer = "UG", Count = 0}
                };

        public PollViewModel Get()
        {
            return new PollViewModel
                       {
                           Question = "Która uczelnia jest NAJlepsza?",
                           Votes = Votes,
                           Answers = Votes.Select(x => x.Answer).ToList()
                       };
        }

        public IList<Vote> Post(Vote vote)
        {
            Votes.SingleOrDefault(x => x.Answer == vote.Answer).Count++;
            return Votes;
        } 
    }
}
