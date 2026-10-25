namespace WestcoastEducation.Models;

public class Course
{
    public required string CourseNumber { get; set; }
    public required string Title { get; set; }
    public int Duration { get; set; }
    public string DurationUnit { get; set; } = "veckor"; // veckor eller dagar
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsOnline { get; set; } // true = distans, false = klassrum...

    // aggregation: läraren finns även utan kursen, kursen pekar bara på en lärare.
    // ? betyder att kursen kan sakna lärare än så länge...
    public Teacher? Teacher { get; set; }

    public override string ToString()
    {
        string form;
        if (IsOnline)
        {
            form = "distans";
        }
        else
        {
            form = "klassrum";
        }

        string teacherName;
        if (Teacher is null)
        {
            teacherName = "ingen lärare än";
        }
        else
        {
            teacherName = $"{Teacher.FirstName} {Teacher.LastName}";
        }

        // yyyy-MM-dd så att datumet ser likadant ut på alla datorer
        return $"{CourseNumber} {Title}, {Duration} {DurationUnit}, {form}, {StartDate:yyyy-MM-dd} till {EndDate:yyyy-MM-dd}, lärare: {teacherName}";
    }
}
