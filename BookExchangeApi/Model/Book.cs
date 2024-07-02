namespace BookExchangeApi.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string CoverPageImage { get; set; }
        public string Publisher { get; set; }
        public int Pages{ get; set; }
        public ICollection<BookReview> BookReviews { get; set; } = new List<BookReview>();
        public ICollection<FavouriteBooks> FavoriteBooks { get; set; } = new List<FavouriteBooks>();
        public ICollection<GenreBook> GenreBooks { get; set; } = new List<GenreBook>();
    }
}
