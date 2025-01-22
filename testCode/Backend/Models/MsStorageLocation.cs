using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class MsStorageLocation
{
    [Key] // Ensure there is a primary key
    public string location_id { get; set; }   
    public string location_name { get; set; }
}



