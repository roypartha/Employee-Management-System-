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
    public partial class AddDepartment : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public AddDepartment()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void PopulateGridView(string sql = "select * from Department;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridViewdep.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin Ad1 = new Admin();

            this.Hide();
            Ad1.id = id;
            Ad1.Show();
        }

      

        private void b_Save_Click_1(object sender, EventArgs e)
        {
            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var txt = "select * from Department where Depname = '" + this.textBDepname.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
               

                    string sql = "insert into Department values('" + this.textBDepname.Text + "');";
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

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.textBDepname.Text) || String.IsNullOrWhiteSpace(this.textBDepname.Text))
         
            {
                return false;
            }

            return true;
        }

        private void ClearContent()
        {
            this.textBDepname.Clear();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.textBDepname.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void AddDepartment_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
