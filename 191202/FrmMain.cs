using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _191202
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB;Database = Ceg;");

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();

            var sql = new SqlCommand("SELECT * FROM epuletek",conn);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                

                dgvEpuletek.Rows.Add(reader[0], reader[1], reader[2]);
            }
            conn.Close();


            
        }
    }
}
