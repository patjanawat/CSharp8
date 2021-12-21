using System.Diagnostics.Tracing;
public record Person{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Person(string firstName, string lastName)=> (FirstName,LastName)=(firstName,lastName);

}

public record Teacher : Person
{
    public string Subject { get; set; }
    
    public Teacher(string firstName,string lastName, string sub):base(firstName, lastName)=>Subject = sub;
}

public sealed record Student : Person{
    public int Level { get; set; }
    public Student(string firstName, string lastName,int level):base(firstName, lastName)=> Level = level;
}