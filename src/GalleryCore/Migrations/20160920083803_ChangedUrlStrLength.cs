Updausing System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GalleryCore.Migrations
{
    public partial class ChangedUrlStrLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "GalleryPics",
                maxLength: 450,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "GalleryPics",
                nullable: false);
        }
    }
}
