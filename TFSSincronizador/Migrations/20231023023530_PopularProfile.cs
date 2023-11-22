using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class PopularProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Profiles(ProfileName,Status) VALUES('VTXSD->TFS','Active')");
            migrationBuilder.Sql("INSERT INTO Profiles(ProfileName,Status) VALUES('VTXSAS->TFS','Active')");
            migrationBuilder.Sql("INSERT INTO Profiles(ProfileName,Status) VALUES('VTXCOM->TFS','Active')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Profiles");
        }
    }
}
