namespace MoviedbMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerMovieListAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Customer_Id");
            AddForeignKey("dbo.Movies", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Movies", new[] { "Customer_Id" });
            DropColumn("dbo.Movies", "Customer_Id");
        }
    }
}
