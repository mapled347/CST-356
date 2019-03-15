using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using StudentBusinessRules;

public class Service : IService
{
    private readonly IStudentRepository _studentRepository;

    public Service(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
            });
            if (BusinessRules.studentIdIsOdd(student))
            {
                student.Special = true;
            }
        }

        return studentDtos;
    }
}