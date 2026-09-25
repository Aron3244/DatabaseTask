using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class Vangla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prisons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockNumber = table.Column<int>(type: "int", nullable: true),
                    BlockName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SecurityLevel = table.Column<int>(type: "int", nullable: true),
                    PrisonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blocks_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Guards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrisonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guards_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chambers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChamberNumber = table.Column<int>(type: "int", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    BlockId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chambers_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Guards_GuardId",
                        column: x => x.GuardId,
                        principalTable: "Guards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthOfDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArivelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChamberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisoners_Chambers_ChamberId",
                        column: x => x.ChamberId,
                        principalTable: "Chambers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Crimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GradeOfCrime = table.Column<int>(type: "int", nullable: true),
                    ArivelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PrisonerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crimes_Prisoners_PrisonerId",
                        column: x => x.PrisonerId,
                        principalTable: "Prisoners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Punishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeOfPunishment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArivelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PrisonerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Punishments_Prisoners_PrisonerId",
                        column: x => x.PrisonerId,
                        principalTable: "Prisoners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visitings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GuestId = table.Column<int>(type: "int", nullable: true),
                    PrisonerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitings_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Visitings_Prisoners_PrisonerId",
                        column: x => x.PrisonerId,
                        principalTable: "Prisoners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_PrisonId",
                table: "Blocks",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Chambers_BlockId",
                table: "Chambers",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Crimes_PrisonerId",
                table: "Crimes",
                column: "PrisonerId");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_PrisonId",
                table: "Guards",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_ChamberId",
                table: "Prisoners",
                column: "ChamberId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_PrisonerId",
                table: "Punishments",
                column: "PrisonerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_GuardId",
                table: "Shifts",
                column: "GuardId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitings_GuestId",
                table: "Visitings",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitings_PrisonerId",
                table: "Visitings",
                column: "PrisonerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crimes");

            migrationBuilder.DropTable(
                name: "Punishments");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Visitings");

            migrationBuilder.DropTable(
                name: "Guards");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Chambers");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Prisons");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }
    }
}
