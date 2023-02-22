using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO
    {
        public long id { get; set; }
     
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        [JsonIgnore]
        public string Address { get; set; }
      
        public string Gender { get; set; }

    }
}
