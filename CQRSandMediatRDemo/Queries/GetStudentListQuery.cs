using CQRSandMediatRDemo.Models;
using MediatR;

namespace CQRSandMediatRDemo.Queries
{
    public class GetStudentListQuery: IRequest<List<StudentDetails>>
    {
    }
}
