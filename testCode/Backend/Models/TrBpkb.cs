using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class TrBpkb
{
    [Key] 
    public int agreement_number { get; set; } 

    
    public string bpkb_no { get; set; } = null!;
    public string branch_id { get; set; } = null!;
    public DateTime bpkb_date { get; set; }
    public string faktur_no { get; set; } = null!;
    public DateTime faktur_date { get; set; }
    public string location_id { get; set; } = null!;
    public string police_no { get; set; } = null!;
    public DateTime bpkb_date_in { get; set; }
    public string created_by { get; set; } = null!;
    public DateTime created_on { get; set; }
    public string? last_updated_by { get; set; }
    public DateTime? last_updated_on { get; set; }
}