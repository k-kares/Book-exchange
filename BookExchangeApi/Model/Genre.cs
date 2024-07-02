namespace BookExchangeApi.Model
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<GenreBook> GenreBooks { get; set; } = new List<GenreBook>();
    }
}
