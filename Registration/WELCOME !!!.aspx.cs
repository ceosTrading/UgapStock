using System;

namespace Registration
{
    public partial class WELCOME____ : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["UserName"];
            Label1.Text = "Welcome ! " + userName;

        }

        protected void ValidateUser(object sender, EventArgs e)
        {
            Response.Redirect("Additems.aspx");
        }

        protected void ValidateUser1(object sender, EventArgs e)
        {
            Response.Redirect("stockout.aspx");

        }

        protected void ValidateUser2(object sender, EventArgs e)
        {
            Response.Redirect("View.aspx");

        }
    }
}