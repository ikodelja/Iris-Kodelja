using System.Collections.Generic;
using KingICT.Academy.Infrastructure.Messaging;

namespace KingICT.Academy.Messaging.Student
{
    public class GetStudentsResponse : ResponseBase
    {
        public IEnumerable<StudentDto> Students { get; set; }
    }
}
