namespace MiMusica.Persistencia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MiMusica.Persistencia.MiMusicaContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MiMusica.Persistencia.MiMusicaContexto";
        }

        protected override void Seed(MiMusica.Persistencia.MiMusicaContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Usuarios.AddOrUpdate(
                new Usuario { 
                    Nombre = "Andres",
                    UserName = "andreshw",
                    Password = "12345",
                    NombreCiudad = "Medellin",
                    CorreoElecronico = "andres@andres.com"
                });

        }
    }
}
