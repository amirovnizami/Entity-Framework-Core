using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateCommentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "commentText",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commentText",
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
    }
}
