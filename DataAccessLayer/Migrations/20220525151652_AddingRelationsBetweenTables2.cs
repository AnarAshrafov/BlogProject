using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddingRelationsBetweenTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_PostID",
                table: "PostTags",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagID",
                table: "PostTags",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                column: "PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Posts_PostID",
                table: "PostTags",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagID",
                table: "PostTags",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Posts_PostID",
                table: "PostTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagID",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_PostTags_PostID",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_PostTags_TagID",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostID",
                table: "Comments");
        }
    }
}
