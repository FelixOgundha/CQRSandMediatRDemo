using CQRSandMediatRDemo.Models;
using CQRSandMediatRDemo.Queries;
using CQRSandMediatRDemo.Repositories;
using MediatR;

namespace CQRSandMediatRDemo.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<StudentDetails> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentByIdAsync(request.Id);
        }
    }
}
