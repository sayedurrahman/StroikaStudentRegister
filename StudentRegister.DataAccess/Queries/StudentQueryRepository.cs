﻿using StudentRegister.DataAccess.Queries.Interfaces;
using StudentRegister.Models.DTOs;
using System.Security.Cryptography.X509Certificates;

namespace StudentRegister.DataAccess.Queries
{
    public class StudentQueryRepository : IStudentQueryRepository
    {
        public StudentRegisterContext _context { get; }
        public StudentQueryRepository(StudentRegisterContext context)
        {
            _context = context;
        }

        public StudentDTO[] GetAllStudents()
        {
            return _context.Students.Select(x => new StudentDTO(x)).ToArray();
        }

        public StudentDTO GetAStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null)
                throw new KeyNotFoundException();

            return new StudentDTO(student);
        }

        public FamilyMemberDTO[] GetFamilyMembersOfAStudent(int studentId)
        {
            return _context.FamilyMembers.Where(x => x.StudentID == studentId).Select(x => new FamilyMemberDTO(x)).ToArray();
        }

        public CitizenStudentDTO GetStudentWithNationality(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null)
                throw new KeyNotFoundException();

            return new CitizenStudentDTO(student);
        }
    }
}
