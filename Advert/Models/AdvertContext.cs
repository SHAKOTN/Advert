using Microsoft.EntityFrameworkCore;

namespace Advert.Models
{
    public class AdvertContext : DbContext
    {
        public AdvertContext(DbContextOptions<AdvertContext> options) : base(options)
        {
        }
        public DbSet<TChannel> TChannels { get; set; }

    }
}
