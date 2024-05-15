using Microsoft.EntityFrameworkCore;
using WebAPI02.Models.Domain;

namespace WebAPI02.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) :
base(dbContextOptions)
        {
            //constructor
        }
        //define C# model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // có the dinh nghia moi quan he giua cac table bang Fluent API
            modelBuilder.Entity<Book_Author>()
            .HasOne(b => b.Book)
            .WithMany(ba => ba.Book_Authors)
            .HasForeignKey(bi => bi.BookId);
            modelBuilder.Entity<Book_Author>()
            .HasOne(b => b.Author)
            .WithMany(ba => ba.Book_Authors)
            .HasForeignKey(bi => bi.AuthorId);
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
