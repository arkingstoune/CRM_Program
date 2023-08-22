
using System;
namespace Crm;

public record ClientMethod
{
    string FirstName{get; init;}
    string LastName{get; init;}
    string MiddleName{get; init;}
    string Age{get; init;}
    string PasportNumber{get; init;}
    string Gender{get; init;}
    public void Deconstruct(out string firstName,out string lastName,out string middleName,out string age,out string passportNumber,out string gender)
    {
        firstName = FirstName;
        lastName = LastName;
        middleName = MiddleName;
        age = Age;
        passportNumber = PasportNumber;
        gender = Gender;
   }
}

