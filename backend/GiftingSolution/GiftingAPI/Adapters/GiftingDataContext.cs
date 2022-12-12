using GiftingApi.Domain;
using Microsoft.EntityFrameworkCore;
namespace GiftingAPI.Adapters;

public class GiftingDataContext : DbContext
{
    public GiftingDataContext(DbContextOptions<GiftingDataContext> options): base(options)
    {

    }
    public DbSet<PersonEntity> People { get; set; } = null;

}
