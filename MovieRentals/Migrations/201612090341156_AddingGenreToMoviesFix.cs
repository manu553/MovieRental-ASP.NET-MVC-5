namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreToMoviesFix : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreType_Id = 3 WHERE Name = 'Toy Story'");
            Sql("UPDATE Movies SET GenreType_Id = 1 WHERE Name = 'Hangover' ");
            Sql("UPDATE Movies SET GenreType_Id = 2 WHERE Name = 'Inception' ");
        }

        public override void Down()
        {
        }
    }
}
