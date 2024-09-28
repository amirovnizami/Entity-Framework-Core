using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class update_Comment_Configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "content_Comment",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "commentId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_commentId",
                table: "Comments",
                column: "commentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_commentId",
                table: "Comments",
                column: "commentId",
                principalTable: "Comments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_commentId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_commentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "commentId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "content_Comment",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
