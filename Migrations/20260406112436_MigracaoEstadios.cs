using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CopaHAS.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoEstadios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ESTADIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTADIO", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ESTADIO",
                columns: new[] { "Id", "Capacidade", "Cidade", "Nome" },
                values: new object[,]
                {
                    { 1, 43713, "SP", "Allianz Park" },
                    { 2, 49267, "SP", "Neo Química Arena" },
                    { 3, 66795, "SP", "Morumbi" },
                    { 4, 78838, "RJ", "Maracanã" },
                    { 5, 44200, "MS", "Morenão" },
                    { 6, 32050, "RN", "Arena das Dunas" },
                    { 7, 27000, "DF", "Boca de Jacaré" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ESTADIO");
        }
    }
}
