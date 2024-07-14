using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTicketREA.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketCategory",
                table: "Events",
                newName: "CreditCardNumber");

            migrationBuilder.RenameColumn(
                name: "EventLocation",
                table: "Events",
                newName: "CardCode");

            migrationBuilder.RenameColumn(
                name: "EventDate",
                table: "Events",
                newName: "ExpirationDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Events",
                newName: "EventDate");

            migrationBuilder.RenameColumn(
                name: "CreditCardNumber",
                table: "Events",
                newName: "TicketCategory");

            migrationBuilder.RenameColumn(
                name: "CardCode",
                table: "Events",
                newName: "EventLocation");
        }
    }
}
