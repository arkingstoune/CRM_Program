namespace Crm;

public readonly struct ClientInfo 
{
    public required readonly string FirstName { get; init; }
    public required readonly  string LastName { get; init; }
    public readonly string MiddleName { get; init; }
    public required readonly  short Age { get; init; }
    public readonly string PassportNumber { get; init; }
    public readonly string Gender { get; init; }
    
}