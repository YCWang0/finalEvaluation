using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YCW.ClientInfoSystem.Infa.Migrations
{
    public partial class initional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(nullable: false),
                    EmpId = table.Column<int>(nullable: false),
                    IntType = table.Column<string>(maxLength: 1, nullable: false),
                    IntDate = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Phones = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    InteractionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Interactions_InteractionsId",
                        column: x => x.InteractionsId,
                        principalTable: "Interactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    Designation = table.Column<string>(maxLength: 50, nullable: false),
                    InteractionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Interactions_InteractionsId",
                        column: x => x.InteractionsId,
                        principalTable: "Interactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_InteractionsId",
                table: "Clients",
                column: "InteractionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InteractionsId",
                table: "Employees",
                column: "InteractionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Interactions");
        }
    }
}
