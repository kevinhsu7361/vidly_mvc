namespace vidly_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (1,'���H', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (2, '�p�Ȥ�',30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (3, '�ѫȤ�',90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (4,'�W�ūȤ�' ,300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}