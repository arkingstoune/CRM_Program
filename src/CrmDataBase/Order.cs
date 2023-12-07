using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crm.Data;
[Table("order")]
public sealed class Order 
{
        CancellationTokenSource cts = new();
    
    public string Id{get; set;} = string.Empty;
    public string OrderSpeciFication{get; set;} = string.Empty;
    [Column("adress")]
    [Required]
    [DataType("VARCHAR(100)")]
    public string Adress{get; set;} = string.Empty;
    public Client clients {get; set;}

}