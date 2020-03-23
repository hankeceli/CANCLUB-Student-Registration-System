using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/registration.aspx");
    }
    //protected void Cancel_Click(object sender, EventArgs e)
    //{
    //    Cancel_Click

    //}

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    dim  
    //}
}