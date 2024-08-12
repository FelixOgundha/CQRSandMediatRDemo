using MediatR;

namespace CQRSandMediatRDemo.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
