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
using System.Text;
using System.Collections.Generic;


public partial class student_FeedBack : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataReader dr;
    SqlDataAdapter da;
    SqlDataAdapter da1;
    public DataSet ds1 = null;
    DataSet ds;
    public int count;
    string at;
    string at1;
    int at2;
    int at3;
    string at4;
    string at5;
    string ay;
    string dept;
    public int pos;
    public int cnt = 0;
    public String semesterid="2";
    public String feedback_month;
    string studid = "";
    List<string> subjects = new List<string>();
    List<string> subjectids = new List<string>();
    List<string> faculties = new List<string>();
    List<string> facultyids = new List<string>();
    List<string> feedbackids = new List<string>();
    List<string> questionids = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {

        //subjects.Clear();
        //subjectids.Clear();
        //faculties.Clear();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        semesterid = Request.QueryString["semid"];
        feedback_month = Request.QueryString["feedbackmonth"];
        //Get User Id
        conn.Open();
        string checkPasswordQuery = "select id from Students where email = '" + Session["CurrentUser"] + "' ";
        SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
        studid = passComm.ExecuteScalar().ToString().Replace(" ", "");
        conn.Close();
        ////////////
        
        conn.Open();
        string checkuser = " Select COUNT(*) FROM feedback WHERE student_id='" + studid + "' AND sem_id='" + semesterid + "' AND feedback_month='" + feedback_month + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp != 0)
        {
            Response.Write("Data already exists !!");
            Response.Redirect("selectMonth.aspx?semid=" + semesterid);
        }
       
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        con.Open();
        String query = "Select Subjects.name, Faculties.name,Faculties.id,Subjects.id from Subjects,Faculties,subject_faculty" +
                        " WHERE subject_faculty.faculty_id=Faculties.id AND subject_faculty.sub_id=Subjects.id" +
                        " AND Subjects.semester_id='" + semesterid + "'";//get semester id to be done
        passComm = new SqlCommand(query, con);
        using (SqlDataReader reader = passComm.ExecuteReader())
        {
            while (reader.Read())
            {
                subjects.Add(reader.GetString(0));
                faculties.Add(reader.GetString(1));
                subjectids.Add(reader.GetInt32(3).ToString());
                facultyids.Add(reader.GetInt32(2).ToString());
            }
            reader.Close();
        }
        String query1 = "select id, questions.Details from questions;";
        SqlCommand queComm = new SqlCommand(query1, con);
        using (SqlDataReader reader = queComm.ExecuteReader())
        {
            while (reader.Read())
            {
                questionids.Add(reader.GetInt32(0).ToString());

            }
            reader.Close();
        }
        con.Close();
        if (!IsPostBack)
        {
            
            Label12.Text = subjects[0];
            /*con.Open();
            String test123 = " select count(*) from feedbackeligible,Students where Students.id=feedbackeligible.student_id AND subject_id=" + subjectids[0] + " ANd Students.email='" + Session["CurrentUser"] + "'";
            SqlCommand com = new SqlCommand(test123, con);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 0)
            {
                //GridView2.FindControl("DropDownList2").EnableViewState = false;
            }
            con.Close();*/
            Label14.Text = subjects[1];
            con.Open();
            checkuser = " select count(*) from feedbackeligible,Students where Students.id=feedbackeligible.student_id AND subject_id=" + subjectids[1] + " ANd Students.email='" + Session["CurrentUser"] + "'";
            com = new SqlCommand(checkuser, con);
            temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 0)
            {
                //DropDownList test = (DropDownList)GridView2.FindControl("DropDownList2");
                //test.Enabled = false;
            }
            con.Close();
            Label16.Text = subjects[2];
            con.Open();
            checkuser = " select count(*) from feedbackeligible,Students where Students.id=feedbackeligible.student_id AND subject_id=" + subjectids[2] + " ANd Students.email='" + Session["CurrentUser"] + "'";
            com = new SqlCommand(checkuser, con);
            temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 0)
            {
                //DropDownList test = (DropDownList)GridView2.FindControl("DropDownList4");
                //test.Enabled = false;

            }
            con.Close();
            Label18.Text = subjects[3];
            con.Open();
            checkuser = " select count(*) from feedbackeligible,Students where Students.id=feedbackeligible.student_id AND subject_id=" + subjectids[3] + " ANd Students.email='" + Session["CurrentUser"] + "'";
            com = new SqlCommand(checkuser, con);
            temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 0)
            {
                //DropDownList test = (DropDownList)GridView2.FindControl("DropDownList4");
                //test.Enabled = false;
            }
            con.Close();
            Label13.Text = faculties[0];
            Label15.Text = faculties[1];
            Label17.Text = faculties[2];
            Label19.Text = faculties[3];
            //string username = passComm.ExecuteScalar().ToString().Replace(" ", "");
            //string password = passComm.ExecuteScalar().ToString().Replace(" ", "");

            SqlDataSource SqlDataSource1 = new SqlDataSource();
            SqlDataSource1.ID = "SqlDataSource1";
            this.Page.Controls.Add(SqlDataSource1);
            SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
            SqlDataSource1.SelectCommand = "select questions.Details from questions;";
            GridView2.DataSource = SqlDataSource1;
            GridView2.DataBind();
        }
    }
    private void FacultyDetails1()
    {
        try
        {
            da1 = new SqlDataAdapter("Select FacultyName,Subject,Department from Assigned_Details Where Branch_Name='" + Session["BranchName"].ToString() + "' and Year='" + Session["Year"].ToString() + "' and Semester='" + Session["Semester"].ToString() + "' and Section='" + Session["Section"] + "' and CourseName='" + Session["CourseName"] + "' and AcademicYear='" + at5 + "'", con);
            ds1 = new DataSet();
            da1.Fill(ds1, "question");
        }

        catch
        {
        }
    }
    private void FacultyDetails()
    {
        try
        {
            da1 = new SqlDataAdapter("Select FacultyName,Subject,Department from Assigned_Details Where Branch_Name='" + Session["BranchName"].ToString() + "' and Year='" + Session["Year"].ToString() + "'and semester='" + Session["Semester"].ToString() + "' and Section='" + Session["Section"] + "' and CourseName='" + Session["CourseName"] + "' and AcademicYear='" + at5 + "'", con);
            ds1 = new DataSet();
            da1.Fill(ds1, "Faculty");
            cnt = ds1.Tables[0].Rows.Count;
            Session["cnt"] = cnt;
            if (cnt == 0)
            {
                Panel1.Visible = false;
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Temporarely Data Unavailable')", true);
            }
            else
            {
                ButtNext.Visible = true;
                //Label4.Visible = true;
                LblFName.Visible = true;
                LblFName.Text = ds1.Tables[0].Rows[0][0].ToString();
                LblSubj.Text = ds1.Tables[0].Rows[0][1].ToString();
            }

        }
        catch (Exception)
        {


        }
    }
    private void studentdetails()
    {
        try
        {
            cmd = new SqlCommand("Select StudentId from Feedback_Details where StudentId='" + Session["CurrentUser"].ToString() + "' and BranchName='" + Session["BranchName"].ToString() + "' and Year='" + Session["Year"].ToString() + "' and Semester='" + Session["Semester"].ToString() + "' and Section='" + Session["Section"].ToString() + "' and CourseName='" + Session["CourseName"].ToString() + "' and AcademicYear='" + at5 + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Panel1.Visible = false;
                ButtNext.Visible = false;
                Label3.Text = "You are Allready Submitted";
            }
            else
            {
                Panel1.Visible = true;
                ButtNext.Visible = true;
            }
            dr.Close();

        }
        catch (Exception)
        {


        }
    }

    private void questions1()
    {
        try
        {
            da = new SqlDataAdapter("Select Question from Question_Details", con);
            ds = new DataSet();
            da.Fill(ds, "question");
            if (!IsPostBack)
            {
                //GridView2.DataSource = ds.Tables[0];
               // GridView2.DataBind();
            }

        }
        catch (Exception)
        {


        }
    }
    public void loadfaculty(int pos1)
    {
        try
        {
            LblFName.Text = ds1.Tables[0].Rows[pos1][0].ToString();
            LblSubj.Text = ds1.Tables[0].Rows[pos1][1].ToString();

        }
        catch (Exception)
        {


        }
    }





    protected void ButtNext_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            for (int i = 0; i < subjectids.Count; i++)
            {
                String insertQuery = "insert into feedback values('" + studid + "','" + subjectids[i] + "','" + facultyids[i] + "','" + semesterid + "','" + feedback_month + "')";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                String selectQuery1 = "SELECT MAX(id) FROM feedback";
                SqlCommand fComm = new SqlCommand(selectQuery1, con);
                string feedbackid = fComm.ExecuteScalar().ToString().Replace(" ", "");
                feedbackids.Add(feedbackid);
            }
            con.Close();
            //////////
            /*con.Open();
            String selectQuery1 = "SELECT MAX(id) FROM feedback";
            SqlCommand fComm = new SqlCommand(selectQuery1, con);
            string feedbackid = passComm.ExecuteScalar().ToString().Replace(" ", "");
            con.Close();*/
            //////////
            int tempCount = 0;
            
            con.Open();
            foreach (GridViewRow row in GridView2.Rows)
            {
               
                string dropDownListText2 = ((DropDownList)row.FindControl("DropDownList2")).SelectedItem.Value;               
                String insertQuery = "insert into feedback_details values('" + feedbackids[0] + "','" + questionids[tempCount] + "','" + dropDownListText2 + "')";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();

                string dropDownListText3 = ((DropDownList)
                row.FindControl("DropDownList3")).SelectedItem.Value;
                insertQuery = "insert into feedback_details values('" + feedbackids[1] + "','" + questionids[tempCount] + "','" + dropDownListText3 + "')";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                
                string dropDownListText4 = ((DropDownList)
                row.FindControl("DropDownList4")).SelectedItem.Value;
                insertQuery = "insert into feedback_details values('" + feedbackids[2] + "','" + questionids[tempCount] + "','" + dropDownListText4 + "')";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                
                string dropDownListText5 = ((DropDownList)
                row.FindControl("DropDownList5")).SelectedItem.Value;
                insertQuery = "insert into feedback_details values('" + feedbackids[3] + "','" + questionids[tempCount] + "','" + dropDownListText5 + "')";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                
                tempCount++;
            }
            con.Close();
        }
        catch (Exception e8)
        {
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert(" + e8.Message + ")", true);
        }
            }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
