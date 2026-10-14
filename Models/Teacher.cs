namespace WestcoastEducation.Models;

// en lärare är en person med ett kunskapsområde och en lista med kurser
public class Teacher : Person
{
    public required string KnowledgeArea { get; set; }

    // aggregation: kurserna finns i skolan oavsett vilken lärare som har dem,
    // listan pekar bara på dem
    public List<Course> Courses { get; set; } = new();

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {KnowledgeArea}, {Courses.Count} kurser";
    }
}
