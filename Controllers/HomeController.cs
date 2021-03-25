using ElasticsearchNoCShar.app.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace ElasticsearchNoCShar.app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ElasticClient _client;

        public HomeController(ElasticClient client)
        {
            _client = client;
        }

        public IActionResult Index(string query)
        {
            ISearchResponse<Livro> results;
            if (!string.IsNullOrWhiteSpace(query))
            {
                results = _client.Search<Livro>(s => s
                            .Query(q => q
                                .Match(t => t
                                    .Field(f => f.Titulo)
                                    .Query(query)
                                )
                            )
                        );
            }
            else
            {
                results = _client.Search<Livro>(s => s
                    .Query(q => q
                        .MatchAll()
                    )
                );
            }

            return View(results);
        }
    }
}
