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
    public partial class Admin : Form
    {
        public int id;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_login fl = new F_login();
            this.Hide();
            fl.Show();
           
        }
        private void Enameid(string sql)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = sql;
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            String name;
            if (dtbl.Rows.Count == 1)
            {
                name = dtbl.Rows[0]["Empname"].ToString();
                textBoxname.Text = name;
                textBoxname.Visible = true;
            }


            textBoxid.Text = Convert.ToString(id);
            textBoxid.Visible = true;


        }


        private void addEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDesignation AddDes1 = new AddDesignation();
            this.Hide();
            AddDes1.id = id;
            AddDes1.Show();
        }

        

       

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login fl = new F_login();
            this.Hide();
            fl.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment adddep = new AddDepartment();
            this.Hide();
            adddep.id= id;
            adddep.Show();
        }

        private void addEmpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee AddE1 = new AddEmployee();
            this.Hide();
            AddE1.id = id;
            AddE1.Show();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject addp1 = new AddProject();
            this.Hide();
            addp1.id = id;
            addp1.Show();
        }

        private void assTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task ta1 = new Task();
            this.Hide();
            ta1.id=id;
            ta1.Show();
        }

        private void assTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssignTask assinp1 = new AssignTask();
            this.Hide();
            assinp1.id = id;
            assinp1.Show();
        }

        private void aDDProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            String sql = "select Empname from Employee where Empid=" + id + ";";
            Enameid(sql);

        }
    }
}
