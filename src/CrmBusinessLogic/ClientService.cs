using Crm;
using System;
using System.Collections.Generic;
public sealed class ClientService
{
    public List<Client> _listofclients;
    public ClientService()
    {
        _listofclients = new();
    }
    public Client CreateClient(ClientInfo clientInfo)
    {
        Client NewClient = new()
        {
        FirstName = clientInfo.FirstName,
        LastName = clientInfo.LastName,
        MiddleName = clientInfo.MiddleName,
        Age = clientInfo.Age,
        PassportNumber = clientInfo.PassportNumber,
        Gender = clientInfo.Gender
        };
        
        _listofclients.Add(NewClient);
        return NewClient;
    }   
    public Client Print_listOfClients(string firstName, string lastName)
    {
        foreach (var person in _listofclients)
        {
            if(person.FirstName.Equals(firstName) && person.LastName.Equals(lastName) ) return person;
        }
        return null;
    }
    public Client CreateOrder(ClientOrder clientOrder)
    {
        return new()
        {
            OrderSpecification = clientOrder.OrderSpecification,
            OrderId = clientOrder.OrderId
        };
    }
}
interface ClientMustHave
    {
        void CheckForClient();
    }
abstract class CheckoutClient
{
    public bool CheckForClient(Client client)
    {
        bool b = client.FirstName != "";
        bool c = client.LastName != "";
        if (b == true && c == true) return true;
        return false;
    }
}