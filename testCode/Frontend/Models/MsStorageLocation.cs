using System.ComponentModel.DataAnnotations;
namespace Frontend.Models;

public class MsStorageLocation
{
    [Key] 
    public string location_id { get; set; }   
    public string location_name { get; set; }
}
