using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQ_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select ID, FirstName1, LastName, Gender from Students where Gender='Male'",con);
            List<Student> listStudents = new List<Student>();
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student student = new Student();
                student.ID = Convert.ToInt32(rdr["ID"]);
                student.FirstName = rdr["FirstName"].ToString();
                student.LastName = rdr["LastName"].ToString();
                student.Gender = rdr["Gender"].ToString();

                listStudents.Add(student);
            }
            con.Close();

            GridView1.DataSource = listStudents;
            GridView1.DataBind();
        }
    }

    //public class Student
    //{
    //    public int ID { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Gender { get; set; }
    //}
}