﻿using StudentRegister.Application.Commands.Interfaces;
using StudentRegister.DataAccess.Commands.Interfaces;
using StudentRegister.Models.Commands;

namespace StudentRegister.Application.Commands.CommandHandler
{
    public class UpdateFamilyMemberNationalityCommandHandler : ICommandHandler<UpdateFamilyMemberNationalityCommand>
    {
        private readonly IFamilyMemberCommandRepository familyMemberCommandRepository;

        public UpdateFamilyMemberNationalityCommandHandler(IFamilyMemberCommandRepository familyMemberCommandRepository)
        {
            this.familyMemberCommandRepository = familyMemberCommandRepository;
        }

        public int Handle(UpdateFamilyMemberNationalityCommand t)
        {
            return familyMemberCommandRepository.UpdateNationalityOfAFamilyMember(t);
        }
    }
}
