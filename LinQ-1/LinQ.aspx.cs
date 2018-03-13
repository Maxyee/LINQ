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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SampleDataContext dataContext = new SampleDataContext(con);

            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // this is call array linq query
            GridView3.DataSource = from n in numbers
                                   where n%2 == 0
                                   select n;

            GridView3.DataBind();

            //this query is Linq to Sql 
            GridView2.DataSource = from student in dataContext.Students
                                    where student.Gender == "Male"
                                   select student;

            GridView2.DataBind();
        }
    }
}