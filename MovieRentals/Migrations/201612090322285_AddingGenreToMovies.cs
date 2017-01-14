namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 3 WHERE Name = 'Toy Story'");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Name = 'Hangover' ");
            Sql("UPDATE Movies SET GenreId = 2 WHERE Name = 'Inception' ");
        }
        
        public override void Down()
        {
        }
    }
}
