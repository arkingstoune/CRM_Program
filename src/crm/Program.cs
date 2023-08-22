using Crm;
using System;

ClientService clientService = new();
 List<Client> ListOfClients = new List<Client>();
 

CreateOrder();
ClientMethod Oleg = new ClientMethod();

void CreateClient()
{
    string? firstName = Console.ReadLine();
    string? lastName = Console.ReadLine();
    string? middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string? passportNumber = Console.ReadLine();
    string? gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(new ClientInfo(){
        FirstName = firstName,
        LastName = lastName,
        Age = age
    });
    Console.WriteLine(newClient.FirstName);
}
void CreateOrder()
{
    string? OrderSpeciFication =  Console.ReadLine();
    string? Ordreid = Console.ReadLine();
    Client newClient = clientService.CreateOrder(new ClientOrder()
    {
        OrderSpecification =  OrderSpeciFication,
        OrderId = Ordreid 
    });
    Console.WriteLine(newClient.OrderId);
    ListOfClients.Add(newClient);

}