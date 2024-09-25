﻿using StudentRegister.DataAccess.Queries.Interfaces;
using StudentRegister.Models.DTOs;

namespace StudentRegister.DataAccess.Queries
{
    public class NationalityQueryRepository : INationalityQueryRepository
    {
        public StudentRegisterContext _studentRegisterContext { get; }

        public NationalityQueryRepository(StudentRegisterContext studentRegisterContext)
        {
            _studentRegisterContext = studentRegisterContext;
        }

        public NationalityDTO[] GetAll()
        {
            return _studentRegisterContext.Nationalities.Select(x => new NationalityDTO(x)).ToArray();
        }
    }
}
