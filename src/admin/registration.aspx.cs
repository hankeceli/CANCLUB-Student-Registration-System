using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    int temp = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = " select  count(*) from Students where email = '" + username.Text + "' ";
            SqlCommand com = new SqlCommand(checkuser, conn);
            temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                Response.Write("user already exists !!");
            }

          
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
            if (temp == 0)
            {
                try
                {
                    Guid newGUID = Guid.NewGuid();

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                    conn.Open();
                    string insertquery = " insert into Students(name,email,password,course_id,contactno,doj) values (@username,@email,@password,@course,@mobileno,@dateofjoining)";
                    SqlCommand com = new SqlCommand(insertquery, conn);

                    //com.Parameters.AddWithValue("@ID", newGUID.ToString());
                    com.Parameters.AddWithValue("@username", username.Text);
                    com.Parameters.AddWithValue("@email", email.Text);
                    com.Parameters.AddWithValue("@password", password.Text);
                    //com.Parameters.AddWithValue("@confirmpassword", Confirm Password.Text);
                    com.Parameters.AddWithValue("@course", DropDownListcourse.SelectedItem.Value);
                    com.Parameters.AddWithValue("@mobileno ", mobileno.Text);
                    com.Parameters.AddWithValue("@dateofjoining", dateofjoining.Text);
   //FLAG                 //com.Parameters.AddWithValue("@designation", DropDownListDesignation.SelectedItem.ToString());
                    //execute 
                    com.ExecuteNonQuery();
                    
                    //redirect to otherpage 
                    Response.Redirect("~/admin/admin.aspx");
                    
                     //some message
                    Response.Write("Registration Successful");

                    conn.Close();
                    //Response.Write(" You registration is sucessfully completed!!!");

                }
                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());
                }
            }
        }
        //Response.Write(" You registration is sucessfully completed!!!");

 }
