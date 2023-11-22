using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class ProfConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_JiraType_JiraTypeId",
                table: "MappingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_TFSType_TFSTypeId",
                table: "MappingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_mMappingFields_JiraFields_JiraFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropForeignKey(
                name: "FK_mMappingFields_Profiles_MappingFieldProfile",
                table: "mMappingFields");

            migrationBuilder.DropForeignKey(
                name: "FK_mMappingFields_TFSFields_TFSFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFSType",
                table: "TFSType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mMappingFields",
                table: "mMappingFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JiraType",
                table: "JiraType");

            migrationBuilder.RenameTable(
                name: "TFSType",
                newName: "TFSTypes");

            migrationBuilder.RenameTable(
                name: "mMappingFields",
                newName: "MappingFields");

            migrationBuilder.RenameTable(
                name: "JiraType",
                newName: "JiraTypes");

            migrationBuilder.RenameIndex(
                name: "IX_mMappingFields_TFSFieldsId",
                table: "MappingFields",
                newName: "IX_MappingFields_TFSFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_mMappingFields_MappingFieldProfile",
                table: "MappingFields",
                newName: "IX_MappingFields_MappingFieldProfile");

            migrationBuilder.RenameIndex(
                name: "IX_mMappingFields_JiraFieldsId",
                table: "MappingFields",
                newName: "IX_MappingFields_JiraFieldsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFSTypes",
                table: "TFSTypes",
                column: "TFSTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingFields",
                table: "MappingFields",
                column: "MappingFieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JiraTypes",
                table: "JiraTypes",
                column: "JiraTypeId");

            migrationBuilder.CreateTable(
                name: "ProfileConfig",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MappingFieldProfile = table.Column<int>(type: "int", nullable: false),
                    JiraURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APIToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TFSUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Collection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TFSProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TFSCustom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileConfig", x => x.ConfigId);
                    table.ForeignKey(
                        name: "FK_ProfileConfig_Profiles_MappingFieldProfile",
                        column: x => x.MappingFieldProfile,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileConfig_MappingFieldProfile",
                table: "ProfileConfig",
                column: "MappingFieldProfile");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingFields_JiraFields_JiraFieldsId",
                table: "MappingFields",
                column: "JiraFieldsId",
                principalTable: "JiraFields",
                principalColumn: "JiraFieldsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingFields_Profiles_MappingFieldProfile",
                table: "MappingFields",
                column: "MappingFieldProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingFields_TFSFields_TFSFieldsId",
                table: "MappingFields",
                column: "TFSFieldsId",
                principalTable: "TFSFields",
                principalColumn: "TFSFieldsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_JiraTypes_JiraTypeId",
                table: "MappingTypes",
                column: "JiraTypeId",
                principalTable: "JiraTypes",
                principalColumn: "JiraTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_TFSTypes_TFSTypeId",
                table: "MappingTypes",
                column: "TFSTypeId",
                principalTable: "TFSTypes",
                principalColumn: "TFSTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingFields_JiraFields_JiraFieldsId",
                table: "MappingFields");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingFields_Profiles_MappingFieldProfile",
                table: "MappingFields");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingFields_TFSFields_TFSFieldsId",
                table: "MappingFields");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_JiraTypes_JiraTypeId",
                table: "MappingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_TFSTypes_TFSTypeId",
                table: "MappingTypes");

            migrationBuilder.DropTable(
                name: "ProfileConfig");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFSTypes",
                table: "TFSTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingFields",
                table: "MappingFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JiraTypes",
                table: "JiraTypes");

            migrationBuilder.RenameTable(
                name: "TFSTypes",
                newName: "TFSType");

            migrationBuilder.RenameTable(
                name: "MappingFields",
                newName: "mMappingFields");

            migrationBuilder.RenameTable(
                name: "JiraTypes",
                newName: "JiraType");

            migrationBuilder.RenameIndex(
                name: "IX_MappingFields_TFSFieldsId",
                table: "mMappingFields",
                newName: "IX_mMappingFields_TFSFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingFields_MappingFieldProfile",
                table: "mMappingFields",
                newName: "IX_mMappingFields_MappingFieldProfile");

            migrationBuilder.RenameIndex(
                name: "IX_MappingFields_JiraFieldsId",
                table: "mMappingFields",
                newName: "IX_mMappingFields_JiraFieldsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFSType",
                table: "TFSType",
                column: "TFSTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mMappingFields",
                table: "mMappingFields",
                column: "MappingFieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JiraType",
                table: "JiraType",
                column: "JiraTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_JiraType_JiraTypeId",
                table: "MappingTypes",
                column: "JiraTypeId",
                principalTable: "JiraType",
                principalColumn: "JiraTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_TFSType_TFSTypeId",
                table: "MappingTypes",
                column: "TFSTypeId",
                principalTable: "TFSType",
                principalColumn: "TFSTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mMappingFields_JiraFields_JiraFieldsId",
                table: "mMappingFields",
                column: "JiraFieldsId",
                principalTable: "JiraFields",
                principalColumn: "JiraFieldsId");

            migrationBuilder.AddForeignKey(
                name: "FK_mMappingFields_Profiles_MappingFieldProfile",
                table: "mMappingFields",
                column: "MappingFieldProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mMappingFields_TFSFields_TFSFieldsId",
                table: "mMappingFields",
                column: "TFSFieldsId",
                principalTable: "TFSFields",
                principalColumn: "TFSFieldsId");
        }
    }
}
