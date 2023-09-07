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
    public partial class Updated : Form
    {
        public int Eid;
        private DataAccess Da { get; set; }
        public Updated()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ComboB_T_Name()
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Assin_Task where Emp_id='" + Eid + "';";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);

            comboBUp_Tname.ValueMember = "Task_id";
            comboBUp_Tname.DisplayMember = "Task_name";
            comboBUp_Tname.DataSource = dtbl;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboB_T_Name();


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var a = textBoxUP.Text;
                int b = Convert.ToInt32(a);
                var cid = comboBUp_Tname.SelectedValue.ToString();
                int Tid = Convert.ToInt32(cid);
                String sql;
                if (b == 100)
                {
                     sql = "UPDATE Assin_Task SET Status = '" + "Compeleted" + "', Percentage="+b+" WHERE Emp_id=" + Eid + " AND Task_id = "+Tid+"; ";
                   
                }
                else
                {
                     sql = "UPDATE Assin_Task SET Percentage=" + b + " WHERE Emp_id=" + Eid + ", Task_id = " + Tid + "; ";
                   
                }
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Updated complete");
                else
                    MessageBox.Show("Data Updated failed");


                
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void ClearContent()
        {

            this.textBoxUP.Clear();
           
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.textBoxUP.Text) || String.IsNullOrWhiteSpace(this.textBoxUP.Text))

            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            this.Hide();
            e1.id = Eid;
            e1.Show();
        }

        private void Updated_FormClosing(object sender, FormClosingEventArgs e)
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

        private void comboBUp_Tname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
