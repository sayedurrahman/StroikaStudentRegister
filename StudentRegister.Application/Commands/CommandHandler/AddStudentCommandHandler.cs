﻿using StudentRegister.Application.Commands.Interfaces;
using StudentRegister.DataAccess.Commands.Interfaces;
using StudentRegister.Models.Commands;

namespace StudentRegister.Application.Commands.CommandHandler
{
    public class AddStudentCommandHandler : ICommandHandler<AddStudentCommand>
    {
        public IStudentCommandRepository StudentCommandRepository { get; }
        public AddStudentCommandHandler(IStudentCommandRepository studentCommandRepository)
        {
            StudentCommandRepository = studentCommandRepository;
        }

        public int Handle(AddStudentCommand command)
        {
            return StudentCommandRepository.AddStudent(command);
        }
    }
}
