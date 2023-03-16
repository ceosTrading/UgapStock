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
                string query = "SELECT id,item_name FROM items_in;";
                MySqlCommand command = new MySqlCommand(query);
                using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    command.Connection = connection;
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        ListItem item = new ListItem(name, id.ToString());
                        ddl_items.Items.Add(item);
                    }

                    reader.Close();
                }




            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }





        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm3.aspx");
        }

        protected void btn_view_Click1(object sender, EventArgs e)
        {

            // Retrieve the connection string from web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Create a new MySqlConnection using the connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Open the connection to the database
                connection.Open();

                // Create the SQL query based on the current month
                string query;
                string itemName = ddl_items.SelectedItem.Text;

                if (string.IsNullOrEmpty(ddl_items.SelectedValue))
                {
                    if (ddl_Month.SelectedValue == "1") // Januarys
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jan ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "2") // February
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_feb ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "3") // March
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_mar ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "4") // April
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_apr ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "5") // May
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_may ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "6") // June
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_june ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "7") // July
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jul ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "8") // August
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_aug ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "9") // September
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_sep ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "10") // October
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_oct ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "11") // November
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_nov ORDER BY DATE DESC;";
                    }
                    else // December
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_dec ORDER BY DATE DESC;";
                    }


                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Create a DataTable to hold the results of the query
                    DataTable dataTable = new DataTable();

                    // Use a MySqlDataAdapter to fill the DataTable with the results of the query
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the GridView control
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                    // Close the connection to the database
                    connection.Close();

                }

                else
                {

                    if (ddl_Month.SelectedValue == "1") // Januarys
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jan WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "2") // February
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_feb WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "3") // March
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_mar WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "4") // April
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_apr WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "5") // May
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_may WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "6") // June
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_june WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "7") // July
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jul WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "8") // August
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_aug WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "9") // September
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_sep WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "10") // October
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_oct WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else if (ddl_Month.SelectedValue == "11") // November
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_nov WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }
                    else // December
                    {
                        query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_dec WHERE item_name = @SelectedName ORDER BY DATE DESC;";
                    }


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedName", itemName);

                    // Create a DataTable to hold the results of the query
                    DataTable dataTable = new DataTable();

                    // Use a MySqlDataAdapter to fill the DataTable with the results of the query
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the GridView control
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                    // Close the connection to the database
                    connection.Close();
                }
            }
            // Execute the SQL query using the appropriate database connection

        }
    }
}