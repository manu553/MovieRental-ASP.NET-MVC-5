namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock) VALUES ('Toy Story', 'Wednesday, November 22, 1995', 'Thursday, December 8, 2016', 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock) VALUES ('Hangover', 'Friday, November 6, 2009', 'Thursday, December 8, 2016', 8)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock) VALUES ('Inception', 'Friday, July 16, 2010', 'Thursday, December 8, 2016', 2)");
        }

        public override void Down()
        {
        }
    }
}
