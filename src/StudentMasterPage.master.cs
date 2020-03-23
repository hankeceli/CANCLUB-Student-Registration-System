using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser"] == null)
            Response.Redirect("~/default.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/default.aspx");
        //Response.Redirect("~/login.aspx");
    }
}
