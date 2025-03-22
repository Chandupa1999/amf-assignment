using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace amf_task_assignment.Pages.Tasks
{
    public class CreateModel : PageModel
    {

        public TaskList taskList = new TaskList();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            taskList.Title = Request.Form["Title"];
            taskList.Description = Request.Form["Description"];

            if (taskList.Title.Length ==  0 || taskList.Description.Length == 0)
            {
                errorMessage = "All the fields should be Filled!";
                return;
            }

            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=taskDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO tasks" +
                                 "(Title, Description) VALUES " +
                                 "(@Title, @Description);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Title", taskList.Title);
                        command.Parameters.AddWithValue("@Description", taskList.Description);

                        command.ExecuteNonQuery();
                    }

                }

                    
             }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            taskList.Title = ""; taskList.Description = "";
            successMessage = "New Task Added Successfully!";


            Response.Redirect("/Tasks/Index");
        }

           


    }
}
