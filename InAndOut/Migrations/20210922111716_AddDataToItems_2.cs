using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class AddDataToItems_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Items SET ItemName = 'Bike', " +
                                "Lender= 'Frank' WHERE Borrower = 'Denis'");
            migrationBuilder.Sql("UPDATE Items SET ItemName = 'Darts', " +
                                "Lender= 'Denis'WHERE Borrower = 'Frank'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
