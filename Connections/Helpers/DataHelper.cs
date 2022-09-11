using Connections.Data;
using Microsoft.EntityFrameworkCore;

namespace Connections.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider serviceProvider)
        {
            var dbContextServiceProvider = serviceProvider.GetRequiredService<ApplicationDbContext>();


            await dbContextServiceProvider.Database.MigrateAsync();
        }
    }
}
