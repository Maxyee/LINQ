using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQ_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // LinQ Query With Lambda Expression
            IEnumerable<Student> queryResult =  Student.GetAllStudents().Where(s => s.Gender == "Male");

            GridView1.DataSource = queryResult;
            GridView1.DataBind();


            // LinQ to Sql Query
            IEnumerable<Student> queryResult2 = from s in Student.GetAllStudents()
                                                where s.Gender == "Male"
                                                select s;

            GridView2.DataSource = queryResult2;
            GridView2.DataBind();
        }
    }
}