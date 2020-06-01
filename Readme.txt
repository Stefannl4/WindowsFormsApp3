
Tabellen of bestanden maken
1, Connection class en zelf bouwen
2. Entity Framework 6
3. Entity Framework Core (is de laatste)


>Menu Tools
>Nu het package manager
>Package manager console
Op het prompt kun je commando's intoetsen. Het volgende commanda laad het Entity Framework in je applciatie.
PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite


In plaats hiervan kun je ook een inmemory optie of de sqlserver gebruiken:
PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer
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

En vervolgens bij elke update van de tabellen
PM> Add-Migration  InitialCreate -Context  CasinoContext
PM> Update-Database -c CasinoContext