using CommentRating.Models;
using Microsoft.EntityFrameworkCore;

namespace CommentRating.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
    }
}
