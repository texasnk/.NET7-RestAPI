using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("book")]
    public class Book
    {
        [Column("id")]
        public long id { get; set; }
        [Column("book_name")]
        public string NameBook { get; set; }
        [Column("genre")]
        public string Genre { get; set; }
        [Column("publisher")]
        public string Publisher { get; set; }
    }
}
