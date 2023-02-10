using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bricksmagic.Migrations
{
    public partial class brik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floor = table.Column<int>(type: "int", nullable: false),
                    facing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<float>(type: "real", nullable: false),
                    loanOffered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    overlooking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Additionalrooms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    furnishing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
