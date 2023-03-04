using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;


namespace RestWithASPNETUdemy.Data.VO
{
    public class BookVO : ISupportsHypermedia
    {
        public long id { get; set; }
        public string NameBook { get; set; }

        public string Genre { get; set; }
        public string Publisher { get; set; }

        public List<HypermediaLink> Links { get; set; } = new List<HypermediaLink>();
    }
}
