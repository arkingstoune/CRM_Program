namespace Crm;

public sealed class Client
{
    private string? _firstName;
    private string? _lastName;
    private string? _middleName;
    private short _age;
    private string? _pasportNumber;
    private string? _gender;
    private string? _orderSpecification;
    private string? _orderId;
    private string? _phone;
    private string? _email;
    private string? _password;

    public  string Phone
    {
        get{ return _phone ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _phone = value;
        }
    }
    public  string Email
    {
        get{ return _email ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _email = value;
        }
    }
    public  string Password
    {
        get{ return _password ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _password = value;
        }
    }
    public  string FirstName
    {
        get{ return _firstName ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _firstName = value;
        }
    }
    public  string LastName
    {
        get{ return _lastName ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _lastName = value;
        }
    }   
   public  string MiddleName
    {
        get{ return _middleName ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _middleName = value;
        }
    } 
   public  short Age
    {
        get{ return _age;}
        init 
        {
            if(value < 18)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _age = value;
        }
    } 
    public  string PassportNumber
    {
        get{ return _pasportNumber ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _pasportNumber = value;
        }
    } 
    public  string Gender
    {
        get{ return _gender ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _gender = value;
        }
    } 
   public  string OrderSpecification
    {
        get{ return _orderSpecification ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _orderSpecification = value;
        }
    } 
    public  string OrderId
    {
        get{ return _orderId ?? string.Empty; }
        init 
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _orderId = value;
        }
    } 
    
    
}
