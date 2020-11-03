using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YourPetPortfolio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(maxLength: 30, nullable: true),
                    AnimalAge = table.Column<int>(nullable: true),
                    AnimalGender = table.Column<string>(maxLength: 6, nullable: true),
                    AnimalBreed = table.Column<string>(maxLength: 20, nullable: true),
                    AnimalTemporment = table.Column<string>(nullable: true),
                    AnimalDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Animals__A21A7307B78DEB17", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<string>(maxLength: 30, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AnimalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Voluntee__716F6F2C7FB85DFC", x => x.VolunteerId);
                    table.ForeignKey(
                        name: "FK__Volunteer__Anima__45F365D3",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<string>(maxLength: 30, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VolunteerId = table.Column<int>(nullable: true),
                    AnimalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__7AD04F11A6431903", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK__Employees__Anima__49C3F6B7",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Employees__Volun__48CFD27E",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "VolunteerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AnimalId",
                table: "Employees",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_VolunteerId",
                table: "Employees",
                column: "VolunteerId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_AnimalId",
                table: "Volunteers",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
