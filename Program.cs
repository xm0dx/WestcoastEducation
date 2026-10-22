using WestcoastEducation.Models;

namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Westcoast Education");
        Console.WriteLine();

        var school = new School();

        // två lärare
        var anna = new Teacher
        {
            FirstName = "Anna",
            LastName = "Berg",
            Phone = "070-111 22 33",
            PersonalNumber = "19850412-1234",
            Address = "Storgatan 1",
            PostalCode = "411 24",
            City = "Göteborg",
            KnowledgeArea = "Webbutveckling"
        };

        var johan = new Teacher
        {
            FirstName = "Johan",
            LastName = "Lind",
            Phone = "070-222 33 44",
            PersonalNumber = "19790923-5678",
            Address = "Hamngatan 8",
            PostalCode = "442 31",
            City = "Kungälv",
            KnowledgeArea = "Mobila appar"
        };

        school.AddTeacher(anna);
        school.AddTeacher(johan);

        // en utbildningsledare och en administratör
        var maria = new EducationLeader
        {
            FirstName = "Maria",
            LastName = "Holm",
            Phone = "070-333 44 55",
            PersonalNumber = "19720615-9012",
            Address = "Kyrkogatan 3",
            PostalCode = "442 30",
            City = "Kungälv",
            KnowledgeArea = "Systemutveckling",
            EmploymentDate = new DateTime(2015, 8, 17)
        };

        var oskar = new Administrator
        {
            FirstName = "Oskar",
            LastName = "Nyström",
            Phone = "070-444 55 66",
            PersonalNumber = "19900301-3456",
            Address = "Ängsvägen 12",
            PostalCode = "415 05",
            City = "Göteborg",
            KnowledgeArea = "Administration",
            EmploymentDate = new DateTime(2021, 1, 11)
        };

        school.AddEducationLeader(maria);
        school.AddAdministrator(oskar);

        // två kurser, en i klassrum och en på distans
        var webb = new Course
        {
            CourseNumber = "WEB101",
            Title = "Grunderna i webbutveckling",
            Duration = 8,
            StartDate = new DateTime(2026, 11, 2),
            EndDate = new DateTime(2026, 12, 23),
            IsOnline = false
        };

        var mobil = new Course
        {
            CourseNumber = "MOB201",
            Title = "Appar för Android och iOS",
            Duration = 12,
            StartDate = new DateTime(2027, 1, 11),
            EndDate = new DateTime(2027, 4, 2),
            IsOnline = true
        };

        school.AddCourse(webb);
        school.AddCourse(mobil);

        // koppla rätt lärare till rätt kurs
        school.AssignTeacher("WEB101", anna);
        school.AssignTeacher("MOB201", johan);

        // två studerande
        var elin = new Student
        {
            FirstName = "Elin",
            LastName = "Sandberg",
            Phone = "073-123 45 67",
            PersonalNumber = "20010505-1111",
            Address = "Björkallén 21",
            PostalCode = "582 25",
            City = "Linköping"
        };

        var viktor = new Student
        {
            FirstName = "Viktor",
            LastName = "Ek",
            Phone = "076-555 12 34",
            PersonalNumber = "19981230-2222",
            Address = "Kungsgatan 5",
            PostalCode = "111 43",
            City = "Stockholm"
        };

        school.AddStudent(elin);
        school.AddStudent(viktor);

        // testar att samma studerande inte kan läggas till två gånger
        school.AddStudent(elin);

        Console.WriteLine();
        school.ListCourses();

        Console.WriteLine();
        school.ListDistanceCourses();

        Console.WriteLine();
        school.ListStudents();

        Console.WriteLine();
        Console.WriteLine("Personal:");
        Console.WriteLine($"  {anna}");
        Console.WriteLine($"  {johan}");
        Console.WriteLine($"  {maria}");
        Console.WriteLine($"  {oskar}");
    }
}
