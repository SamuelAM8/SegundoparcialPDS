using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyectos.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proyecto_De_Investigación_Científicas");

            migrationBuilder.AlterColumn<string>(
                name: "Proveedor",
                table: "RecursosEspecializadoss",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "RecursosEspecializadoss",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "publicacioness",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Autores",
                table: "publicacioness",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Investigadoress",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Investigadoress",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Afiliacion",
                table: "Investigadoress",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "actividadesde_Investigaciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "actividadesde_Investigaciones",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecursosEspecializadosId",
                table: "actividadesde_Investigaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "proyectoDeInvestigacionCientificas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechadeInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEstimadaFinalización = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvestigadoressId = table.Column<int>(type: "int", nullable: true),
                    actividadesde_InvestigacionesId = table.Column<int>(type: "int", nullable: true),
                    PublicacionessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyectoDeInvestigacionCientificas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proyectoDeInvestigacionCientificas_Investigadoress_InvestigadoressId",
                        column: x => x.InvestigadoressId,
                        principalTable: "Investigadoress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_proyectoDeInvestigacionCientificas_actividadesde_Investigaciones_actividadesde_InvestigacionesId",
                        column: x => x.actividadesde_InvestigacionesId,
                        principalTable: "actividadesde_Investigaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_proyectoDeInvestigacionCientificas_publicacioness_PublicacionessId",
                        column: x => x.PublicacionessId,
                        principalTable: "publicacioness",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_actividadesde_Investigaciones_RecursosEspecializadosId",
                table: "actividadesde_Investigaciones",
                column: "RecursosEspecializadosId");

            migrationBuilder.CreateIndex(
                name: "IX_proyectoDeInvestigacionCientificas_actividadesde_InvestigacionesId",
                table: "proyectoDeInvestigacionCientificas",
                column: "actividadesde_InvestigacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_proyectoDeInvestigacionCientificas_InvestigadoressId",
                table: "proyectoDeInvestigacionCientificas",
                column: "InvestigadoressId");

            migrationBuilder.CreateIndex(
                name: "IX_proyectoDeInvestigacionCientificas_PublicacionessId",
                table: "proyectoDeInvestigacionCientificas",
                column: "PublicacionessId");

            migrationBuilder.AddForeignKey(
                name: "FK_actividadesde_Investigaciones_RecursosEspecializadoss_RecursosEspecializadosId",
                table: "actividadesde_Investigaciones",
                column: "RecursosEspecializadosId",
                principalTable: "RecursosEspecializadoss",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividadesde_Investigaciones_RecursosEspecializadoss_RecursosEspecializadosId",
                table: "actividadesde_Investigaciones");

            migrationBuilder.DropTable(
                name: "proyectoDeInvestigacionCientificas");

            migrationBuilder.DropIndex(
                name: "IX_actividadesde_Investigaciones_RecursosEspecializadosId",
                table: "actividadesde_Investigaciones");

            migrationBuilder.DropColumn(
                name: "RecursosEspecializadosId",
                table: "actividadesde_Investigaciones");

            migrationBuilder.AlterColumn<string>(
                name: "Proveedor",
                table: "RecursosEspecializadoss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "RecursosEspecializadoss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "publicacioness",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Autores",
                table: "publicacioness",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Investigadoress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Investigadoress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Afiliacion",
                table: "Investigadoress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "actividadesde_Investigaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "actividadesde_Investigaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateTable(
                name: "proyecto_De_Investigación_Científicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEstimadaFinalización = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechadeInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyecto_De_Investigación_Científicas", x => x.Id);
                });
        }
    }
}
