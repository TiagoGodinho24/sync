using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class Mappings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MappingField",
                columns: table => new
                {
                    MappingFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MappingFieldProfile = table.Column<int>(type: "int", nullable: false),
                    TFSField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JiraField = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingField", x => x.MappingFieldId);
                    table.ForeignKey(
                        name: "FK_MappingField_Profiles_MappingFieldProfile",
                        column: x => x.MappingFieldProfile,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingStatus",
                columns: table => new
                {
                    MappingStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MappingStatusProfile = table.Column<int>(type: "int", nullable: false),
                    TFSField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JiraField = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingStatus", x => x.MappingStatusId);
                    table.ForeignKey(
                        name: "FK_MappingStatus_Profiles_MappingStatusProfile",
                        column: x => x.MappingStatusProfile,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingType",
                columns: table => new
                {
                    MappingTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MappingTypeProfile = table.Column<int>(type: "int", nullable: false),
                    TFSField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JiraField = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingType", x => x.MappingTypeId);
                    table.ForeignKey(
                        name: "FK_MappingType_Profiles_MappingTypeProfile",
                        column: x => x.MappingTypeProfile,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MappingField_MappingFieldProfile",
                table: "MappingField",
                column: "MappingFieldProfile");

            migrationBuilder.CreateIndex(
                name: "IX_MappingStatus_MappingStatusProfile",
                table: "MappingStatus",
                column: "MappingStatusProfile");

            migrationBuilder.CreateIndex(
                name: "IX_MappingType_MappingTypeProfile",
                table: "MappingType",
                column: "MappingTypeProfile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MappingField");

            migrationBuilder.DropTable(
                name: "MappingStatus");

            migrationBuilder.DropTable(
                name: "MappingType");
        }
    }
}
