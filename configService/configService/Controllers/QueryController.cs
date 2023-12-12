using Microsoft.AspNetCore.Mvc;

namespace configService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueryController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Summary", "Detail", "Link"
    };

        private readonly ILogger<QueryController> _logger;

        public QueryController(ILogger<QueryController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Query")]
        public IEnumerable<Query> Get()
        {
            List<string> LstSummaryx = new List<string>();
            LstSummaryx.Add("Summary1..."); 
            LstSummaryx.Add("Summary2..."); 
            LstSummaryx.Add("Summary3...");

            List<string> LstDetailx = new List<string>();
            LstDetailx.Add("Detail1..."); 
            LstDetailx.Add("Detail2..."); 
            LstDetailx.Add("Detail3...");

            List<string> LstMorex = new List<string>();
            LstMorex.Add("More1..."); 
            LstMorex.Add("More2..."); 
            LstMorex.Add("More3...");

            return Enumerable.Range(1, 1).Select(index => new Query
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                MajorVersion = "1", 
                MinorVersion = "0", 
                LstSummary = LstSummaryx,
                LstDetail = LstDetailx,
                LstMore = LstMorex,
            })
            .ToArray();
        }
    }
}