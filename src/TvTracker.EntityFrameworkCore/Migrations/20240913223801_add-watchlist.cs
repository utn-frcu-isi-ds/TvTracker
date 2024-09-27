﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvTracker.Migrations
{
    /// <inheritdoc />
    public partial class addwatchlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WatchlistId",
                table: "AppSeries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppWatchlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWatchlist", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSeries_WatchlistId",
                table: "AppSeries",
                column: "WatchlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSeries_AppWatchlist_WatchlistId",
                table: "AppSeries",
                column: "WatchlistId",
                principalTable: "AppWatchlist",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSeries_AppWatchlist_WatchlistId",
                table: "AppSeries");

            migrationBuilder.DropTable(
                name: "AppWatchlist");

            migrationBuilder.DropIndex(
                name: "IX_AppSeries_WatchlistId",
                table: "AppSeries");

            migrationBuilder.DropColumn(
                name: "WatchlistId",
                table: "AppSeries");
        }
    }
}
