namespace EventEase.Models
{
    public class EventItem
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
