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
    public partial class Employee : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_login fl = new F_login();
            this.Hide();
            fl.Show();
           
        }
        private void Ename(string sql)
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
                 textBname.Text = name;
                 textBname.Visible = true;
            }
           
            
            textBoxid.Text = Convert.ToString(id);
            textBoxid.Visible = true;
           

        }

       

        private void Employee_Load(object sender, EventArgs e)
        {
            
            String sql = "select Empname from Employee where Empid=" + id + ";";
            Ename(sql);



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PopulateGridView_B(string sql)
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridView_A.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            String sql = "select Task_name,Assin_date,End_date,Status,Percentage from Assin_Task where Emp_id=" + id + " AND Percentage <"+100+" ;";
            PopulateGridView_B(sql);
           
        }

       

        private void b_C_Task_Click(object sender, EventArgs e)
        {
            String sql = "select Task_name,Assin_date,End_date,Status,Percentage from Assin_Task where Emp_id=" + id + " AND Percentage =" + 100 + " ;";
            PopulateGridView_B(sql);
        }

       

        private void b_U_Task_Click_1(object sender, EventArgs e)
        {
            Updated u1 = new Updated();
            this.Hide();
            
            u1.Eid = Convert.ToInt32(textBoxid.Text);
            u1.Show();

        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_A_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
