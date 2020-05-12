using Microsoft.EntityFrameworkCore.Migrations;

namespace AboneApp.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TCKimlikNo = table.Column<int>(nullable: false),
                    AdSoyad = table.Column<string>(nullable: true),
                    SozlesmeNo = table.Column<int>(nullable: false),
                    Adres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abones");
        }
    }
}
