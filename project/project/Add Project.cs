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
    public partial class AddProject : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public AddProject()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }
        private void PopulateGridView(string sql = "select * from Project;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridView_A_P.DataSource = ds.Tables[0];
        }

        private void PopulateGridView_Search(string sql)
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridView_A_P.DataSource = ds.Tables[0];
        }

        private void CombBox_Dep()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_A_P.ValueMember = "Depid";
            comboB_A_P.DisplayMember = "Depname";
            comboB_A_P.DataSource = dtbl;

        }

        private void CombBox_Search() 
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_Search.ValueMember = "Depid";
            comboB_Search.DisplayMember = "Depname";
            comboB_Search.DataSource = dtbl;

            /*SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Project";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_Search.ValueMember = "Project_id";
            comboB_Search.DisplayMember = "Project_name";
            comboB_Search.DataSource = dtbl;*/

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            CombBox_Dep();
            CombBox_Search();
        }

        private void A_P_Save_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var a = comboB_A_P.SelectedValue.ToString();
                int b = Convert.ToInt32(a);


                string sql = "insert into Project(Project_name,Dep_id) values('" + this.textB_P_name.Text + "'," + b + ");";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion complete");
                else
                    MessageBox.Show("Data insertion failed");


                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void ClearContent()
        {

            this.textB_P_name.Clear();
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.textB_P_name.Text) || String.IsNullOrWhiteSpace(this.textB_P_name.Text))

            {
                return false;
            }

            return true;
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            var a = comboB_Search.SelectedValue.ToString();
            int b = Convert.ToInt32(a);
            String sql = "select * from Project where Dep_id=" + b + ";";
            PopulateGridView_Search(sql);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            this.Hide();
            a1.id = id;
            a1.Show();
        }

        private void AddProject_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
