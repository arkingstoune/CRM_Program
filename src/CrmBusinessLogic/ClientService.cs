using Crm.Data;
using System;
using System.Collections.Generic;
namespace Crm.BusinessLogic;
public sealed class ClientService
{
    public List<Client> _listofclients;
    public ClientService()
    {
        _listofclients = new();
    }
    public void CreateClient(ClientInfo clientInfo)
    {
        Client NewClient = new()
        {
        FirstName = clientInfo.FirstName,
        LastName = clientInfo.LastName,
        MiddleName = clientInfo.MiddleName,
        PassportNumber = clientInfo.PassportNumber,
        Gender = clientInfo.Gender,
        Age = short.Parse(clientInfo.Age)
        };
        
        _listofclients.Add(NewClient);
        // return NewClient;
    }   
    public Client Print_listOfClients(string firstName, string lastName)
    {
        foreach (var person in _listofclients)
        {
            if(person.FirstName.Equals(firstName) && person.LastName.Equals(lastName) ) return person;
        }
        return null;
    }
    public void CreateOrder(OrderInfo orderinfo) 
    {
        Order neworder = new()
        {
            OrderSpeciFication = orderinfo.OrderSpeciFication,
            OrderId = orderinfo.OrderId,
            Adress = orderinfo.Adress
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