﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister.DataAccess.Test
{
    public static class TestData
    {
        public static class Student1
        {
            public static readonly int Id = 1;
            public static readonly string FirstName = "Fateh";
            public static readonly string LastName = "Rahman";
            public static readonly int NationalityId = 1 ;
        }
        public static class Student2
        {
            public static readonly int Id = 2;
            public static readonly string FirstName = "Faleh";
            public static readonly string LastName = "Rahman";
            public static readonly int NationalityId = 2;
        }

        public static class FamilyMember1
        {
            public static readonly int Id = 1;
            public static readonly string FirstName = "Sayedur";
            public static readonly string LastName = "Rahman";
            public static readonly int RelationId = 1;
            public static readonly int NationalityId = 1;
            public static readonly int StudentID = 1;
        }

        public static class FamilyMember2
        {
            public static readonly int Id = 2;
            public static readonly string FirstName = "Fahima";
            public static readonly string LastName = "Fayez";
            public static readonly int RelationId = 2;
            public static readonly int NationalityId = 2;
            public static readonly int StudentID = 2;
        }

        public static class FamilyMember11
        {
            public static readonly int Id = 3;
            public static readonly string FirstName = "Bushra";
            public static readonly string LastName = "Rahman";
            public static readonly int RelationId = 2;
            public static readonly int NationalityId = 3;
            public static readonly int StudentID = 1;
        }
    }
}
