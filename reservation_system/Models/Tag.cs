namespace reservation_system.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Provider Provider { get; set; }
    }
}