using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class WELCOME____ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
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