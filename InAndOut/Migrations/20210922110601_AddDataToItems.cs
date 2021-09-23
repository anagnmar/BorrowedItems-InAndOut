using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class AddDataToItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Items SET Borrower = 'Denis'WHERE Id = 5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
