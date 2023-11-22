using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class Mappings1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingField_Profiles_MappingFieldProfile",
                table: "MappingField");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingStatus_Profiles_MappingStatusProfile",
                table: "MappingStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingType_Profiles_MappingTypeProfile",
                table: "MappingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingType",
                table: "MappingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingStatus",
                table: "MappingStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingField",
                table: "MappingField");

            migrationBuilder.DropColumn(
                name: "JiraField",
                table: "MappingType");

            migrationBuilder.DropColumn(
                name: "TFSField",
                table: "MappingType");

            migrationBuilder.DropColumn(
                name: "JiraField",
                table: "MappingStatus");

            migrationBuilder.DropColumn(
                name: "TFSField",
                table: "MappingStatus");

            migrationBuilder.DropColumn(
                name: "JiraField",
                table: "MappingField");

            migrationBuilder.DropColumn(
                name: "TFSField",
                table: "MappingField");

            migrationBuilder.RenameTable(
                name: "MappingType",
                newName: "MappingTypes");

            migrationBuilder.RenameTable(
                name: "MappingStatus",
                newName: "MappingStatuses");

            migrationBuilder.RenameTable(
                name: "MappingField",
                newName: "mMappingFields");

            migrationBuilder.RenameIndex(
                name: "IX_MappingType_MappingTypeProfile",
                table: "MappingTypes",
                newName: "IX_MappingTypes_MappingTypeProfile");

            migrationBuilder.RenameIndex(
                name: "IX_MappingStatus_MappingStatusProfile",
                table: "MappingStatuses",
                newName: "IX_MappingStatuses_MappingStatusProfile");

            migrationBuilder.RenameIndex(
                name: "IX_MappingField_MappingFieldProfile",
                table: "mMappingFields",
                newName: "IX_mMappingFields_MappingFieldProfile");

            migrationBuilder.AddColumn<int>(
                name: "JiraTypeId",
                table: "MappingTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TFSTypeId",
                table: "MappingTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JiraStatusId",
                table: "MappingStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TFSStatusId",
                table: "MappingStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JiraFieldId",
                table: "mMappingFields",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JiraFieldsId",
                table: "mMappingFields",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TFSFieldId",
                table: "mMappingFields",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TFSFieldsId",
                table: "mMappingFields",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingTypes",
                table: "MappingTypes",
                column: "MappingTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingStatuses",
                table: "MappingStatuses",
                column: "MappingStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mMappingFields",
                table: "mMappingFields",
                column: "MappingFieldId");

            migrationBuilder.CreateTable(
                name: "JiraFields",
                columns: table => new
                {
                    JiraFieldsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JiraFieldsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JiraFields", x => x.JiraFieldsId);
                });

            migrationBuilder.CreateTable(
                name: "JiraStatus",
                columns: table => new
                {
                    JiraStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JiraStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JiraStatus", x => x.JiraStatusId);
                });

            migrationBuilder.CreateTable(
                name: "JiraType",
                columns: table => new
                {
                    JiraTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JiraTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JiraType", x => x.JiraTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TFSFields",
                columns: table => new
                {
                    TFSFieldsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TFSFieldsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFSFields", x => x.TFSFieldsId);
                });

            migrationBuilder.CreateTable(
                name: "TFSStatus",
                columns: table => new
                {
                    TFSStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TFSStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFSStatus", x => x.TFSStatusId);
                });

            migrationBuilder.CreateTable(
                name: "TFSType",
                columns: table => new
                {
                    TFSTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TFSTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFSType", x => x.TFSTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MappingTypes_JiraTypeId",
                table: "MappingTypes",
                column: "JiraTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingTypes_TFSTypeId",
                table: "MappingTypes",
                column: "TFSTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingStatuses_JiraStatusId",
                table: "MappingStatuses",
                column: "JiraStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingStatuses_TFSStatusId",
                table: "MappingStatuses",
                column: "TFSStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_mMappingFields_JiraFieldsId",
                table: "mMappingFields",
                column: "JiraFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_mMappingFields_TFSFieldsId",
                table: "mMappingFields",
                column: "TFSFieldsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingStatuses_JiraStatus_JiraStatusId",
                table: "MappingStatuses",
                column: "JiraStatusId",
                principalTable: "JiraStatus",
                principalColumn: "JiraStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingStatuses_Profiles_MappingStatusProfile",
                table: "MappingStatuses",
                column: "MappingStatusProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingStatuses_TFSStatus_TFSStatusId",
                table: "MappingStatuses",
                column: "TFSStatusId",
                principalTable: "TFSStatus",
                principalColumn: "TFSStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_JiraType_JiraTypeId",
                table: "MappingTypes",
                column: "JiraTypeId",
                principalTable: "JiraType",
                principalColumn: "JiraTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingTypes_Profiles_MappingTypeProfile",
                table: "MappingTypes",
                column: "MappingTypeProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingStatuses_JiraStatus_JiraStatusId",
                table: "MappingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingStatuses_Profiles_MappingStatusProfile",
                table: "MappingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingStatuses_TFSStatus_TFSStatusId",
                table: "MappingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_JiraType_JiraTypeId",
                table: "MappingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingTypes_Profiles_MappingTypeProfile",
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

            migrationBuilder.DropTable(
                name: "JiraFields");

            migrationBuilder.DropTable(
                name: "JiraStatus");

            migrationBuilder.DropTable(
                name: "JiraType");

            migrationBuilder.DropTable(
                name: "TFSFields");

            migrationBuilder.DropTable(
                name: "TFSStatus");

            migrationBuilder.DropTable(
                name: "TFSType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mMappingFields",
                table: "mMappingFields");

            migrationBuilder.DropIndex(
                name: "IX_mMappingFields_JiraFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropIndex(
                name: "IX_mMappingFields_TFSFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingTypes",
                table: "MappingTypes");

            migrationBuilder.DropIndex(
                name: "IX_MappingTypes_JiraTypeId",
                table: "MappingTypes");

            migrationBuilder.DropIndex(
                name: "IX_MappingTypes_TFSTypeId",
                table: "MappingTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingStatuses",
                table: "MappingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_MappingStatuses_JiraStatusId",
                table: "MappingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_MappingStatuses_TFSStatusId",
                table: "MappingStatuses");

            migrationBuilder.DropColumn(
                name: "JiraFieldId",
                table: "mMappingFields");

            migrationBuilder.DropColumn(
                name: "JiraFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropColumn(
                name: "TFSFieldId",
                table: "mMappingFields");

            migrationBuilder.DropColumn(
                name: "TFSFieldsId",
                table: "mMappingFields");

            migrationBuilder.DropColumn(
                name: "JiraTypeId",
                table: "MappingTypes");

            migrationBuilder.DropColumn(
                name: "TFSTypeId",
                table: "MappingTypes");

            migrationBuilder.DropColumn(
                name: "JiraStatusId",
                table: "MappingStatuses");

            migrationBuilder.DropColumn(
                name: "TFSStatusId",
                table: "MappingStatuses");

            migrationBuilder.RenameTable(
                name: "mMappingFields",
                newName: "MappingField");

            migrationBuilder.RenameTable(
                name: "MappingTypes",
                newName: "MappingType");

            migrationBuilder.RenameTable(
                name: "MappingStatuses",
                newName: "MappingStatus");

            migrationBuilder.RenameIndex(
                name: "IX_mMappingFields_MappingFieldProfile",
                table: "MappingField",
                newName: "IX_MappingField_MappingFieldProfile");

            migrationBuilder.RenameIndex(
                name: "IX_MappingTypes_MappingTypeProfile",
                table: "MappingType",
                newName: "IX_MappingType_MappingTypeProfile");

            migrationBuilder.RenameIndex(
                name: "IX_MappingStatuses_MappingStatusProfile",
                table: "MappingStatus",
                newName: "IX_MappingStatus_MappingStatusProfile");

            migrationBuilder.AddColumn<string>(
                name: "JiraField",
                table: "MappingField",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TFSField",
                table: "MappingField",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JiraField",
                table: "MappingType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TFSField",
                table: "MappingType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JiraField",
                table: "MappingStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TFSField",
                table: "MappingStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingField",
                table: "MappingField",
                column: "MappingFieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingType",
                table: "MappingType",
                column: "MappingTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingStatus",
                table: "MappingStatus",
                column: "MappingStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingField_Profiles_MappingFieldProfile",
                table: "MappingField",
                column: "MappingFieldProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingStatus_Profiles_MappingStatusProfile",
                table: "MappingStatus",
                column: "MappingStatusProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingType_Profiles_MappingTypeProfile",
                table: "MappingType",
                column: "MappingTypeProfile",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
