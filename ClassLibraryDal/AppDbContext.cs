using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=TaskManagementApp;User Id=sa;Password=P@ssword;Encrypt=False;TrustServerCertificate=True");

        return new AppDbContext(optionsBuilder.Options);
    }
}
