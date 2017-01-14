namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            /*
             * Business Model:
             * 
             * 1 = Pay as you go membership | no signup fee, no contract, no Discounts
             * 2 = Monthly membership       | $30 signup fee, 1 month contract, 10% discounts on rentals
             * 3 = Quarterly membership     | $90 signup fee, 3 month contract, 15% discounts on rentals
             * 4 = Annual membership        | $300 signup fee, 12 month contract, 20$ discounts on rentals
             */
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");

        }

        public override void Down()
        {
        }
    }
}
