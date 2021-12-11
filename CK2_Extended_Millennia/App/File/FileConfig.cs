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
    }
}
