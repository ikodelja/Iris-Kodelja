using KingICT.Academy.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingICT.Academy.Repository.Configurations
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable(nameof(StudentCourse));
            
            builder.HasKey(k => new { k.StudentId, k.CourseId });

            builder.HasOne<Student>()
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.HasOne<Course>()
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

        }
    }
}
