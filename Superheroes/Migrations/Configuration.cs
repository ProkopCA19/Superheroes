namespace Superheroes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Superheroes.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Superheroes.Models.ApplicationDbContext context)
        {

            context.Superhero.AddOrUpdate(x => x.ID,
                new Models.Superhero() { ID = 1, Name = "Superman", AlterEgo = "Clark Kent", PrimarySuperheroAbility = "Super strength", SecondarySuperheroAbility = "Laser vision", Catchphrase = "Its a bird, its a plane, its superman!" },
                new Models.Superhero() { ID = 2, Name = "Wonderwoman", AlterEgo = "Diana Prince", PrimarySuperheroAbility = "Super strength", SecondarySuperheroAbility = "Cool lassow", Catchphrase = "..." },
                new Models.Superhero() { ID = 3, Name = "Aquaman", AlterEgo = "Jason Mamoa", PrimarySuperheroAbility = "Breathing underwater", SecondarySuperheroAbility = "Talking to fish", Catchphrase = "..." },
                new Models.Superhero() { ID = 4, Name = "The flash", AlterEgo = "Barry Allen", PrimarySuperheroAbility = "Super speed", SecondarySuperheroAbility = "Controls molecular vibrations", Catchphrase = "..." });


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
