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

public partial class coordinator_viewsubject : System.Web.UI.Page
{
    //SqlConnection con;
    //SqlCommand cmd;
    //SqlDataAdapter da;
    //DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        //con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        //if (!IsPostBack)
        //{
        //    lblMessage1.Visible = false;
        //}

    }
    //protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {

    //        lblMessage1.Visible = true;
    //        branch();
    //        codesubject();
    //        GridView2.Visible = false;

    //        if (RadioButtonList2.SelectedItem.Text == "M.Tech(CST)")
    //        {
    //            lblMessage1.Visible = false;

    //            ArrayList year = new ArrayList();
    //            for (int i = 1; i <= 4; i++)
    //            {
    //                year.Add(i);
    //            }
    //            DDLYear.DataSource = year;
    //            DDLYear.DataBind();
    //            DDLYear.Items.Insert(0, new ListItem("Select", ""));

    //        }
    //        else if (RadioButtonList2.SelectedItem.Text == "M.Tech(CCT)")
    //        {
    //            lblMessage1.Visible = false;
    //            ArrayList year = new ArrayList();
    //            for (int i = 1; i <= 2; i++)
    //            {
    //                year.Add(i);
    //            }
    //            DDLYear.DataSource = year;
    //            DDLYear.DataBind();
    //            DDLYear.Items.Insert(0, new ListItem("Select", ""));
    //        }
    //        else if (RadioButtonList2.SelectedItem.Text == "MCA")
    //        {
    //            store();
    //            ArrayList year = new ArrayList();
    //            for (int i = 1; i <= 3; i++)
    //            {
    //                year.Add(i);
    //            }
    //            DDLYear.DataSource = year;
    //            DDLYear.DataBind();
    //            DDLYear.Items.Insert(0, new ListItem("Select", ""));
    //        }

    //        else
    //        {
    //            store();
    //            ArrayList year = new ArrayList();
    //            for (int i = 1; i <= 2; i++)
    //            {
    //                year.Add(i);
    //            }
    //            DDLYear.DataSource = year;
    //            DDLYear.DataBind();
    //            DDLYear.Items.Insert(0, new ListItem("Select", ""));
    //        }
    //        Clear();
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}

    //private void Clear()
    //{
    //    if (DDLSem.SelectedItem.Text != "Select" || DDLYear.SelectedItem.Text != "Select" || DDLBName.SelectedItem.Text != "select" || DDLSem0.SelectedItem.Text != "Select")
    //    {
    //        DDLSem.SelectedIndex = 0;
    //        DDLSem0.SelectedIndex = 0;
    //        DDLYear.SelectedIndex = 0;
    //        DDLBName.SelectedIndex = 0;
    //    }
    //}

    //private void store()
    //{
    //    try
    //    {
    //        lblMessage1.Visible = true;
    //        GridView2.Visible = true;
    //        da = new SqlDataAdapter("Select SubjectCode,SubjectName,BranchName,CoreSubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "'", con);
    //        con.Open();
    //        ds = new DataSet();
    //        da.Fill(ds, "Semester");
    //        DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //        if (data.Rows.Count == 0)
    //        {
    //            GridView2.Visible = false;
    //            lblMessage1.Text = "No Subjects found..";
    //        }
    //        else
    //        {

    //            int i = data.Rows.Count;
    //            lblMessage1.Text = i + "  Subject(s) found..";
    //            GridView2.DataSource = ds.Tables[0];
    //            GridView2.DataBind();
    //            con.Close();
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }

    //}

    //private void codesubject()
    //{
    //    try
    //    {

    //        da = new SqlDataAdapter("Select Distinct(codesubject) from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "'", con);
    //        con.Open();
    //        ds = new DataSet();
    //        da.Fill(ds, "Coursename");
    //        DDLSem0.DataTextField = "coresubject";
    //        DDLSem0.DataValueField = "coresubject";
    //        DDLSem0.DataSource = ds.Tables[0];
    //        DDLSem0.DataBind();
    //        DDLSem0.Items.Insert(0, new ListItem("Select", ""));
    //        con.Close();

    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}
    //private void branch()
    //{
    //    try
    //    {
    //        lblMessage1.Visible = true;

    //        if (RadioButtonList2.SelectedItem.Text == "B.Tech" || RadioButtonList2.SelectedItem.Text == "M.Tech")
    //        {
    //            DDLBName.Visible = true;
    //            lblBranch.Visible = false;
    //            da = new SqlDataAdapter("Select Distinct(BranchName) from Course_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "'", con);
    //            con.Open();
    //            ds = new DataSet();
    //            da.Fill(ds, "Coursename");
    //            DDLBName.DataTextField = "BranchName";
    //            DDLBName.DataValueField = "BranchName";
    //            DDLBName.DataSource = ds.Tables[0];
    //            DDLBName.DataBind();
    //            DDLBName.Items.Insert(0, new ListItem("Select", ""));
    //            con.Close();

    //        }
    //        else if (RadioButtonList2.SelectedItem.Text == "MCA")
    //        {
    //            DDLBName.Visible = false;
    //            lblBranch.Visible = true;
    //            lblBranch.Text = "MCA";
    //        }
    //        else
    //        {
    //            DDLBName.Visible = false;
    //            lblBranch.Visible = true;
    //            lblBranch.Text = "MBA";
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}
    //protected void DDLYear_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (RadioButtonList2.SelectedItem.Text == "MCA" || RadioButtonList2.SelectedItem.Text == "MSC")
    //        {
    //             GridView2.Visible = true;
    //            if (DDLSem0.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select core subject..";
    //            }
    //            else
    //            {
    //                da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + lblBranch.Text + "' and CoreSubject='" + DDLSem0.SelectedItem.Text + "' and Year='" + DDLYear.SelectedItem.Text + "'", con);
    //                con.Open();
    //                ds = new DataSet();
    //                da.Fill(ds, "Semester");
    //                DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //                if (data.Rows.Count == 0)
    //                {
    //                    GridView2.Visible = false;
    //                    lblMessage1.Text = "No Subjects found..";
    //                }
    //                else
    //                {

    //                    int i = data.Rows.Count;
    //                    lblMessage1.Text = i + "  Subject(s) found..";
    //                    GridView2.DataSource = ds.Tables[0];
    //                    GridView2.DataBind();
    //                    con.Close();
    //                }
    //            }
    //        }
    //        else
    //        {
    //            ArrayList sem = new ArrayList();
    //            if (RadioButtonList2.SelectedItem.Text == "M.Tech(CST)")
    //            {

    //                if (DDLYear.SelectedValue == "1")
    //                {
    //                    DDLSem.Visible = false;
    //                    Lblsem.Visible = false;

    //                }
    //                else
    //                {
    //                    DDLSem.Visible = true;
    //                    Lblsem.Visible = true;
    //                    for (int j = 1; j <= 2; j++)
    //                    {
    //                        sem.Add(j);

    //                    }
    //                    DDLSem.DataSource = sem;
    //                    DDLSem.DataBind();
    //                    DDLSem.Items.Insert(0, new ListItem("Select", ""));
    //                }

    //            }
    //            else
    //            {
    //                DDLSem.Visible = true;
    //                Lblsem.Visible = true;
    //                for (int j = 1; j <= 2; j++)
    //                {
    //                    sem.Add(j);

    //                }
    //                DDLSem.DataSource = sem;
    //                DDLSem.DataBind();
    //                DDLSem.Items.Insert(0, new ListItem("Select", ""));

    //            }
    //            store1();
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }

    //}

    //private void store1()
    //{
    //    try
    //    {
    //        lblMessage1.Visible = true;
    //        if (DDLBName.SelectedItem.Text == "Select")
    //        {
    //            GridView2.Visible = false;
    //            lblMessage1.Text = "Select Branch Name..";
    //        }
    //        else if (DDLSem0.SelectedItem.Text == "Select")
    //        {
    //            GridView2.Visible = false;
    //            lblMessage1.Text = "Select core subject..";
    //        }

    //        else
    //        {
    //            GridView2.Visible = true;
    //            da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + DDLBName.SelectedItem.Text + "' and Regulation='" + DDLSem0.SelectedItem.Text + "' and Year='" + DDLYear.SelectedItem.Text + "'", con);
    //            con.Open();
    //            ds = new DataSet();
    //            da.Fill(ds, "Semester");
    //            DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //            if (data.Rows.Count == 0)
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "No Subjects found..";
    //            }
    //            else
    //            {

    //                int i = data.Rows.Count;
    //                lblMessage1.Text = i + "  Subject(s) found..";
    //                GridView2.DataSource = ds.Tables[0];
    //                GridView2.DataBind();
    //                con.Close();
    //            }
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}
   
    //    protected void DDLBName_SelectedIndexChanged1(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        lblMessage1.Visible = true;
    //        DDLSem0.SelectedIndex = 0;
    //        DDLYear.SelectedIndex = 0;
    //        GridView2.Visible = true;
    //        da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + DDLBName.SelectedItem.Text + "'", con);
    //        con.Open();
    //        ds = new DataSet();
    //        da.Fill(ds, "Semester");
    //        DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //        if (data.Rows.Count == 0)
    //        {
    //            GridView2.Visible = false;
    //            lblMessage1.Text = "No Subjects found..";
    //        }
    //        else
    //        {

    //            int i = data.Rows.Count;
    //            lblMessage1.Text = i + "  Subject(s) found..";
    //            GridView2.DataSource = ds.Tables[0];
    //            GridView2.DataBind();
    //            con.Close();
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }

    //}
   
    // protected void DDLSem0_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        DDLYear.SelectedIndex = 0;
    //        if (RadioButtonList2.SelectedItem.Text == "MCA" || RadioButtonList2.SelectedItem.Text == "MSC")
    //        {
    //            GridView2.Visible = true;
    //            da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + lblBranch.Text + "' and Regulation='" + DDLSem0.SelectedItem.Text + "'", con);
    //            con.Open();
    //            ds = new DataSet();
    //            da.Fill(ds, "Semester");
    //            DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //            if (data.Rows.Count == 0)
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "No Subjects found..";
    //            }
    //            else
    //            {

    //                int i = data.Rows.Count;
    //                lblMessage1.Text = i + "  Subject(s) found..";
    //                GridView2.DataSource = ds.Tables[0];
    //                GridView2.DataBind();
    //                con.Close();
    //            }
    //        }
    //        else
    //        {

    //            if (DDLBName.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select Branch Name..";
    //            }
    //            else
    //            {
    //                GridView2.Visible = true;
    //                da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + DDLBName.SelectedItem.Text + "' and Regulation='" + DDLSem0.SelectedItem.Text + "'", con);
    //                con.Open();
    //                ds = new DataSet();
    //                da.Fill(ds, "Semester");
    //                DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //                if (data.Rows.Count == 0)
    //                {
    //                    GridView2.Visible = false;
    //                    lblMessage1.Text = "No Subjects found..";
    //                }
    //                else
    //                {

    //                    int i = data.Rows.Count;
    //                    lblMessage1.Text = i + "  Subject(s) found..";
    //                    GridView2.DataSource = ds.Tables[0];
    //                    GridView2.DataBind();
    //                    con.Close();
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}
    //protected void DDLSem_SelectedIndexChanged1(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (RadioButtonList2.SelectedItem.Text == "MCA" || RadioButtonList2.SelectedItem.Text == "MSC")
    //        {
    //            GridView2.Visible = true;
    //            if (DDLSem0.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select core subject..";
    //            }
    //            else if (DDLYear.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select Year..";
    //            }

    //            else
    //            {
    //                da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + lblBranch.Text + "' and Regulation='" + DDLSem0.SelectedItem.Text + "' and Year='" + DDLYear.SelectedItem.Text + "' and Semester='" + DDLSem.SelectedItem.Text + "'", con);
    //                con.Open();
    //                ds = new DataSet();
    //                da.Fill(ds, "Semester");
    //                DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //                if (data.Rows.Count == 0)
    //                {
    //                    GridView2.Visible = false;
    //                    lblMessage1.Text = "No Subjects found..";
    //                }
    //                else
    //                {

    //                    int i = data.Rows.Count;
    //                    lblMessage1.Text = i + "  Subject(s) found..";
    //                    GridView2.DataSource = ds.Tables[0];
    //                    GridView2.DataBind();
    //                    con.Close();
    //                }
    //            }
    //        }

    //        else
    //        {
    //            if (DDLSem0.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select Regulation..";
    //            }
    //            else if (DDLYear.SelectedItem.Text == "Select")
    //            {
    //                GridView2.Visible = false;
    //                lblMessage1.Text = "Select Year..";
    //            }
    //            else
    //            {
    //                GridView2.Visible = true;
    //                da = new SqlDataAdapter("Select SubjectCode,Subject,BranchName,codesubject from Subject_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "' and BranchName='" + DDLBName.SelectedItem.Text + "' and Regulation='" + DDLSem0.SelectedItem.Text + "' and Year='" + DDLYear.SelectedItem.Text + "' and Semester='" + DDLSem.SelectedItem.Text + "'", con);
    //                con.Open();
    //                ds = new DataSet();
    //                da.Fill(ds, "Semester");
    //                DataTable data = ds.Tables[0];// Utils.DataManager.ExecuteQuery(query);
    //                if (data.Rows.Count == 0)
    //                {
    //                    GridView2.Visible = false;
    //                    lblMessage1.Text = "No Subjects found..";
    //                }
    //                else
    //                {

    //                    int i = data.Rows.Count;
    //                    lblMessage1.Text = i + "  Subject(s) found..";
    //                    GridView2.DataSource = ds.Tables[0];
    //                    GridView2.DataBind();
    //                    con.Close();
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception e1)
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

    //    }
    //}
    //protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    string s1 = e.CommandName;
    //    if (s1 == "Delete")

    //        try
    //        {
    //            //if (MessageBox.Show("Are you sure ?", "Student FeedBack System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //            //{
    //            int i = Convert.ToInt32(e.CommandArgument.ToString());
    //            con.Close();
    //            string s =  GridView2.Rows[i].Cells[1].Text;
    //            string s5 = GridView2.Rows[i].Cells[2].Text;
    //            string s6 = GridView2.Rows[i].Cells[3].Text;
    //            string s7 = GridView2.Rows[i].Cells[4].Text;
    //            cmd = new SqlCommand("delete from Subject_Details where SubjectCode='" + s + "' and Subject='" + s5 + "' and BranchName='" + s6 + "' and coresubject='" + s7 + "'", con);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //            con.Close();
    //            store();
    //            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Successfully Deleted')", true);

    //            //MessageBox.Show("Successfully Deleted", "Student FeedBack System", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            // }

    //        }
    //        catch (Exception e1)
    //        {
    //            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);
    //        }

    //}

    //protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
}