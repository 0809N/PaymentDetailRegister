using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentDetailRegister.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(16)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "varchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PMId);
                });

            migrationBuilder.InsertData(
                table: "PaymentDetails",
                columns: new[] { "PMId", "CVV", "CardNumber", "CardOwnerName", "ExpirationDate" },
                values: new object[] { 1, "321", "9876543210123456", "Vy Vo", "09/09" });

            migrationBuilder.InsertData(
                table: "PaymentDetails",
                columns: new[] { "PMId", "CVV", "CardNumber", "CardOwnerName", "ExpirationDate" },
                values: new object[] { 2, "333", "9876543210654321", "Michel Core", "08/08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
