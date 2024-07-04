using BookExchangeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BookExchangeApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<FavouriteBooks> FavoriteBooks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreBook> GenresBooks { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupType> GroupTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreBook>().HasKey(p => new {p.BookId, p.GenreId});
            modelBuilder.Entity<GenreBook>().HasOne(p => p.Book).WithMany(p => p.GenreBooks).HasForeignKey(p => p.BookId);
            modelBuilder.Entity<GenreBook>().HasOne(p => p.Genre).WithMany(p => p.GenreBooks).HasForeignKey(p => p.GenreId);

            modelBuilder.Entity<UserGroup>().HasKey(p => new { p.GroupId, p.UserId });
            modelBuilder.Entity<UserGroup>().HasOne(p => p.Group).WithMany(p => p.UserGroups).HasForeignKey(p => p.GroupId);
            modelBuilder.Entity<UserGroup>().HasOne(p => p.User).WithMany(p => p.UserGroups).HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Account>().HasNoKey();
        }
    }
}
