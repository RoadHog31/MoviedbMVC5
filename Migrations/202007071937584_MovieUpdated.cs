namespace MoviedbMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Title", c => c.String());
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "name", c => c.String());
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "Title");
        }
    }
}
