using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly ElasticSearchService _elasticSearchService;

    public IndexModel(ElasticSearchService elasticSearchService)
    {
        _elasticSearchService = elasticSearchService;
    }

    public List<sozcusearch.Models.Article> Articles { get; set; } = new();

    public void OnGet(string query)
    {
        var client = _elasticSearchService.Client;

        
        var response = client.Search<sozcusearch.Models.Article>(s => s
            .Query(q => q
                .Match(m => m
                    .Field(f => f.Title)
                    .Query(query ?? string.Empty)
                )
            )
        );

        Articles = response.Documents.ToList();
    }
}
