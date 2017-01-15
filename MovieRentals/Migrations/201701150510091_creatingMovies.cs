namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatingMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Movies",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        DateAdded = c.String(),
                        Stock = c.Int(nullable: false),
                        GenreTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreTypeId, cascadeDelete: true)
                .Index(t => t.GenreTypeId);
        }
        
        public override void Down()
        {
        }
    }
}
