using System.Collections.Generic;

namespace ITAD_29_11.Controllers
{
    public class PollViewModel
    {
        public string Question { get; set; }
        public IList<Vote> Votes { get; set; }
        public IList<string> Answers { get; set; }
    }
}