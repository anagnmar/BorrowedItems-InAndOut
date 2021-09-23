using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class AddRawBorrowersToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Items (Borrower) Values ('Dennis'), ('Frank')"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
