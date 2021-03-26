using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmalAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryCode = table.Column<double>(type: "REAL", nullable: false),
                    CityCode = table.Column<double>(type: "REAL", nullable: false),
                    BloodGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    PatientLastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Ethnicity = table.Column<string>(type: "TEXT", nullable: true),
                    Religion = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DOD = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PatientAddress = table.Column<string>(type: "TEXT", nullable: true),
                    MrNo = table.Column<int>(type: "INTEGER", nullable: false),
                    MobileNumber = table.Column<double>(type: "REAL", nullable: false),
                    EmergencyContactPerson = table.Column<double>(type: "REAL", nullable: false),
                    EmergencyContactMobNo = table.Column<double>(type: "REAL", nullable: false),
                    PatientMiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    CNIC = table.Column<string>(type: "TEXT", nullable: true),
                    Passport = table.Column<string>(type: "TEXT", nullable: true),
                    DMLInsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DMLInsertBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
