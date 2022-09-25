using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryPattern.Migrations
{
    public partial class repoCihan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdıveİkinciAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personeller",
                columns: new[] { "Id", "AdıveİkinciAdı", "Eposta", "Soyadı", "Telefon" },
                values: new object[] { new Guid("d0d14eff-83a2-451b-8ebf-03a4faaa0309"), "Cihan", "Cihancik@gmail.com", "Güler", "05335187892" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
