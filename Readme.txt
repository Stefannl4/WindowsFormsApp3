---------------------------------------------------------------------------
- SQL software laden
---------------------------------------------------------------------------
Tabellen of bestanden maken
1, Connection class en zelf bouwen
2. Entity Framework 6
3. Entity Framework Core (is de laatste)


>Menu Tools
>Nu het package manager
>Package manager console
Op het prompt kun je commando's intoetsen. Het volgende commanda laad het Entity Framework in je applciatie.
PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer


In plaats hiervan kun je ook een inmemory optie of de sqlserver gebruiken:
PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite
PM> Install-Package Microsoft.EntityFrameworkCore.Inmemory

---------------------------------------------------------------------------
- creeren van een model
---------------------------------------------------------------------------
Een model is een class dat een object (klant, order e.d.) beschrijft. Al deze gegevens wil je opslaan.
Entity Framework core vereist dat je deze objecten in een Context class zet zodat het weet wat het moet doen.
Er zijn minimaal 2 vereisten:
- een context (deze bevat de tabellen en de naam van de database)
- de tabellen die je wilt opslaan (minimaal 1)

Nadat je dit gemaakt hebt moet je de tabellen maken 


---------------------------------------------------------------------------
- creeren van een database         SQLite
---------------------------------------------------------------------------
Initieel de software laden
>Menu Tools
>Nu het package manager
>Package manager console
PM> Install-Package Microsoft.EntityFrameworkCore.Tools

---------------------------------------------------------------------------
- Database voorzien van de laatste tabellen
---------------------------------------------------------------------------

En vervolgens bij elke update van de tabellen
>Menu Tools
>Nu het package manager
>Package manager console
PM> Add-Migration  InitialCreate -Context  MyContext
PM> Update-Database -c MyContext

---------------------------------------------------------------------------
-- Modelling
---------------------------------------------------------------------------
https://docs.microsoft.com/en-us/ef/core/modeling/
Definieer je eigen object (lees tabellen)

Relaties tussen tabellen (1:1, 1:N, N:M)
https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

Statusveld conversie, of ook enum conversie
https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions

---------------------------------------------------------------------------
-- Database connectie maken
---------------------------------------------------------------------------

  public class MyContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=WindowsFormsApp3;trusted_connection=true;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasIndex(b => b.Url)
                .IsUnique();
        }

    }

