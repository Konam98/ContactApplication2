using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models
{
    public class Register{
    [Key]
    public int userreg_id {get;set;}
    public string user_name {get;set;}
    public string email {get;set;}
    public string password{get;set;}
    public string mobile_number{get;set;}
    }
}