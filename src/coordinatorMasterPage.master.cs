using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coordinatorMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser"] == null)
            Response.Redirect("~/default.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        
    }
   
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton12_Click1(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/default.aspx");
    }
}
