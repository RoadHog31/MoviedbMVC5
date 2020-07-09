namespace MoviedbMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerPropertiesChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "FullName", c => c.String());
            DropColumn("dbo.Customers", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "name", c => c.String());
            DropColumn("dbo.Customers", "FullName");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}
