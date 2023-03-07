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
    public partial class payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["studentdbConnectionString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                string no = txt_id.Text;
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM payments WHERE MEMBERSHIP_NO = '" + no + "'"))
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
}
