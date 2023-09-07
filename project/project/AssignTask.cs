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
   
    public partial class AssignTask : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public AssignTask()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ComboB_T_Name()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Task";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
             
            comboB_T_N.ValueMember = "Task_id";
            comboB_T_N.DisplayMember = "Task_name";
            comboB_T_N.DataSource = dtbl;
        }

        private void ComboB_P_Name()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Project";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_P_N.ValueMember = "Project_id";
            comboB_P_N.DisplayMember = "Project_name";
            comboB_P_N.DataSource = dtbl;
        }
        private void ComboB_E_Name()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Employee";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_E_N.ValueMember = "Empid";
            comboB_E_N.DisplayMember = "Empname";
            comboB_E_N.DataSource = dtbl;
        }

        private void ComboB_E_Name_Serach()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Employee";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_A_Search.ValueMember = "Empid";
            comboB_A_Search.DisplayMember = "Empname";
            comboB_A_Search.DataSource = dtbl;
        }

        private void PopulateGridView_Search(string sql)
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridView_A_T.DataSource = ds.Tables[0];
        }



        private void AssinTask_Load(object sender, EventArgs e)
        {
            ComboB_T_Name();
            ComboB_P_Name();
            ComboB_E_Name();
            ComboB_E_Name_Serach();

        }

        private void PopulateGridView(string sql = "select * from Assin_Task;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridView_A_T.DataSource = ds.Tables[0];
        }

        private void A_P_Save_Click(object sender, EventArgs e)
        {
            

            try
            {
                var id  = comboB_T_N.SelectedValue.ToString();
                int Tid = Convert.ToInt32(id);

                id = comboB_P_N.SelectedValue.ToString();
                int Pid = Convert.ToInt32(id);

                id = comboB_E_N.SelectedValue.ToString();
                int Eid = Convert.ToInt32(id);

                comboB_T_N.ValueMember = "Task_name";
                var T = comboB_T_N.SelectedValue.ToString();

                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string sql = "insert into Assin_Task(Task_id,Project_id,Emp_id,Assin_date,End_date,Status,Percentage,Task_name) values('" + Tid + "','" + Pid + "','" + Eid + "','" + startDate + "','" + endDate + "','" + "Pending"+ "','" + 0 + "','" + T + "');";
                int count = this.Da.ExecuteDMLQuery(sql);


                

                if (count == 1)
                    MessageBox.Show("Data insertion complete");
                else
                    MessageBox.Show("Data insertion failed");


                this.PopulateGridView();
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        

       
       

        private void button_Search_Click(object sender, EventArgs e)
        {
            var id = comboB_A_Search.SelectedValue.ToString();
            int Eid = Convert.ToInt32(id);
            String sql = "select * from Assin_Task where Emp_id=" + Eid + ";";
            PopulateGridView_Search(sql);
            
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            this.Hide();
            a1.id = id;
            a1.Show();
        }

        private void AssignTask_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
