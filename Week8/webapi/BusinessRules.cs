using System;
using Database.Entities;

namespace StudentBusinessRules {
    public static class BusinessRules
    {
        public static bool studentIdIsOdd(Student student) => 
            student.StudentId % 2 > 0 ;
    }
}