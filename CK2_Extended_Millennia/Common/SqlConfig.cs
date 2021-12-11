using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

public static class SqlConfig
{

    public static void SqlShowDataTextbox(string sql, TextBox textbox)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["CK2_Extended_Millennia.Properties.Settings.CK2_Extended_MillenniaConnectionString"].ConnectionString;
        con.Open();

        using (con)
        {
            SqlCommand command = new SqlCommand(sql, con);

            try
            {
                textbox.Text = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        con.Close();
    }

}
