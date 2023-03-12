using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestWithASPNETUdemy.Hypermedia.Filters
{
    public class HypermediaFilter : ResultFilterAttribute
    {
        private readonly HypermediaFilterOptions _hypermediaFilterOptions;

        public HypermediaFilter(HypermediaFilterOptions hypermediaFilterOptions)
        {
            _hypermediaFilterOptions= hypermediaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult objectResult)
            {
                var Enricher = _hypermediaFilterOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(x => x.CanEnrich(context));

                if (Enricher != null) Task.FromResult(Enricher.Enrich(context));
            }
        }
    }
}
