using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
//using System.Windows.Forms;

public partial class student_chngpwd : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    List<string> semesterids = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        con.Open();
        String query1 = "Select Semesters.id from Students,Semesters where Students.course_id=Semesters.course_id AND Students.email='" + Session["CurrentUser"] + "'";
        SqlCommand queComm = new SqlCommand(query1, con);
        using (SqlDataReader reader = queComm.ExecuteReader())
        {
            while (reader.Read())
            {
                semesterids.Add(reader.GetInt32(0).ToString());

            }
            reader.Close();
        }
        con.Close();
    }


    protected void ButtSave_Click(object sender, EventArgs e)
    {
        
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String redirect = "selectMonth.aspx?semid=" + semesterids[0];
        Response.Redirect(redirect);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        //Response.Redirect("selectMonth.aspx?semid=2");
        String redirect = "selectMonth.aspx?semid=" + semesterids[1];
        Response.Redirect(redirect);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //Response.Redirect("selectMonth.aspx?semid=3");
        String redirect = "selectMonth.aspx?semid=" + semesterids[1];
        Response.Redirect(redirect);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //Response.Redirect("selectMonth.aspx?semid=4");
        String redirect = "selectMonth.aspx?semid=" + semesterids[2];
        Response.Redirect(redirect);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button6_Click(object sender, EventArgs e)
    {

    }
}

 
 