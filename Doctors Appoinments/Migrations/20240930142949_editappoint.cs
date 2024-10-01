using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctors_Appoinments.Migrations
{
    /// <inheritdoc />
    public partial class editappoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "Appoinments",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "Appoinments",
                type: "Varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);
        }
    }
}
