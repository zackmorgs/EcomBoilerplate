using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EcomServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; } 
    public DbSet<Order> Orders { get; set; }      
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Cart> Carts { get; set; }

    public static async Task SeedAdminUserAsync(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        // Ensure the Admin role exists
        const string adminRole = "Admin";
        if (!await roleManager.RoleExistsAsync(adminRole))
        {
            await roleManager.CreateAsync(new IdentityRole(adminRole));
        }

        // Check if the admin user already exists
        const string adminEmail = "admin@ecom.com";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            // Create the admin user
            var user = new User
            {
                UserName = adminEmail,
                Email = adminEmail,
                IsAdmin = true,
                EmailConfirmed = true,
                CreatedAt = DateTime.UtcNow
            };

            // Add the user with a secure password
            var result = await userManager.CreateAsync(user, "AdminPassword123!");

            // Assign the Admin role to the user
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, adminRole);
            }
        }
    }
}
