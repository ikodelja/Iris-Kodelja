using KingICT.Academy.Infrastructure.Messaging;

namespace KingICT.Academy.Messaging.Student
{
    public class CreateStudentRequest : RequestBase
    {
        public StudentDto Student { get; set; }
    }
}
