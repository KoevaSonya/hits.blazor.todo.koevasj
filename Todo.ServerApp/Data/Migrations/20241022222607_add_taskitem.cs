using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TasksItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDaate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDaate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TasksItems",
                columns: new[] { "Id", "CreationDaate", "Description", "FinishDaate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 3, 26, 6, 401, DateTimeKind.Local).AddTicks(9397), "Описание задачи 1", null, "Задача 1" },
                    { 2, new DateTime(2024, 10, 23, 3, 26, 6, 401, DateTimeKind.Local).AddTicks(9411), "Описание задачи 2", null, "Задача 2" },
                    { 3, new DateTime(2024, 10, 23, 3, 26, 6, 401, DateTimeKind.Local).AddTicks(9413), "Описание задачи 3", null, "Задача 3" },
                    { 4, new DateTime(2024, 10, 23, 3, 26, 6, 401, DateTimeKind.Local).AddTicks(9414), "Описание задачи 4", null, "Задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksItems");
        }
    }
}
