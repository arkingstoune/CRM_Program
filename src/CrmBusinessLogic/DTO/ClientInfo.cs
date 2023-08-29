namespace Crm.BusinessLogic;
public record struct ClientInfo(
    
    string? FirstName,
    string? LastName,
    string? MiddleName,
    string? Age,
    string? PassportNumber,
    string? Gender,
    string? Phone,
    string? Email,
    string? Password
);
public record struct OrderInfo(
    string? OrderId,
    string? OrderSpeciFication,
    string? Adress
);
