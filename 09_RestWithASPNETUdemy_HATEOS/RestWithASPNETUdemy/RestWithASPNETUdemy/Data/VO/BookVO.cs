using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    public class BookVO
    {
        public long id { get; set; }
        public string NameBook { get; set; }

        public string Genre { get; set; }
        public string Publisher { get; set; }
    }
}
