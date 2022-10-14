using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class skyapporderTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    BrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    ColorOrInch = table.Column<string>(type: "TEXT", nullable: false),
                    PackageType = table.Column<string>(type: "TEXT", nullable: false),
                    WashType = table.Column<string>(type: "TEXT", nullable: false),
                    ProductDate = table.Column<string>(type: "TEXT", nullable: false),
                    Deadline = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true),
                    s28 = table.Column<int>(type: "INTEGER", nullable: false),
                    s30 = table.Column<int>(type: "INTEGER", nullable: false),
                    s32 = table.Column<int>(type: "INTEGER", nullable: false),
                    s34 = table.Column<int>(type: "INTEGER", nullable: false),
                    s36 = table.Column<int>(type: "INTEGER", nullable: false),
                    s38 = table.Column<int>(type: "INTEGER", nullable: false),
                    s40 = table.Column<int>(type: "INTEGER", nullable: false),
                    s42 = table.Column<int>(type: "INTEGER", nullable: false),
                    s44 = table.Column<int>(type: "INTEGER", nullable: false),
                    s46 = table.Column<int>(type: "INTEGER", nullable: false),
                    s48 = table.Column<int>(type: "INTEGER", nullable: false),
                    s50 = table.Column<int>(type: "INTEGER", nullable: false),
                    sCount = table.Column<int>(type: "INTEGER", nullable: true),
                    k28 = table.Column<int>(type: "INTEGER", nullable: false),
                    k30 = table.Column<int>(type: "INTEGER", nullable: false),
                    k32 = table.Column<int>(type: "INTEGER", nullable: false),
                    k34 = table.Column<int>(type: "INTEGER", nullable: false),
                    k36 = table.Column<int>(type: "INTEGER", nullable: false),
                    k38 = table.Column<int>(type: "INTEGER", nullable: false),
                    k40 = table.Column<int>(type: "INTEGER", nullable: false),
                    k42 = table.Column<int>(type: "INTEGER", nullable: false),
                    k44 = table.Column<int>(type: "INTEGER", nullable: false),
                    k46 = table.Column<int>(type: "INTEGER", nullable: false),
                    k48 = table.Column<int>(type: "INTEGER", nullable: false),
                    k50 = table.Column<int>(type: "INTEGER", nullable: false),
                    kCount = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
