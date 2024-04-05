using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyectos.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actividadesde_Investigaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechadeInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fechafinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividadesde_Investigaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Investigadoress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Afiliacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigadoress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "proyecto_De_Investigación_Científicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechadeInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEstimadaFinalización = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyecto_De_Investigación_Científicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publicacioness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechapublicacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicacioness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecursosEspecializadoss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidadrequerida = table.Column<int>(type: "int", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechadeentrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursosEspecializadoss", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actividadesde_Investigaciones");

            migrationBuilder.DropTable(
                name: "Investigadoress");

            migrationBuilder.DropTable(
                name: "proyecto_De_Investigación_Científicas");

            migrationBuilder.DropTable(
                name: "publicacioness");

            migrationBuilder.DropTable(
                name: "RecursosEspecializadoss");
        }
    }
}
