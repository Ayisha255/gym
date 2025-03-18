﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddGymDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "GymClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "GymClasses");
        }
    }
}
