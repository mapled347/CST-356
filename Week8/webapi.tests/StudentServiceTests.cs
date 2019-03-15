using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using BusinessRules;

public class StudentServiceTests
{
    private Service _service; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _service = new Servoce(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 8,
                    EmailAddress = "cecelia.posey@oit.edu"
                },
                new Student {
                    StudentId = 10,
                    EmailAddress = "penelope.posey@oit.edu"
                }
            }
        );

        // Act
        var studentDtos = _service.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        studentDtos.Any(sdto => sdto.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnSpecialStudents()
    {
        // Arrange
        var expectedStudentId = StudentBusinessRules.Special + "test";

        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = expectedStudentId,
                    EmailAddress = "poseyfamily@outlook.com"
                },
                new Student {
                    StudentId = 11,
                    EmailAddress = "ladybirddog@macklemore.net"
                }
            }
        );

        // Act
        var studentDtos = _service.GetAllStudents();

        // Assert (FluentAssertions)
        studentDtos.Single(sdto => sdto.Special).StudentId.Should().Be(expectedStudentId);
    }

}