using CQRSandMediatRDemo.Models;
using CQRSandMediatRDemo.Queries;
using CQRSandMediatRDemo.Repositories;
using MediatR;

namespace CQRSandMediatRDemo.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
