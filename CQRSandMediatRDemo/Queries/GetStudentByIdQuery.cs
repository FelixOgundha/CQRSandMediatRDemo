using CQRSandMediatRDemo.Models;
using MediatR;

namespace CQRSandMediatRDemo.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
