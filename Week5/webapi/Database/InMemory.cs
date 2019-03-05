using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Person> persons = new List<Person> {
            new Person {
                FirstName = "Charlie",
                MiddleInitials = "J",
                LastName = "Chaplin"
            },
            new Person {
                FirstName = "Jennifer",
                MiddleInitials = "L",
                LastName = "Connoly"
            },
        };

        public static List<Student> students = new List<Student> {
            new Student {
                StudentID = 1,
                EmailAddress = "janisjoplin@blacksabbath.com"
            },
            new Student {
                StudentID = 2,
                EmailAddress = "holycannoli@batman.com"
            },
        };
    }
}