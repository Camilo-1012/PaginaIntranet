using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaginaIst.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreacionModelsEquipos : Migration
    {
        /// <inheritdoc />
        protected override void Up (MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    PLACA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_EMPLEADO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HOSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FECHA_INICIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FECHA_FIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_TIPOEQUIPO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MARCA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MODELO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SERIAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIT_PROVEEDOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GARANTIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIDA_UTIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FUENTE_Y_DEMAS_ACCESORIOS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPACIDAD_FUENTE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCESADOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLASE_DE_DISCO_No1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPACIDAD_DISCO_No1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLASE_DE_DISCO_No2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPACIDAD_DISCO_No2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEMORIA_RAM_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEMORIA_RAM_2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.PLACA);
                });
        }

        /// <inheritdoc />
        protected override void Down (MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipo");
        }
    }
}
