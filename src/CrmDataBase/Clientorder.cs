namespace Crm;

public class ClientOrder
{
    private string? _orderSpecification;
    private string? _orderId;
    public required string OrderSpecification
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
    public required string OrderId
    {
        get =>_orderId ?? string.Empty;
        init
        {
            if(value.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "The valid OrderSpecification ");
            _orderId = value;
        }
    }    
}