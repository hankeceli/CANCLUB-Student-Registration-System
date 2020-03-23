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

public partial class Administrator_AssignSubject : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
  

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        if (!IsPostBack)
        {
           
            //GridView1.Visible = false;

           /* String selectQuery = "Select id, name from Semesters where course_id='" + RadioButtonList1.SelectedItem.Value + "'";
            SqlCommand cmd = new SqlCommand(selectQuery);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            RadioButtonList1.DataSource = cmd.ExecuteReader();
            RadioButtonList1.DataTextField = "name";
            RadioButtonList1.DataValueField = "id";
            DDLSemester.DataBind();
            con.Close();*/
            
            SqlDataSource SqlDataSource1 = new SqlDataSource();
            SqlDataSource1.ID = "SqlDataSource1";
            this.Page.Controls.Add(SqlDataSource1);
            SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
            String selectQuery = "Select Courses.name,Semesters.name, Subjects.name, Students.name"+
                                " FROM Courses,Semesters,Subjects,Students,feedbackeligible, Faculties"+
                                " WHERE feedbackeligible.subject_id=Subjects.id"+
                                " AND feedbackeligible.student_id=Students.id"+
                                " AND feedbackeligible.faculty_id=Faculties.id"+
                                " AND Subjects.course_id=Courses.id"+
                                " AND Subjects.semester_id=Semesters.id"+
                                " AND Faculties.email='" + Session["CurrentUser"]+"'";
            SqlDataSource1.SelectCommand = selectQuery;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

    }

   
  
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String selectQuery = "Select DISTINCT Semesters.name, Semesters.id from Semesters,subject_faculty,Subjects,Faculties  where subject_faculty.faculty_id=Faculties.id AND subject_faculty.sub_id=Subjects.id AND Semesters.id=Subjects.semester_id AND Faculties.email='" + Session["CurrentUser"] + "'";
        //String selectQuery = "Select id, name from Semesters where course_id='" + RadioButtonList1  .SelectedItem.Value + "'";
        SqlCommand cmd = new SqlCommand(selectQuery);

        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        DDLSemester.DataSource = cmd.ExecuteReader();
        DDLSemester.DataTextField = "name";
        DDLSemester.DataValueField = "id";
        DDLSemester.DataBind();
        con.Close();

        selectQuery = "Select id, name from Students where course_id='" + RadioButtonList1.SelectedItem.Value + "'";
        cmd = new SqlCommand(selectQuery);

        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        DDLFName.DataSource = cmd.ExecuteReader();
        DDLFName.DataTextField = "name";
        DDLFName.DataValueField = "id";
        DDLFName.DataBind();
        con.Close();

         //selectQuery = "Select id, name from Subjects where course_id='" + RadioButtonList1.SelectedItem.Value + "' AND semester_id='"+DDLSemester.Items[0].Value+"'";
          selectQuery = "Select DISTINCT Subjects.name, Subjects.id from Courses,subject_faculty,Subjects,Faculties,Semesters" +
 " where subject_faculty.faculty_id=Faculties.id AND subject_faculty.sub_id=Subjects.id AND Courses.id=Subjects.course_id AND Subjects.semester_id=Semesters.id" +
 " AND Faculties.email='" + Session["CurrentUser"] + "' AND Courses.id=" + RadioButtonList1.SelectedItem.Value + " And Semesters.id=" + DDLSemester.SelectedItem.Value;
        cmd = new SqlCommand(selectQuery);

        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        DDLSubject.DataSource = cmd.ExecuteReader();
        DDLSubject.DataTextField = "name";
        DDLSubject.DataValueField = "id";
        DDLSubject.DataBind();
        con.Close();

    }

  
   


    protected void DDLSemester_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            String selectQuery = "Select DISTINCT Subjects.name, Subjects.id from Courses,subject_faculty,Subjects,Faculties,Semesters"+
" where subject_faculty.faculty_id=Faculties.id AND subject_faculty.sub_id=Subjects.id AND Courses.id=Subjects.course_id AND Subjects.semester_id=Semesters.id"+
" AND Faculties.email='" + Session["CurrentUser"] + "' AND Courses.id=" + RadioButtonList1.SelectedItem.Value + " And Semesters.id=" + DDLSemester.SelectedItem.Value;
            //String selectQuery = "Select id, name from subjects where course_id='" + RadioButtonList1.SelectedItem.Value + "' AND semester_id='"+DDLSemester.SelectedItem.Value+"'";
            SqlCommand cmd = new SqlCommand(selectQuery);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            DDLSubject.DataSource = cmd.ExecuteReader();
            DDLSubject.DataTextField = "name";
            DDLSubject.DataValueField = "id";
            DDLSubject.DataBind();
            con.Close();       
        }

        catch (Exception e1)
        {
            string er = e1.Message;

            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('" + er + "')", true);
        }

    }
    


    protected void ButtSave_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string getFacIdQuery = "select id from Faculties where email = '" + Session["CurrentUser"] + "' ";
            SqlCommand passComm = new SqlCommand(getFacIdQuery, conn);
            string fid = passComm.ExecuteScalar().ToString().Replace(" ", "");
            string password = passComm.ExecuteScalar().ToString().Replace(" ", "");

            string checkuser = " select  count(*) from feedbackeligible where subject_id = '" + DDLSubject.SelectedItem.Value + "' AND  student_id='" + DDLFName.SelectedItem.Value + "' AND faculty_id=" + fid;
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                Response.Write("Data already exists !!");
                return;
            }
            

            String insertQuery = "insert into feedbackeligible values('" + DDLFName.SelectedItem.Value + "','" + DDLSubject.SelectedItem.Value + "','"+fid+ "')";
            cmd = new SqlCommand(insertQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);
        }
      
        catch (Exception e1)
        {

            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);
  
            // MessageBox.Show("Abnormal Termination", "student FeedBack System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
    protected void ButtReset_Click(object sender, EventArgs e)
    {
        //DDLBName.Visible = false;
        //Label49.Visible = false;
        //lblBranch.Visible = false;
        RadioButtonList1.ClearSelection();
        //DDLBName.SelectedIndex = 0;
        //DDLYear0.SelectedIndex = 0;
        //DDLDept.SelectedIndex = 0;
        DDLFName.SelectedIndex = 0;
        //DDLReg.SelectedIndex = 0;
        //DDLSection.SelectedIndex = 0;
        DDLSemester.SelectedIndex = 0;
        DDLSubject.SelectedIndex = 0;
        //DDLYear.SelectedIndex = 0;
       
    }
   
    
   
    
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void DDLAYear_SelectedIndexChanged(object sender, EventArgs e)
    {
       // Section();
    }
    protected void DDLYear0_SelectedIndexChanged(object sender, EventArgs e)
    {
       // branch();
    }
    protected void DDLSubject_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DDLSemester_TextChanged(object sender, EventArgs e)
    {
        
    }
}
