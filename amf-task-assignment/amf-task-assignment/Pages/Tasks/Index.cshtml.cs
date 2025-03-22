using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace amf_task_assignment.Pages.Tasks
{
    public class IndexModel : PageModel
    {

        public List<TaskList> taskLists = new List<TaskList>();

        public void OnGet()
        {

            try
            {
               string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=taskDB;Encrypt=False;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM tasks";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                TaskList tasklist = new TaskList();
                                tasklist.TaskID = "" + reader.GetInt32(0);
                                tasklist.Title = reader.GetString(1);
                                tasklist.Description = reader.GetString(2);


                                taskLists.Add(tasklist);
                            }

                        }
                    }
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ ex.ToString());
            }

        } 
    }

    public class TaskList
    {
        public System.String TaskID { get; set; }
        public System.String Title { get; set; }
        public System.String Description { get; set; }

    }





}
