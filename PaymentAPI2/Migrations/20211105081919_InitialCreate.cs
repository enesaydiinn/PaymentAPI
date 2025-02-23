﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAPI2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarChar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarChar(16)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarChar(5)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarChar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
