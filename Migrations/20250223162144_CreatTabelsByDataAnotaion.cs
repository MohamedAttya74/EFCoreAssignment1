using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment1.Migrations
{
    /// <inheritdoc />
    public partial class CreatTabelsByDataAnotaion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "Crs_Name");

            migrationBuilder.RenameColumn(
                name: "Crs_Duration",
                table: "Courses",
                newName: "Course_Duration");

            migrationBuilder.AlterColumn<string>(
                name: "Crs_Name",
                table: "Courses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Dept_Desc = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Dept_Location = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Department_Manger = table.Column<int>(type: "int", nullable: false),
                    Manager_hiredate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ins_Degree = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ins_Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Lname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Super = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topices",
                columns: table => new
                {
                    Top_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Top_Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topices", x => x.Top_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Topices");

            migrationBuilder.RenameColumn(
                name: "Crs_Name",
                table: "Courses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Course_Duration",
                table: "Courses",
                newName: "Crs_Duration");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
