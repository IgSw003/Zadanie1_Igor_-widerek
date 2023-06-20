using AdvancedProgramming_Lesson1.Models;
using AdvancedProgramming_Lesson1.Models.bookshelf;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<book> Books { get; set; }

        public DbSet<Author> Autors { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
