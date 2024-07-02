namespace BookExchangeApi.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public User User { get; set; }
    }
}
