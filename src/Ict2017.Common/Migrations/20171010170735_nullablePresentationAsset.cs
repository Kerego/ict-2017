using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Ict2017.Common.Migrations
{
    public partial class nullablePresentationAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presentations_Assets_AssetId",
                table: "Presentations");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "Presentations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Presentations_Assets_AssetId",
                table: "Presentations",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presentations_Assets_AssetId",
                table: "Presentations");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "Presentations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Presentations_Assets_AssetId",
                table: "Presentations",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
