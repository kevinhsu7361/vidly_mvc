namespace vidly_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscribeAndBirthdayColumnToCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
