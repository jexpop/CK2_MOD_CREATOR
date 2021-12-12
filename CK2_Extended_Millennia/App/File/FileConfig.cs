using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CK2_Extended_Millennia
{
    public partial class FileConfig : Form
    {
        public FileConfig()
        {
            InitializeComponent();
        }

        private void FileConfig_Load(object sender, EventArgs e)
        {
            SelectDataBiding();
        }

        private void SelectDataBiding()
        {
            string sql;

            sql = "SELECT Value FROM PARAMS WHERE Condition1='paths' AND Condition2='game' ";
            SqlConfig.SqlShowDataTextbox(sql, GamePathTextBox);

            sql = "SELECT Value FROM PARAMS WHERE Condition1='paths' AND Condition2='mod_build' ";
            SqlConfig.SqlShowDataTextbox(sql, BuildModPathTextBox);

            sql = "SELECT Value FROM PARAMS WHERE Condition1='paths' AND Condition2='mod_game' ";
            SqlConfig.SqlShowDataTextbox(sql, GameModPathTextBox);

            sql = "SELECT Value FROM PARAMS WHERE Condition1='paths' AND Condition2='mod_name' ";
            SqlConfig.SqlShowDataTextbox(sql, ModNameTextBox);         
        }

        private void GroupBoxDefineDates_Enter(object sender, EventArgs e)
        {

        }

        private void DefineDatesSaveButton_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(GamePathTextBox.Text.Trim()) | 
                string.IsNullOrEmpty(BuildModPathTextBox.Text.Trim()) |
                string.IsNullOrEmpty(GameModPathTextBox.Text.Trim()) |
                string.IsNullOrEmpty(ModNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Todos los campos deben ser informados.", "Campos sin informar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql;
                sql = "UPDATE PARAMS SET Value='"+ GamePathTextBox.Text.Trim() + "' WHERE Condition1='paths' AND Condition2='game'; " +
                "UPDATE PARAMS SET Value='"+ BuildModPathTextBox.Text.Trim() + "' WHERE Condition1='paths' AND Condition2='mod_build'; " +
                "UPDATE PARAMS SET Value='"+ GameModPathTextBox.Text.Trim() + "' WHERE Condition1='paths' AND Condition2='mod_game'; " +
                "UPDATE PARAMS SET Value='"+ ModNameTextBox.Text.Trim() + "' WHERE Condition1='paths' AND Condition2='mod_name'; ";
                SqlConfig.SqlStatementExecute(sql);                
            }

        }
    }
}
