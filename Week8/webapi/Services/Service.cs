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
            var studentDto = new StudentDto {
                StudentId  = student.StudentId,
                EmailAddress = student.EmailAddress
            };
            if (BusinessRules.studentIdIsOdd(student))
            {
                studentDto.Special = true;
            }
            studentDtos.Add(studentDto);
        }

        return studentDtos;
    }
}