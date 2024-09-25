﻿namespace StudentRegister.Models.Commands
{
    public class UpdateFamilyMemberCommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int RelationshipId { get; set; }
    }
}
