using CQRSandMediatRDemo.Commands;
using CQRSandMediatRDemo.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSandMediatRDemo.Handlers
{
    public class  DeleteStudentCommandHandler: IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = await _studentRepository.GetStudentByIdAsync(command.Id);
            if (studentDetails == null)
                return default;

            return await _studentRepository.DeleteStudentAsync(studentDetails.Id);
        }
    }
}
