namespace vidly_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (1,'路人', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (2, '小客戶',30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (3, '老客戶',90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (4,'超級客戶' ,300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
