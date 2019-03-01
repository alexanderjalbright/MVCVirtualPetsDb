using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcVirtualPets.Migrations
{
    public partial class asdgfnrf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ListAndEditPetsId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_Pets_ListAndEdits_ListAndEditPetsId",
                        column: x => x.ListAndEditPetsId,
                        principalTable: "ListAndEdits",
                        principalColumn: "ListAndEditPetsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ListAndEdits",
                column: "ListAndEditPetsId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "ListAndEditPetsId", "Name" },
                values: new object[] { 1, "Big dog.", 1, "Roscoe" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "ListAndEditPetsId", "Name" },
                values: new object[] { 2, "Really big dog.", 1, "Biggs" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "ListAndEditPetsId", "Name" },
                values: new object[] { 3, "Tiny dog.", 1, "Bella" });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ListAndEditPetsId",
                table: "Pets",
                column: "ListAndEditPetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "ListAndEdits");
        }
    }
}
