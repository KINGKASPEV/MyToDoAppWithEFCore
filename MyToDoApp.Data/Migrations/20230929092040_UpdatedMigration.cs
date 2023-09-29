using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyToDoApp.Data.Migrations
{
    public partial class UpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Todos",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Todos",
                newName: "DueDate");
        }
    }
}
