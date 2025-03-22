using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.ComponentModel.DataAnnotations;

namespace amf_task_assignment.Pages.Acccount
{

    public class LoginModel : PageModel
    {

        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
            this.Credential = new Credential { UserName = "admin"};
        }

        public void OnPost() 
        { 
            if (Credential.UserName == "admin" && Credential.Password == "password")
            {
                Response.Redirect("/Tasks/Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                
            }

        }
    }

    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }



}
