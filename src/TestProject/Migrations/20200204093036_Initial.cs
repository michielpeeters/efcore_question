﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Info_FirstName = table.Column<string>(nullable: true),
                    Info_LastName = table.Column<string>(nullable: true),
                    Info_Email = table.Column<string>(nullable: true),
                    ContactInfo_Info_FirstName = table.Column<string>(nullable: true),
                    ContactInfo_Info_LastName = table.Column<string>(nullable: true),
                    ContactInfo_Info_Email = table.Column<string>(nullable: true),
                    ContactInfo_Info_FirstName1 = table.Column<string>(nullable: true),
                    ContactInfo_Info_LastName1 = table.Column<string>(nullable: true),
                    ContactInfo_Info_Email1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}