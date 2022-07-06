using Microsoft.EntityFrameworkCore;
namespace simpleAPI.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SimpleContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<SimpleContext>>()))
        {
            // Look for any movies.
            if (context.TableName.Any()) { return; }
            context.TableName.AddRange(
            new Models.Simple
            {
                Name = "When Harry Met Sally",
            },
            new Models.Simple
            {
                Name = "Name Two",
            },
            new Models.Simple
            {
                Name = "Nicholas",
            }
            ,
            new Models.Simple
            {
                Name = "Gabriel",
            }
            ,
            new Models.Simple
            {
                Name = "Eyahya",
            }
            ,
            new Models.Simple
            {
                Name = "Qaisar",
            }
            // and more
            );
            context.SaveChanges();
        }
    }
}