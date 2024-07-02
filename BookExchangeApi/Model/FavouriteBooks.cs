namespace BookExchangeApi.Model
{
    public class FavouriteBooks
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
