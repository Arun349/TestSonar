using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFramework_CRUD_VMS.Migrations
{
    /// <inheritdoc />
    public partial class flip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicledetails",
                columns: table => new
                {
                    Vehicle_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Vehicle_Type = table.Column<string>(type: "longtext", nullable: false),
                    Vehicle_Name = table.Column<string>(type: "longtext", nullable: false),
                    Vehicle_Number = table.Column<string>(type: "longtext", nullable: false),
                    Owner_Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicledetails", x => x.Vehicle_Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicledetails");
        }
    }
}
