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

public partial class admin_FacultyRegistration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    public string s3;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        lblDept.Visible = false;
        if (!IsPostBack)
        {


            facultyId();
        }
    }

    private void facultyId()
    {
        try
        {
            cmd = new SqlCommand("select max(id) from Faculties", con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            if (s == "")
            {
                s3 = "1";
            }
            /*else
            {
                string s1 = s.Substring(0, 3);
                string s2 = s.Substring(3);
                int i = Convert.ToInt32(s2);
                i = i + 1;
                s3 = s1 + i.ToString();

            }*/

            con.Close();
        }
        catch (Exception e1)
        {
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

        }


    }
    protected void Save_Click(object sender, EventArgs e)
    {
        try
        {
            SqlDataReader dr;
            con.Close();
            

            cmd = new SqlCommand("Select name from Faculties where course_id='" + RadioButtonList2.SelectedItem.Value  + "' and name='" + TBName.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Already Existed Plz Change Name')", true);

            }
            else
            {
                con.Close();
                
                String insertQuery = "insert into Faculties values('" + TBName.Text + "','" + TBEmailId.Text + "','" + password.Text + "','" + TBMobile.Text + "','" + TBAddress.Text + "','" + TBRemarks.Text + "','" + RadioButtonList2.SelectedItem.Value + "')";
                cmd = new SqlCommand(insertQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                reset();
                con.Close();
                facultyId();
                store();
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Registered Successfully')", true);
            }
        }
        catch (Exception e1)
        {
            // ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Already Existed Plz Change Name')", true);


        }
    
    }

    private void reset()
    {
        TBName.Text = "";
        TBAddress.Text = "";
        TBEmailId.Text = "";
        TBMobile.Text = "";
        TBRemarks.Text = "";
    }
    

    private void facdetails()
    {
        lblMessage1.Visible = true;
        GridView5.Visible = true;
        da = new SqlDataAdapter("Select FacultyName,CourseName,Department,Address,EmailId,Mobile,Remarks from Faculty_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "'", con);
        con.Open();
        ds = new DataSet();
        da.Fill(ds, "Semister");
        da.Fill(ds, "courses");
        DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
        if (data.Rows.Count == 0)
        {
            GridView5.Visible = false;
            lblMessage1.Text = "No Members found..";
        }
        else
        {

            int i = data.Rows.Count;
            lblMessage1.Text = i + "  Member(s) found..";
            GridView5.DataSource = ds.Tables[0];
            GridView5.DataBind();
            con.Close();
        }
    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        DDLDept.Visible = true;
        RadioButtonList2.ClearSelection();
        reset();
    }
    protected void DDLDept_SelectedIndexChanged(object sender, EventArgs e)
    {
        //store();
    }

    private void store()
    {
        lblMessage1.Visible = true;
        GridView5.Visible = true;
        da = new SqlDataAdapter("Select FacultyName,CourseName,Department,Address,EmailId,Mobile,Remarks from Faculty_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and Department='" + DDLDept.SelectedItem.Text + "'", con);
        con.Open();
        ds = new DataSet();
        da.Fill(ds, "Semester");
        da.Fill(ds, "courses");
        DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
        if (data.Rows.Count == 0)
        {
            GridView5.Visible = false;
            lblMessage1.Text = "No Members found..";
        }
        else
        {

            int i = data.Rows.Count;
            lblMessage1.Text = i + "  Member(s) found..";
            GridView5.DataSource = ds.Tables[0];
            GridView5.DataBind();
            con.Close();
        }
    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        try
        {
            string s1 = e.CommandName;
            if (s1 == "Delete")
            {
                int i = Convert.ToInt32(e.CommandArgument.ToString());
                con.Close();
                string s = GridView5.Rows[i].Cells[1].Text;
                string s5 = GridView5.Rows[i].Cells[3].Text;
                cmd = new SqlCommand("delete from Faculties where name='" + s + "' and Department='" + s5 + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                store();
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Successfully Deleted')", true);
            }
        }
        catch (Exception e1)
        {
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);
        }
    }


    protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView5_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView5.Rows[e.RowIndex];
        //Label lbldeleteid = (Label)row.FindControl("lblID");
        con.Open();
        SqlCommand cmd1 = new SqlCommand("delete FROM feedback where email='" + row.Cells[2].Text + "'", con);
        cmd1.ExecuteNonQuery();
        SqlCommand cmd2 = new SqlCommand("delete FROM Faculties where email='" + row.Cells[2].Text + "'", con);
        cmd2.ExecuteNonQuery();
        con.Close();
        gvbind();

    }
    protected void gvbind()
    {
        con.Open();
        String sqlQuery = "Select Faculties.name,Faculties.email,Faculties.password,Courses.name,Faculties.mobile"+
                            ",Faculties.address,Faculties.remark from Faculties,Courses"+
                            " WHERE Faculties.course_id=Courses.id";
        SqlCommand cmd = new SqlCommand(sqlQuery, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView5.DataSource = ds;
            GridView5.DataBind();
        }
        else
        {
            ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            GridView5.DataSource = ds;
            GridView5.DataBind();
            int columncount = GridView5.Rows[0].Cells.Count;
            GridView5.Rows[0].Cells.Clear();
            GridView5.Rows[0].Cells.Add(new TableCell());
            GridView5.Rows[0].Cells[0].ColumnSpan = columncount;
            GridView5.Rows[0].Cells[0].Text = "No Records Found";
        }

    }
    protected void GridView5_RowEditing(object sender, GridViewEditEventArgs e)
    { }
    protected void GridView5_RowUpdating(object sender, GridViewUpdateEventArgs e)
    { }
    protected void GridView5_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    { }
}