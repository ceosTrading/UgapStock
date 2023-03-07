using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Registration
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["studentdbConnectionString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT MEMBERSHIP_NO FROM personal_info ORDER BY date DESC LIMIT 1"))
                    {

                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            da.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                string id = dt.Rows[0][0].ToString();
                                string plus = id.ToString() + 1;
                                string authorName = id.Substring(2);
                                int userID = Convert.ToInt32(authorName.ToString());
                                if (userID < 9999)
                                {
                                    userID++;
                                }
                                string numb = userID.ToString();
                                string let = "K/";
                                    string http = let + numb;


                                txt_id.Text = http.ToString();
                            }
                        }
                    }
                }
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

            connection.Open();
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string insert_query = "INSERT INTO personal_info (MEMBERSHIP_NO,NAME,DOB,SCHOOL,AGE,GENDER,ADDRESS,CONTACT_NO,PARENT_NAME,EMERGENCY_CONTACT,GMAIL,PAYMENT_METHOD,date,eme_name) VALUES('" + txt_id.Text + "','" + txt_firstname.Text + "','" + txt_lastname.Text + "','" + txt_email.Text + "','" + txt_phonenum.Text + "','" + RadioButtonList1.Text + "','" + txt_address.Text + "','" + txt_contact.Text + "','" + txt_parent.Text + "','" + txt_emeCon.Text + "','" + txt_mail.Text + "','" + RadioButtonList2.Text + "','" +date+ "','"+txt_emename.Text+"')";

            MySqlCommand cmd = new MySqlCommand(insert_query, connection);

            cmd.CommandText = insert_query;
            cmd.ExecuteNonQuery();
            cmd.Connection = connection;
            connection.Close();



            //connection.Open();
            //string insert = "INSERT INTO payments (MEMBERSHIP_NO) VALUES('" + txt_id.Text + "')";

            //MySqlCommand commd = new MySqlCommand(insert, connection);

            //commd.CommandText = insert;
            //commd.ExecuteNonQuery();
            //commd.Connection = connection;
            //connection.Close();








            Label2.Text = "Student Registration Successfull !";
            txt_id.Text = "";
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_email.Text = "";
            txt_phonenum.Text = "";
            RadioButtonList1.SelectedValue = "";
            txt_address.Text = "";
            txt_contact.Text = "";
            txt_parent.Text = "";
            txt_emeCon.Text = "";
            txt_mail.Text = "";
            RadioButtonList2.SelectedValue = "";
            Response.Redirect("~/WebForm3.aspx");

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
            string searchstudentidToDelete = txt_id.Text;
            string delete_query = "DELETE FROM student WHERE studentid = '" + searchstudentidToDelete + "'";


            MySqlCommand cmd = new MySqlCommand(delete_query, connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


            Label2.Text = "Student Delete Successfull !";

            txt_email.Text = "";
            txt_firstname.Text = "";
            txt_id.Text = "";
            txt_lastname.Text = "";
            txt_phonenum.Text = "";
            
        }

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
            string searchstudentidToUpdate = txt_id.Text;
            string update_query = "UPDATE student SET first_name = '" + txt_firstname.Text + "',last_name = '" + txt_lastname.Text + "',email = '" + txt_email.Text + "',phone_number = '" + txt_phonenum.Text + "' WHERE studentid = '" + txt_id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(update_query, connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            Label2.Text = "Student Updated Successfull !";
            txt_email.Text = "";
            txt_firstname.Text = "";
            txt_id.Text = "";
            txt_lastname.Text = "";
            txt_phonenum.Text = "";
        }

        protected void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_id_TextChanged(object sender, EventArgs e)
        {

            //string constr = ConfigurationManager.ConnectionStrings["studentdbConnectionString"].ConnectionString;
            //using (MySqlConnection con = new MySqlConnection(constr))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM personal_info WHERE MEMBERSHIP_NO = '"+txt_id.Text+"'"))
            //    {

            //        using (MySqlDataAdapter da = new MySqlDataAdapter())
            //        {
            //            cmd.Connection = con;
            //            da.SelectCommand = cmd;
            //            using (DataTable dt = new DataTable())
            //            {
            //                da.Fill(dt);
            //                txt_id.Text = dt.Rows[0][0].ToString();
            //                txt_firstname.Text = dt.Rows[0][1].ToString();
            //                txt_lastname.Text = dt.Rows[0][2].ToString();
            //                txt_email.Text = dt.Rows[0][3].ToString();
            //                txt_phonenum.Text = dt.Rows[0][7].ToString();
            //                //RadioButtonList1.SelectedValue = dt.Rows[0][4].ToString();
            //                txt_address.Text = dt.Rows[0][6].ToString();
            //                txt_contact.Text = dt.Rows[0][7].ToString();
            //                txt_parent.Text = dt.Rows[0][8].ToString();
            //                txt_emeCon.Text = dt.Rows[0][9].ToString();
            //                txt_email.Text = dt.Rows[0][10].ToString();
            //                //RadioButtonList2.SelectedValue = dt.Rows[0][11].ToString();





            //            }
            //        }
            //    }
            //}

        }

        protected void btn_pay_Click(object sender, EventArgs e)
        {
            Response.Redirect("fee.aspx");
        }
    }
}
