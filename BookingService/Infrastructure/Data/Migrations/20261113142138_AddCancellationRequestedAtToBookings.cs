using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingService.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCancellationRequestedAtToBookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CancellationRequestedAt",
                table: "bookings",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Version",
                table: "bookings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancellationRequestedAt",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "bookings");
        }
    }
}
