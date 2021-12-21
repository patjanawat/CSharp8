namespace AnimalNameGroup
{
    public record Animal(string firstName, string lastName);
    public record Dog(string firstName, string lastName,string subject):Animal(firstName,lastName);
    public record Cat(string firstName, string lastName, int level):Animal(firstName,lastName);
}