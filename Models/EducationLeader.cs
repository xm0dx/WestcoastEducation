namespace WestcoastEducation.Models;

// utbildningsledare: allt en lärare har plus anställningsdatum
public class EducationLeader : Teacher
{
    public DateTime EmploymentDate { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {KnowledgeArea}, anställd {EmploymentDate.ToShortDateString()}";
    }
}
