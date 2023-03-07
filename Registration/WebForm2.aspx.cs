using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Registration
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["studentdbConnectionString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MEMBERSHIP_NO,NAME,DOB,SCHOOL,AGE,GENDER,ADDRESS,CONTACT_NO,PARENT_NAME,EMERGENCY_CONTACT,GMAIL,PAYMENT_METHOD FROM personal_info"))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            da.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                GridView1.DataSource = dt;
                                GridView1.DataBind();
                            }
                        }
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //TextBox5.Text = GridView1.SelectedRow.Cells[1].Text;
            //TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
            //TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
            //TextBox4.Text = GridView1.SelectedRow.Cells[4].Text;
            //TextBox1.Text = GridView1.SelectedRow.Cells[5].Text;
        }





        protected void Button1_Click1(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
            //string searchstudentidToUpdate = TextBox5.Text;
            //string update_query = "UPDATE student SET first_name = '" + TextBox2.Text + "',last_name = '" + TextBox3.Text + "',email = '" + TextBox4.Text + "',phone_number = '" + TextBox1.Text + "' WHERE studentid = '" + searchstudentidToUpdate + "'";
            //MySqlCommand cmd = new MySqlCommand(update_query, connection);

            //connection.Open();
            //cmd.ExecuteNonQuery();
            //connection.Close();

            //Label2.Text = "Student Updated Successfull !";
            //TextBox5.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            //TextBox4.Text = "";
            //TextBox1.Text = "";
            //Response.Redirect(Request.RawUrl);
        }

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm3.aspx");
        }

     

        
    }
}