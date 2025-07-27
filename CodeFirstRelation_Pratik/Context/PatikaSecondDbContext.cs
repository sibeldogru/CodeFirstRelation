using CodeFirstRelation_Pratik.Entities;
using Microsoft.EntityFrameworkCore; 
namespace CodeFirstRelation_Pratik.Context;

public class PatikaSecondDbContext : DbContext 
{
    public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
        .HasMany(u => u.Posts)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<PostEntity> Posts => Set<PostEntity>();    
}
