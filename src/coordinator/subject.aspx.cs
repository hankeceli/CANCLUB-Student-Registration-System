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

public partial class coordinator_subject : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        if (!IsPostBack)
        {
            RequiredFieldValidator25.Visible = false;
            lblBranch.Visible = false;
        }
    }

    
    
    
    protected void ButtSave_Click(object sender, EventArgs e)
    {
        try
        {
            /*if (RadioButtonList2.SelectedItem.Text == "M.Tech(CST)")
            {
                if (DDLYear.SelectedValue == "1")
                {
                    string CName = RadioButtonList2.SelectedItem.Text;
                    cmd = new SqlCommand("insert into Subject_Details values('" + TBSCode.Text + "','" + TBSName.Text + "','" + CName + "','" + DDLYear.SelectedItem.Text + "','" + DDLSem.Text + "','" + DDLBName.SelectedItem.Text + "','" + DDLSem0.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    TBSName.Text = "";
                    TBSCode.Text = "";
                    ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);
 
                }
                else
                {
                    string CName = RadioButtonList2.SelectedItem.Text;
                    cmd = new SqlCommand("insert into Subject_Details values('" + TBSCode.Text + "','" + TBSName.Text + "','" + CName + "','" + DDLYear.SelectedItem.Text + "','" + DDLSem.Text + "','" + DDLBName.SelectedItem.Text + "','" + DDLSem0.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    TBSName.Text = "";
                    TBSCode.Text = "";
                    ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);

                }
            }
            else if(RadioButtonList2.SelectedItem.Text=="M.Tech(CCT)")
            {
                string CName = RadioButtonList2.SelectedItem.Text;
                cmd = new SqlCommand("insert into Subject_Details values('" + TBSCode.Text + "','" + TBSName.Text + "','" + CName + "','" + DDLYear.SelectedItem.Text + "','" + DDLSem.Text + "','" + DDLBName.SelectedItem.Text + "','" + DDLSem0.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                TBSName.Text = "";
                TBSCode.Text = "";
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);

            }
            
           else
            {
                string CName1 = RadioButtonList2.SelectedItem.Text;
                cmd = new SqlCommand("insert into Subject_Details values('" + TBSCode.Text + "','" + TBSName.Text + "','" + CName1 + "','" + DDLYear.SelectedItem.Text + "','" + DDLSem.Text + "','" + lblBranch.Text + "','" + DDLSem0.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                TBSName.Text = "";
                TBSCode.Text = "";
                ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);

            }*/
            //string CName1 = RadioButtonList2.SelectedItem.Value;
            String insertQuery = "insert into Subjects values('" + TBSName.Text + "','" + TBSCode.Text + "','" + RadioButtonList2.SelectedItem.Value + "','" + DDLSem.SelectedItem.Value +  "')";
            cmd = new SqlCommand(insertQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            TBSName.Text = "";
            TBSCode.Text = "";
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Added Successfully...')", true);


        }
        catch (Exception e1)
        {
            ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Code is Already Existed...')", true);

            // MessageBox.Show("Code is Already Existed", "Student Feedack System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

    /*protected void DDLYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArrayList sem = new ArrayList();
        if (RadioButtonList2.SelectedItem.Text == "B.Tech")
        {

            if (DDLYear.SelectedValue == "1")
            {
                DDLSem.Visible = false;
                Lblsem.Visible = false;

            }
            else
            {
                DDLSem.Visible = true;
                Lblsem.Visible = true;
                for (int j = 1; j <= 2; j++)
                {
                    sem.Add(j);

                }
                DDLSem.DataSource = sem;
                DDLSem.DataBind();
                DDLSem.Items.Insert(0, new ListItem("Select", ""));
            }

        }
        else
        {
            DDLSem.Visible = true;
            Lblsem.Visible = true;
            for (int j = 1; j <= 2; j++)
            {
                sem.Add(j);

            }
            DDLSem.DataSource = sem;
            DDLSem.DataBind();
            DDLSem.Items.Insert(0, new ListItem("Select", ""));

        }
    }*/
    
     protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
     {
         try
         {
             Semester();
             //branch();
             /*if (RadioButtonList2.SelectedItem.Text == "M.Tech(CST)")
             {
                 RequiredFieldValidator25.Visible = true;
                 ArrayList year = new ArrayList();
                 for (int i = 1; i <= 2; i++)
                 {
                     year.Add(i);
                 }
                 DDLYear.DataSource = year;
                 DDLYear.DataBind();
                 DDLYear.Items.Insert(0, new ListItem("Select", ""));

             }
             else if (RadioButtonList2.SelectedItem.Text == "M.Tech(CCT)")
             {
                 RequiredFieldValidator25.Visible = true;
                 ArrayList year = new ArrayList();
                 for (int i = 1; i <= 2; i++)
                 {
                     year.Add(i);
                 }
                 DDLYear.DataSource = year;
                 DDLYear.DataBind();
                 DDLYear.Items.Insert(0, new ListItem("Select", ""));
             }
             else if (RadioButtonList2.SelectedItem.Text == "MCA")
             {
                 RequiredFieldValidator25.Visible = false;
                 ArrayList year = new ArrayList();
                 for (int i = 1; i <= 3; i++)
                 {
                     year.Add(i);
                 }
                 DDLYear.DataSource = year;
                 DDLYear.DataBind();
                 DDLYear.Items.Insert(0, new ListItem("Select", ""));
             }

             else
             {
                 RequiredFieldValidator25.Visible = false;
                 ArrayList year = new ArrayList();
                 for (int i = 1; i <= 2; i++)
                 {
                     year.Add(i);
                 }
                 DDLYear.DataSource = year;
                 DDLYear.DataBind();
                 DDLYear.Items.Insert(0, new ListItem("Select", ""));
             }*/

         }
         catch (Exception e1)
         {
             ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

         }
        
     }
     private void Semester()
     {
         String selectQuery = "Select id, name from Semesters where course_id='" + RadioButtonList2.SelectedItem.Value + "'";
         SqlCommand cmd = new SqlCommand(selectQuery);
         
             cmd.CommandType = CommandType.Text;
             cmd.Connection = con;
             con.Open();
             DDLSem.DataSource = cmd.ExecuteReader();
             DDLSem.DataTextField = "name";
             DDLSem.DataValueField = "id";
             DDLSem.DataBind();
             con.Close();
         
     }
     private void branch()
     {

         try
         {
             if (RadioButtonList2.SelectedItem.Text == "M.Tech(CST)" || RadioButtonList2.SelectedItem.Text == "M.Tech(CCT)")
             {
                 DDLBName.Visible = true;
                 lblBranch.Visible = false;
                 da = new SqlDataAdapter("Select Distinct(BranchName) from Course_Details where CourseName='" + RadioButtonList2.SelectedItem.Text + "'", con);
                 con.Open();
                 ds = new DataSet();
                 da.Fill(ds, "Coursename");
                 DDLBName.DataTextField = "BranchName";
                 DDLBName.DataValueField = "BranchName";
                 DDLBName.DataSource = ds.Tables[0];
                 DDLBName.DataBind();
                 DDLBName.Items.Insert(0, new ListItem("Select", ""));
                 con.Close();

             }
             else if (RadioButtonList2.SelectedItem.Text == "MCA")
             {
                 DDLBName.Visible = false;
                 lblBranch.Visible = true;
                 lblBranch.Text = "MCA";
             }
             else
             {
                 DDLBName.Visible = false;
                 lblBranch.Visible = true;
                 lblBranch.Text = "MSC";
             }
         }
         catch (Exception e1)
         {

             ClientScript.RegisterStartupScript(GetType(), "Onload", "alert('Abnormal Termination')", true);

         }
     }


     protected void ButtReset_Click(object sender, EventArgs e)
     {
         reset();
     }
     private void reset()
     {
         DDLSem0.Text = "";
         TBSName.Text = "";
         TBSCode.Text = "";
         DDLBName.SelectedIndex = 0;
         DDLSem.SelectedIndex = 0;
         DDLYear.SelectedIndex = 0;
         RadioButtonList2.ClearSelection();
     }

     protected void LinkButton12_Click(object sender, EventArgs e)
     {
         Response.Redirect("~/coordinator/viewsubject.aspx");
     }
    
}

 