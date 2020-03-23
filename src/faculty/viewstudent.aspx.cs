using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class faculty_viewstudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataSource SqlDataSource1 = new SqlDataSource();
        SqlDataSource1.ID = "SqlDataSource1";
        this.Page.Controls.Add(SqlDataSource1);
        SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
        String selectQuery = "Select Courses.name,Semesters.name, Subjects.name, Students.name" +
                            " FROM Courses,Semesters,Subjects,Students,feedbackeligible, Faculties" +
                            " WHERE feedbackeligible.subject_id=Subjects.id" +
                            " AND feedbackeligible.student_id=Students.id" +
                            " AND feedbackeligible.faculty_id=Faculties.id" +
                            " AND Subjects.course_id=Courses.id" +
                            " AND Subjects.semester_id=Semesters.id" +
                            " AND Faculties.email='" + Session["CurrentUser"] + "'";
        SqlDataSource1.SelectCommand = selectQuery;
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();
    }
}