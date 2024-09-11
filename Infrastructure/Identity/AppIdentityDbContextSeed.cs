using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Lee",
                    Email = "lee@gmail.com",
                    UserName = "lee@gmail.com",
                    Address = new Address 
                    {
                        FirstName = "Lee",
                        LastName = "C",
                        Street = "2 Rundle St",
                        City = "Adelaide",
                        State = "SA",
                        Postcode = "5000",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}