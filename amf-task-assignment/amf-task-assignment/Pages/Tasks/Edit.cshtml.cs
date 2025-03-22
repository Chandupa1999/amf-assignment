using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace amf_task_assignment.Pages.Tasks
{
    public class EditModel : PageModel
    {

        public TaskList taskList = new TaskList();
        public string errorMessage = "";
        public string successMessage = "";


        public void OnGet()
        {
            string TaskID = Request.Query["id"];

            if (string.IsNullOrEmpty(TaskID))
            {
                Console.WriteLine("TaskID is required.");
                return;
            }
            try
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=taskDB;Encrypt=False;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM tasks WHERE TaskID=@TaskID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TaskID", TaskID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                taskList.TaskID = "" + reader.GetInt32(0);
                                taskList.Title = reader.GetString(1);
                                taskList.Description = reader.GetString(2);

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }







        public void OnPost() 
        {
            taskList.TaskID = Request.Query["id"];
            taskList.Title = Request.Form["Title"];
            taskList.Description = Request.Form["Description"];

            if (taskList == null || taskList.TaskID.Length == 0 || taskList.Title.Length == 0 || taskList.Description.Length == 0)
            {
                errorMessage = "All Field should be Filled!";
                return;
            }


            try
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=taskDB;Encrypt=False;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE tasks " +
                                 "SET Title=@Title, Description=@Description " +
                                 "WHERE TaskID=@TaskID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Title", taskList.Title);
                        command.Parameters.AddWithValue("@Description", taskList.Description);
                        command.Parameters.AddWithValue("@TaskID", taskList.TaskID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            { 
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Tasks/Index");

        }

    }
}
