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


public partial class feedbackreport : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        if (!IsPostBack)
        {
            String selectQuery = "Select id, name from Semesters where course_id in(Select MIN(id) from Courses)";
            SqlCommand cmd = new SqlCommand(selectQuery);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            ddlSem.DataSource = cmd.ExecuteReader();
            ddlSem.DataTextField = "name";
            ddlSem.DataValueField = "id";
            ddlSem.DataBind();
            conn.Close();
        }
        
    }
protected void  ButtSave_Click(object sender, EventArgs e)
{
  
    
}

public string lusername { get; set; }
protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
{
    //String courseid = ddlCourse.SelectedItem.Value;
    String selectQuery = "Select id, name from Semesters where course_id='" + ddlCourse.SelectedItem.Value + "'";
    SqlCommand cmd = new SqlCommand(selectQuery);

    cmd.CommandType = CommandType.Text;
    cmd.Connection = conn;
    conn.Open();
    ddlSem.DataSource = cmd.ExecuteReader();
    ddlSem.DataTextField = "name";
    ddlSem.DataValueField = "id";
    ddlSem.DataBind();
    conn.Close();

    /////

    String selectQuery1 = "Select id,name from Subjects Where course_id='" + ddlCourse.SelectedItem.Value + "' And semester_id='"+ddlSem.SelectedItem.Value+"'";
    cmd = new SqlCommand(selectQuery1);

    cmd.CommandType = CommandType.Text;
    cmd.Connection = conn;
    conn.Open();
    ddlSubject.DataSource = cmd.ExecuteReader();
    ddlSubject.DataTextField = "name";
    ddlSubject.DataValueField = "id";
    ddlSubject.DataBind();
    conn.Close();

}
protected void ddlSem_SelectedIndexChanged(object sender, EventArgs e)
{
    String selectQuery1 = "Select id,name from Subjects Where course_id='" + ddlCourse.SelectedItem.Value + "' And semester_id='" + ddlSem.SelectedItem.Value + "'";
    cmd = new SqlCommand(selectQuery1);

    cmd.CommandType = CommandType.Text;
    cmd.Connection = conn;
    conn.Open();
    ddlSubject.DataSource = cmd.ExecuteReader();
    ddlSubject.DataTextField = "name";
    ddlSubject.DataValueField = "id";
    ddlSubject.DataBind();
    conn.Close();
}
protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
{

}
protected void Button1_Click(object sender, EventArgs e)
{

    String query = "Select  questions.id,questions.Details, AVG(mark) "+ 
                    " As average from questions,feedback_details,feedback "+
                    " where questions.id=feedback_details.question_id "+
                    " AND feedback_details.feedback_id=feedback.id "+
                    " AND feedback.subject_id='"+ ddlSubject.SelectedItem.Value+"'"+
                    " GROUP BY questions.id,questions.Details ";
    SqlDataSource SqlDataSource1 = new SqlDataSource();
    SqlDataSource1.ID = "SqlDataSource1";
    this.Page.Controls.Add(SqlDataSource1);
    SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
    SqlDataSource1.SelectCommand = query;
    GridView1.DataSource = SqlDataSource1;
    GridView1.DataBind();

    Label2.Text = ddlSubject.SelectedItem.Text;
    String avgQuery = "Select AVG(average) from "+
                       " (Select  AVG(mark) As average from questions,feedback_details,feedback "+
                       " where questions.id=feedback_details.question_id "+
                       " AND feedback_details.feedback_id=feedback.id "+
                       " AND feedback.subject_id='"+ddlSubject.SelectedItem.Value+"' GROUP BY questions.id) gavg";
    conn.Open();
    //string checkPasswordQuery = "select id from Students where email = '" + Session["CurrentUser"] + "' ";
    SqlCommand passComm = new SqlCommand(avgQuery, conn);
    String avgQ = passComm.ExecuteScalar().ToString().Replace(" ", "");
    conn.Close();
    Label3.Text = avgQ;
    conn.Open();
    string studCount = "select COUNT(DISTINCT(student_id)) from feedback where subject_id=2";
    //string checkPasswordQuery = "select id from Students where email = '" + Session["CurrentUser"] + "' ";
    passComm = new SqlCommand(studCount, conn);
    String studC = passComm.ExecuteScalar().ToString().Replace(" ", "");
    conn.Close();
    Label4.Text = studC;
    ///////////
    try
    {
        string facNAme = "select DISTINCT(Faculties.name) from Faculties,feedback " +
                          " where feedback.faculty_id=Faculties.id AND subject_id='" + ddlSubject.SelectedItem.Value + "'";
        conn.Open();
        passComm = new SqlCommand(facNAme, conn);
        String fname = passComm.ExecuteScalar().ToString().Replace(" ", "");
        conn.Close();
        Label5.Text = fname;
    }
    catch(Exception)
    {}
}
}
 