using WestcoastEducation.Models;

namespace WestcoastEducation;

// skolan äger alla listor. komposition: listorna skapas här och finns inte utan skolan
public class School
{
    public List<Course> Courses { get; } = new();
    public List<Student> Students { get; } = new();
    public List<Teacher> Teachers { get; } = new();
    public List<EducationLeader> EducationLeaders { get; } = new();
    public List<Administrator> Administrators { get; } = new();

    public void AddCourse(Course course)
    {
        // kollar först att kursnumret inte redan finns
        bool exists = false;
        foreach (var existing in Courses)
        {
            if (existing.CourseNumber == course.CourseNumber)
            {
                exists = true;
            }
        }

        if (exists)
        {
            Console.WriteLine($"Kurs {course.CourseNumber} finns redan.");
        }
        else
        {
            Courses.Add(course);
        }
    }

    public void AddStudent(Student student)
    {
        // kollar först att personnumret inte redan finns
        bool exists = false;
        foreach (var existing in Students)
        {
            if (existing.PersonalNumber == student.PersonalNumber)
            {
                exists = true;
            }
        }

        if (exists)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} är redan registrerad.");
        }
        else
        {
            Students.Add(student);
        }
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddEducationLeader(EducationLeader leader)
    {
        EducationLeaders.Add(leader);
    }

    public void AddAdministrator(Administrator admin)
    {
        Administrators.Add(admin);
    }

    // matchar en lärare till en kurs: kursen får läraren och läraren får kursen i sin lista
    public void AssignTeacher(string courseNumber, Teacher teacher)
    {
        bool found = false;
        foreach (var course in Courses)
        {
            if (course.CourseNumber == courseNumber)
            {
                course.Teacher = teacher;
                teacher.Courses.Add(course);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Hittade ingen kurs med nummer {courseNumber}.");
        }
    }

    public void ListCourses()
    {
        Console.WriteLine("Kurser:");

        if (Courses.Count == 0)
        {
            Console.WriteLine("  inga kurser inlagda");
        }
        else
        {
            foreach (var course in Courses)
            {
                Console.WriteLine($"  {course}");
            }
        }
    }

    // bara kurserna på distans, ett villkor inne i loopen
    public void ListDistanceCourses()
    {
        Console.WriteLine("Distanskurser:");

        foreach (var course in Courses)
        {
            if (course.IsOnline)
            {
                Console.WriteLine($"  {course}");
            }
        }
    }

    public void ListStudents()
    {
        Console.WriteLine("Studerande:");

        if (Students.Count == 0)
        {
            Console.WriteLine("  inga studerande inlagda");
        }
        else
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"  {student}");
            }
        }
    }
}
