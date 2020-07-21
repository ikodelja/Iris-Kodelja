using System.Collections.Generic;
using System.Threading.Tasks;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Student;

namespace KingICT.Academy.Contract
{
    public interface IStudentService
    {
        Task<BasicResponse> Create(CreateStudentRequest request);
        Task<GetStudentsResponse> GetStudents();
    }
}
