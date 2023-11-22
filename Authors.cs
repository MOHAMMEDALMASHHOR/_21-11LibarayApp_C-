public class Authors
{
    public Authors(int id, string? firstName, string? lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get=>FirstName+" "+ LastName;  }

    

    public override string ToString()
    {
        return $"The author({Id})'s Name is: {FullName}";
    }

}