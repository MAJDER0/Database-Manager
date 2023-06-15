using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Manager.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZWIERZETA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    typ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ZWIERZET__3213E83FA7C79269", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GADY",
                columns: table => new
                {
                    zwierze_id = table.Column<int>(type: "int", nullable: false),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GADY__149FF718233FD438", x => x.zwierze_id);
                    table.ForeignKey(
                        name: "FK__GADY__zwierze_id__31EC6D26",
                        column: x => x.zwierze_id,
                        principalTable: "ZWIERZETA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PLAZY",
                columns: table => new
                {
                    zwierze_id = table.Column<int>(type: "int", nullable: false),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PLAZY__149FF718169DD6E8", x => x.zwierze_id);
                    table.ForeignKey(
                        name: "FK__PLAZY__zwierze_i__2F10007B",
                        column: x => x.zwierze_id,
                        principalTable: "ZWIERZETA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PTAKI",
                columns: table => new
                {
                    zwierze_id = table.Column<int>(type: "int", nullable: false),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PTAKI__149FF718E4334C38", x => x.zwierze_id);
                    table.ForeignKey(
                        name: "FK__PTAKI__zwierze_i__2C3393D0",
                        column: x => x.zwierze_id,
                        principalTable: "ZWIERZETA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RYBY",
                columns: table => new
                {
                    zwierze_id = table.Column<int>(type: "int", nullable: false),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RYBY__149FF718D0AAB623", x => x.zwierze_id);
                    table.ForeignKey(
                        name: "FK__RYBY__zwierze_id__29572725",
                        column: x => x.zwierze_id,
                        principalTable: "ZWIERZETA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSAKI",
                columns: table => new
                {
                    zwierze_id = table.Column<int>(type: "int", nullable: false),
                    nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sposob_odzywiania = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SSAKI__149FF718900757F1", x => x.zwierze_id);
                    table.ForeignKey(
                        name: "FK__SSAKI__zwierze_i__267ABA7A",
                        column: x => x.zwierze_id,
                        principalTable: "ZWIERZETA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GADY");

            migrationBuilder.DropTable(
                name: "PLAZY");

            migrationBuilder.DropTable(
                name: "PTAKI");

            migrationBuilder.DropTable(
                name: "RYBY");

            migrationBuilder.DropTable(
                name: "SSAKI");

            migrationBuilder.DropTable(
                name: "ZWIERZETA");
        }
    }
}
