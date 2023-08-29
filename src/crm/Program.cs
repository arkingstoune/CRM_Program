using Crm;
using Crm.BusinessLogic;
using System;

ClientService clientService = new();
 
CreateOrder();
// ClientMethod Oleg = new ClientMethod();

void CreateClient()
{
    string? firstName = Console.ReadLine();
    string? lastName = Console.ReadLine();
    string? middleName = Console.ReadLine();
    string? age = Console.ReadLine();
    string? passportNumber = Console.ReadLine();
    string? gender = Console.ReadLine();
    ClientInfo clientInfo = new(){
        FirstName =firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportNumber,
        Gender = gender
    };
    clientService.CreateClient(clientInfo);
}
void CreateOrder()
{
    string? OrderSpeciFication =  Console.ReadLine();
    string? OrdreId = Console.ReadLine();
    string? orderAdress = Console.ReadLine();
    
    OrderInfo newOrder =new()
    {
        OrderSpeciFication =  OrderSpeciFication,
        OrderId = OrdreId,
        Adress = orderAdress
    };
    clientService.CreateOrder(newOrder);

}