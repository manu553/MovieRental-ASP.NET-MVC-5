namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropMovies : DbMigration
    {
        public override void Up()
        {
            DropTable("Movies");
        }
        
        public override void Down()
        {
        }
    }
}
