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
//using System.Windows.Forms;

public partial class student_chngpwd : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    String semesterid;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        semesterid = Request.QueryString["semid"];
        Label1.Text = "Select Month";// (" + semesterid + "Semester)";
    }


    protected void ButtSave_Click(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=1");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=2");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=3");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=4");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=5");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBack.aspx?semid=" + semesterid + "&feedbackmonth=6");
    }
}

 
 