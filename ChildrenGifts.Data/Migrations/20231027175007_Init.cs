using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChildrenGifts.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Organization = table.Column<string>(type: "TEXT", nullable: false),
                    ParentFullName = table.Column<string>(type: "TEXT", nullable: false),
                    ChildFullName = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    FormDate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_FormDate",
                table: "Children",
                column: "FormDate");

            migrationBuilder.CreateIndex(
                name: "IX_Children_Id",
                table: "Children",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Children_Type",
                table: "Children",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");
        }
    }
}
