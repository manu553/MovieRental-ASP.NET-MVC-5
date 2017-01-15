namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreTypeFix : DbMigration
    {
        public override void Up()
        {
            DropTable("Movies");

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
            DropForeignKey("dbo.Movies", "GenreType_Id1", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreType_Id1" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "GenreType_Id1");
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
