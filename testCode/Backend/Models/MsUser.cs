using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class MsUser
{
    [Key] 
    public int user_id { get; set; } 

    public string user_name { get; set; } = null!;
    public string password { get; set; } = null!;
    public bool is_active { get; set; }
}

