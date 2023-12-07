using System.Runtime.InteropServices;

namespace Crm.Data;
interface OrderRepository
{
     ValueTask<bool> CreateAsync (Order order, CancellationToken token = default);
    
     ValueTask<int> CountAsync (CancellationToken token = default);
     ValueTask<bool> UpdateOrderAsync(string orderId, string orderSpes, CancellationToken token = default);
    
}