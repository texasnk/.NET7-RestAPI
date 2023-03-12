using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Constants;
using System.Text;


namespace RestWithASPNETUdemy.Hypermedia.Enricher
{
    public class BookEnricher : ContentResponseEnricher<BookVO>
    {
        private readonly object _lock = new object();
        protected override Task EnrichModel(BookVO content, IUrlHelper urlHelper)
        {
            var path = "api/book";
            string link = GetLink(content.id, urlHelper, path);

            content.Links.Add(new HypermediaLink()
            {
                Action = HTTPActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new HypermediaLink()
            {
                Action = HTTPActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new HypermediaLink()
            {
                Action = HTTPActionVerb.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPut
            });
            content.Links.Add(new HypermediaLink()
            {
                Action = HTTPActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = "int"
            });
            return Task.CompletedTask;
        }

        private string GetLink(long id, IUrlHelper urlHelper, string path)
        {
            lock (_lock)
            {
                var url = new { controller = path, id = id };
                return new StringBuilder(urlHelper.Link("DefaultAPI", url)).Replace("%2F", "/").ToString();
            }
        }
    }
}
