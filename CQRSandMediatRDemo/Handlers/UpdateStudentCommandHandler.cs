﻿using CQRSandMediatRDemo.Commands;
using CQRSandMediatRDemo.Models;
using CQRSandMediatRDemo.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSandMediatRDemo.Handlers
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = await _studentRepository.GetStudentByIdAsync(command.Id);
            if (studentDetails == null)
                return default;

            studentDetails.StudentName = command.StudentName;
            studentDetails.StudentEmail = command.StudentEmail;
            studentDetails.StudentAddress = command.StudentAddress;
            studentDetails.StudentAge = command.StudentAge;

            return await _studentRepository.UpdateStudentAsync(studentDetails);

        }
    }
}
