﻿using StudentRegister.Models.Commands;

namespace StudentRegister.DataAccess.Commands.Interfaces
{
    public interface IStudentCommandRepository
    {
        int AddStudent(AddStudentCommand student);
        int AddFamilyMemberOfStudent(AddFamilyMemberCommand familyMember);
        int UpdateStudent(UpdateStudentCommand student);
        int UpdateNationalityOfStudent(UpdateStudentNationalityCommand command);        
    }
}
