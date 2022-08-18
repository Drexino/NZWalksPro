using Microsoft.EntityFrameworkCore;
using NZWalksPro.Models.Domains;

namespace NZWalksPro.Data
{
    public class NZWalksDBContext:DbContext
    {
        public NZWalksDBContext(DbContextOptions <NZWalksDBContext> options) : base(options)
        {

        }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulty { get; set; }
    }
}
