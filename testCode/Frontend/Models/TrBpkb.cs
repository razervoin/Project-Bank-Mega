using System.ComponentModel.DataAnnotations;

namespace Frontend.Models;
public class TrBpkb
{   
    [Key]
    public string agreement_number { get; set; } = null!;
    public string bpkb_no { get; set; } = null!;
    public string branch_id { get; set; } = null!;
    public DateTime bpkb_date { get; set; }
    public string faktur_no { get; set; } = null!;
    public DateTime faktur_date { get; set; }
    public string location_id { get; set; } = null!;
    public string police_no { get; set; } = null!;
    public DateTime bpkb_date_in { get; set; }
    public string created_by { get; set; } = null!;
}