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
            
        }

    }

   
  
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        String selectQuery = "Select id, name from Semesters where course_id='" + RadioButtonList1  .SelectedItem.Value + "'";
        SqlCommand cmd = new SqlCommand(selectQuery);

        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        DDLSemester.DataSource = cmd.ExecuteReader();
        DDLSemester.DataTextField = "name";
        DDLSemester.DataValueField = "id";
        DDLSemester.DataBind();
        con.Close();

        selectQuery = "Select id, name from Faculties where course_id='" + RadioButtonList1.SelectedItem.Value + "'";
        cmd = new SqlCommand(selectQuery);

        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        DDLFName.DataSource = cmd.ExecuteReader();
        DDLFName.DataTextField = "name";
        DDLFName.DataValueField = "id";
        DDLFName.DataBind();
        con.Close();

    }

  
   


    protected void DDLSemester_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            String selectQuery = "Select id, name from subjects where course_id='" + RadioButtonList1.SelectedItem.Value + "' AND semester_id='"+DDLSemester.SelectedItem.Value+"'";
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
            string checkuser = " select  count(*) from subject_faculty where sub_id = '" + DDLSubject.SelectedItem.Value + "' AND  faculty_id='" + DDLFName.SelectedItem.Value+"'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                Response.Write("Data already exists !!");
                return;
            }

            String insertQuery = "insert into subject_faculty values('" + DDLSubject.SelectedItem.Value + "','" + DDLFName.SelectedItem.Value + "')";
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
   
    
   
    protected void DDLSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DDLYear.SelectedIndex = 0;

    }
    /*protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string s1 = e.CommandName;
        if (s1 == "Delete")
            try
            {
                int i = Convert.ToInt32(e.CommandArgument.ToString());
                con.Close();
                string s = GridView1.Rows[i].Cells[1].Text;
                string d = GridView1.Rows[i].Cells[2].Text;
                cmd = new SqlCommand("delete from Assigned_Details where FacultyName='" + s + "' and Department='"+ d +"' and AcademicYear='"+ DDLYear0.SelectedItem.Text +"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Successfully Deleted')", true);
                if (RadioButtonList1.SelectedItem.Text == "B.Tech")
                {
                    if (DDLYear.SelectedValue == "1")
                    {
                        View1();
                    }
                    else
                    {
                        View2();
                    }
                }
                else
                {
                    View2();
                }

            }
            catch (Exception e1)
            {


                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);
            }
    }*/
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
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}
