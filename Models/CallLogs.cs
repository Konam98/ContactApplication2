using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Models
{
	public class CallLogs{
[Key]
public int log_id{get;set;}
public string log_type{get;set;}
public int Date {get;set;}
[ForeignKey("contact_id")]
public Contact Contact{get;set;}
[ForeignKey("user_id")]
public Login Login{get;set;}

    }
}