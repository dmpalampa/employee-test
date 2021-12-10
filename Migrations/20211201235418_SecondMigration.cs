using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repo.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    village = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    zip_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dName = table.Column<string>(nullable: true),
                    dHead = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    f_name = table.Column<string>(nullable: true),
                    l_name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    dept_id = table.Column<int>(nullable: false),
                    deptId = table.Column<long>(nullable: true),
                    address_id = table.Column<int>(nullable: false),
                    addressId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Address_addressId",
                        column: x => x.addressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Department_deptId",
                        column: x => x.deptId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "dHead", "dName" },
                values: new object[] { 1L, "daud", "Security" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "addressId", "address_id", "deptId", "dept_id", "email", "f_name", "l_name" },
                values: new object[] { 1L, null, 0, null, 0, "david@test.com", "david", "daud" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "addressId", "address_id", "deptId", "dept_id", "email", "f_name", "l_name" },
                values: new object[] { 2L, null, 0, null, 0, "mark@test.com", "john", "mark" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_addressId",
                table: "Employee",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_deptId",
                table: "Employee",
                column: "deptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
