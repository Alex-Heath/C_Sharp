using Microsoft.EntityFrameworkCore;
namespace DeckOfCardsConsole.Data;


public class ApplicationDbContext: DbContext
{
    public DbSet<PlayingCard> PlayingCards { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=DeckOfCards;");
    }


}
