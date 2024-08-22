using Microsoft.EntityFrameworkCore;
using RedSocialDeGatos.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Veterinary> Veterinaries { get; set; }
    public DbSet<PetShop> PetShops { get; set; }
    public DbSet<Adoption> Adoptions { get; set; }
    public DbSet<LostCat> LostCats { get; set; }
}
