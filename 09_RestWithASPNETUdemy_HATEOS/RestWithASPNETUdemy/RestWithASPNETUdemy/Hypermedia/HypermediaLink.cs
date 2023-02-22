using System.Text;

namespace RestWithASPNETUdemy.Hypermedia
{
    public class HypermediaLink
    {
        public string Rel { get; set; }
        private string href;
        public string Href {
            get {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("2%F","/").ToString();
                }
            }
            set { href = value; } }
        public string Type { get; set; }
        public string TAction { get; set; }

    }
}
