using Microsoft.Extensions.Localization;

namespace WebApplication1.Pages
{
    public class Event
    {
        public string Título { get; set; }
        public DateTime Data { get; set; }
        public String Local { get; set; }


        public Event() { }


        public Event(string título, DateTime data, string local)
        {
            Título = título;
            Data = data;
            Local = local;
        }
    }
}
