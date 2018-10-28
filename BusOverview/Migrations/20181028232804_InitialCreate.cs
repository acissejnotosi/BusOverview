using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusOverview.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetecaoTipo",
                columns: table => new
                {
                    DetecaoTipoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetecaoTipo", x => x.DetecaoTipoId);
                });

            migrationBuilder.CreateTable(
                name: "Linha",
                columns: table => new
                {
                    LinhaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeLinha = table.Column<string>(nullable: true),
                    NumParadas = table.Column<int>(nullable: false),
                    NumBuracos = table.Column<int>(nullable: false),
                    NumLomnbadas = table.Column<int>(nullable: false),
                    NumSemnaforo = table.Column<int>(nullable: false),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linha", x => x.LinhaId);
                });

            migrationBuilder.CreateTable(
                name: "LinhasDetalhe",
                columns: table => new
                {
                    LinhaDetalheId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LinhaId = table.Column<int>(nullable: false),
                    DateHora = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhasDetalhe", x => x.LinhaDetalheId);
                });

            migrationBuilder.CreateTable(
                name: "OcorrenciaTipo",
                columns: table => new
                {
                    OcorrenciaTipoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcorrenciaTipo", x => x.OcorrenciaTipoId);
                });

            migrationBuilder.CreateTable(
                name: "SeveridadeTipo",
                columns: table => new
                {
                    SeveridadeTipoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeveridadeTipo", x => x.SeveridadeTipoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetecaoTipo");

            migrationBuilder.DropTable(
                name: "Linha");

            migrationBuilder.DropTable(
                name: "LinhasDetalhe");

            migrationBuilder.DropTable(
                name: "OcorrenciaTipo");

            migrationBuilder.DropTable(
                name: "SeveridadeTipo");
        }
    }
}
