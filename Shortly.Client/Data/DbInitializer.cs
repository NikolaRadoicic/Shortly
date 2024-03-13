using Shortly.Data;
using Shortly.Data.Migrations;
using Shortly.Data.Models;

namespace Shortly.Client.Data
{
    public static class DbInitializer
    {
        public static void SeedDefaultData(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!dbContext.Users.Any()) 
                {
                    dbContext.Users.AddRange(new User()
                    {
                        FullName = "Nikola Radoicic",
                        Email = "nikola.radoicic@gmail.com"
                    });

                    dbContext.SaveChanges();

                
                if (!dbContext.Urls.Any())
                    {
                        dbContext.Urls.Add(new Url()
                        {
                            OriginalLink = "https://google.com",
                            ShortLink = "ggl",
                            NumberOfClicks = 29,
                            DateCreated = DateTime.Now,
                            UserId = dbContext.Users.First().Id
                        });

                        dbContext.SaveChanges();
                    }
                }
            }
        }
    }
}
