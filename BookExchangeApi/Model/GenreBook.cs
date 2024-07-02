namespace BookExchangeApi.Model
{
    public class GenreBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId{ get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
