using Microsoft.EntityFrameworkCore.Migrations;

namespace KingICT.Academy.Repository.Migrations
{
    public partial class StudentCourseMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                    //StudentId1 = table.Column<int>(nullable: true),
                    //CourseId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_StudentCourse_Course_CourseId1",
                    //    column: x => x.CourseId1,
                    //    principalTable: "Course",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_StudentCourse_Student_StudentId1",
                    //    column: x => x.StudentId1,
                    //    principalTable: "Student",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StudentCourse_CourseId1",
            //    table: "StudentCourse",
            //    column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourse");
        }
    }
}
