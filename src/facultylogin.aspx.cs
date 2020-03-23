using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class login:System.Web.UI.Page
{
     int temp = 0;
    //SqlCommand cmd;
    //SqlConnection con;
    //SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        //con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
    }
    protected void Login_Button_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = " select count(*) from Faculties where email = '" + lusername.Text + "' ";
        SqlCommand com = new SqlCommand(checkuser, conn);
        temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            //verfifing user name and password
            conn.Open();
            string checkPasswordQuery = "select password from Faculties where email = '" + lusername.Text + "' ";
            SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
            string username = passComm.ExecuteScalar().ToString().Replace(" ", "");
            string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
            //validating the password
            /*if (lusername.Text == "admin" && lpassword.Text == "admin")
            {
                Session["CurrentUser"] = lusername.Text;
                Response.Redirect("admin/Home.aspx");
            }
            else if (lusername.Text == "coordinator" && lpassword.Text == "coordinator")
            {
                Session["CurrentUser"] = lusername.Text;

                Response.Redirect("coordinator/Home1.aspx");
            }*/
            //else
            //{
            //    //lusername.Text = "faculty";
            //    //lpassword.Text = "faculty";
            //    //Response.Redirect("~/faculty/Home1.aspx");
            //}

            if (password == lpassword.Text)
            {
                //creating the session with username

                Session["CurrentUser"] = lusername.Text;
                Response.Write("password is correct!");
                Response.Redirect("~/faculty/Home.aspx");
            }
            else
            {
                Response.Write("password is not correct!");
            }

        }
        else
        {
            Response.Write("username is not correct!");
        }

    }
    
}