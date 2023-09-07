using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace project
{
    public partial class AddEmployee : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public AddEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ComboB_E_Name()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Employee";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboB_S.ValueMember = "Empid";
            comboB_S.DisplayMember = "Empname";
            comboB_S.DataSource = dtbl;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboBDepname.ValueMember = "Depid";
            comboBDepname.DisplayMember = "Depname";
            comboBDepname.DataSource = dtbl;

            ComboB_E_Name();


        }
        private void PopulateGridView(string sql = "select * from Employee;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridViewemp.DataSource = ds.Tables[0];
        }

        private void PopulateGridView_S(string sql)
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridViewemp.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var a = comboBDepname.SelectedValue.ToString();
                int b = Convert.ToInt32(a);
                string theDate = dateHireEmp .Value.ToString("yyyy-MM-dd");

                string sql = "insert into Employee(Empname,Hiredate,Depid,role,Salary,Username,Password) values('" + this.textBEmpName.Text + "','" + theDate + "'," + b + ",'" + Convert.ToInt32(this.comboBemprole.Text) + "','" + Convert.ToInt32(this.textBEmpSalary.Text )+ "','" + this.textBEu_name.Text + "','" + this.textBPass.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                
                string sql1 = "insert into Login(role,Username,password) values('" + Convert.ToInt32(this.comboBemprole.Text) + "','" + this.textBEu_name.Text + "','" + this.textBPass.Text + "');";
                //"select role,Username,Password,Empid from Employee;";
                this.Da.ExecuteDMLQuery(sql1);

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
            
            this.textBEmpName.Clear();
            this.textBEmpSalary.Clear();
            this.textBEu_name.Clear();
            this.textBPass.Clear();
            
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.textBEmpName.Text) || String.IsNullOrWhiteSpace(this.textBEmpName.Text)
                || String.IsNullOrEmpty(this.textBEmpSalary.Text) || String.IsNullOrWhiteSpace(this.textBEmpSalary.Text)
                 || String.IsNullOrEmpty(this.textBEu_name.Text) || String.IsNullOrWhiteSpace(this.textBEu_name.Text)
                 || String.IsNullOrEmpty(this.textBPass.Text) || String.IsNullOrWhiteSpace(this.textBPass.Text))

            {
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBEmpName.Clear();
            this.textBEmpSalary.Clear();
            this.textBEu_name.Clear();
            this.textBPass.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            this.Hide();
            a1.id = id;
            a1.Show();
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            var id = comboB_S.SelectedValue.ToString();
            int Eid = Convert.ToInt32(id);
            String sql = "select * from Employee where Empid="+Eid+" ;";
            PopulateGridView_S(sql);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboB_S_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
