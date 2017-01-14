namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Type) VALUES('Comedy')");
            Sql("INSERT INTO Genres(Type) VALUES('Action')");
            Sql("INSERT INTO Genres(Type) VALUES('Family')");
            Sql("INSERT INTO Genres(Type) VALUES('Romance')");

        }
        
        public override void Down()
        {
        }
    }
}
