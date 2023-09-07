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

namespace project
{
    public partial class F_login : Form
    {
        
        public F_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Login Where username = '" + textBusername.Text.Trim() + "' and password = '" + textBpass.Text.Trim() + "'";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["role"].ToString() == "1")
                {
                   
                    Admin objFrmMain = new Admin();
                    this.Hide();
                    
                    objFrmMain.Show();

                }
                else
                {
                    string id = dtbl.Rows[0]["Empid"].ToString();
                    this.Hide();
                    Employee E1 = new Employee();
                    E1.id = Convert.ToInt32(id);
                    E1.Show();

                }

            }
            else
            {
                MessageBox.Show("Check your username and password","Login error",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work Going on..??", "error", MessageBoxButtons.OKCancel);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the Application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }



            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.textBusername.Clear();
            this.textBpass.Clear();
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }
    }
}
