namespace WestcoastEducation.Models;

// det som alla personer i systemet har gemensamt.
// skrivs en gång här, de andra klasserna ärver det.
public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public required string PersonalNumber { get; set; }
    public required string Address { get; set; }
    public required string PostalCode { get; set; }
    public required string City { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {City}";
    }
}
