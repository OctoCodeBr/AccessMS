using AccessMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessMS.Infrastructure.Database;

public class AccessDbContext: DbContext {

    public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options)
    {
    }

    public virtual DbSet<UserEntity> Users => Set<UserEntity>();
    public virtual DbSet<GymEntity> Gyms => Set<GymEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().HasData(
            new UserEntity {
                Id = 1,
                Name = "Guilherme",
                BirthDate = new DateTime(1998, 04, 20),
                CPF = "",
                Cellphone = "",
                Email = "",
                UserName = "guilherme_aguirres",
                Password = "1234"
            }
        );

    }

}