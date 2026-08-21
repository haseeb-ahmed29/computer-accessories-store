using System.ComponentModel.DataAnnotations;
namespace ComputerAccessoriesStore.Models;
public class Order
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string CustomerName {get;set;} = string.Empty;
 [Required, StringLength(120)] public string OrderStatus {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
