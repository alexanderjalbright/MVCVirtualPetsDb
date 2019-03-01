using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcVirtualPets.Migrations
{
    public partial class NoLAEPDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_ListAndEdits_ListAndEditPetsId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "ListAndEdits");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ListAndEditPetsId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "ListAndEditPetsId",
                table: "Pets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListAndEditPetsId",
                table: "Pets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ListAndEdits",
                columns: table => new
                {
                    ListAndEditPetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListAndEdits", x => x.ListAndEditPetsId);
                });

            migrationBuilder.InsertData(
                table: "ListAndEdits",
                column: "ListAndEditPetsId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "ListAndEditPetsId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "ListAndEditPetsId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "ListAndEditPetsId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ListAndEditPetsId",
                table: "Pets",
                column: "ListAndEditPetsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_ListAndEdits_ListAndEditPetsId",
                table: "Pets",
                column: "ListAndEditPetsId",
                principalTable: "ListAndEdits",
                principalColumn: "ListAndEditPetsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
