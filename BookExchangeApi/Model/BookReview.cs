namespace BookExchangeApi.Model
{
    public class BookReview
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        
    }
}
