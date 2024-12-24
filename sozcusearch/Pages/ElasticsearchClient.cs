using Nest;

public class ElasticSearchService
{
    private readonly ElasticClient _client;

    public ElasticSearchService()
    {
        var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
            .DefaultIndex("sozcu-news");
        _client = new ElasticClient(settings);
    }

    public ElasticClient Client => _client;
}
