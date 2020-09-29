using CoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CoreDemo.Data
{
    public class CoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory)
                .UseSqlServer(
              //  "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = CoreDemo"
              "Data Source=10.1.22.1;Initial Catalog=TESTDB;User ID=sa;Password=Sonluk2017;MultipleActiveResultSets =true"
                );
        }
       // 可在不修改实体类的情况下指定配置。 Fluent API 配置具有最高优先级，并将替代约定和数据注释。
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlayer>().HasKey(x => new { x.PlayerId, x.GameId });
            modelBuilder.Entity<Resume>()
                .HasOne(x => x.Player)
                .WithOne(x => x.Resume)
                .HasForeignKey<Resume>(x => x.PlayerId);
            modelBuilder.Entity<League>().Property(x => x.Country).IsRequired().HasMaxLength(50);
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Resume> Resumes { get; set; }

        



        public static readonly ILoggerFactory ConsoleLoggerFactory =
            LoggerFactory.Create(bulider =>
            {
                bulider.AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
            });



    }
}
