using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Crm.Data;
[Table ("client")]
//[EntityTypeConfiguration(typeof(ClientConfiguration))]
public sealed class Client
{
    [Column("id")]
    [Required]
    public long Id {get; set;}
   public  string Phone {get; set;}
    public  string Email {get; set;}
    public  string Password {get; set;}
    [Column("first_name")]
    [Required]
    public  string FirstName {get; set;}
    public  string LastName {get; set;}
   public  string MiddleName {get; set;}
   public  short Age {get; set;}
    public  string PassportNumber {get; set;}
    public  string Gender {get; set;}
   public ICollection<Order> orders {get; set;}
        
}
