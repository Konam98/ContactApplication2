using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Models
{
	public class Login{
        [Key]
    public int userIid {get;set;}
    public string email {get;set;}
    public string password{get;set;}
    [ForeignKey("userreg_id")]
    public Register Register {get;set;}
    }
    
    
}