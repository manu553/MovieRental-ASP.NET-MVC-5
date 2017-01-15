namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreType : DbMigration
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
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreTypeId");
            RenameColumn(table: "dbo.Movies", name: "GenreType_Id", newName: "GenreType_Id1");
            AddColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreType_Id1");
        }
    }
}
