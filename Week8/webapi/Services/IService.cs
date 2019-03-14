using System.Collections.Generic;
using Database.Entities;

public interface IService
{
    List<StudentDto> GetAllStudents();
}