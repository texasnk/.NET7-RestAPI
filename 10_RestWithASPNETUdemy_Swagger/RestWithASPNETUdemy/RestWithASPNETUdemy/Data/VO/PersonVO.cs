using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO : ISupportsHypermedia
    {
        public long id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        [JsonIgnore]
        public string Address { get; set; }

        public string Gender { get; set; }

        public List<HypermediaLink> Links { get; set; } = new List<HypermediaLink>();

    }
}