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
    public partial class AddDesignation : Form
    {
        public int id;
        private DataAccess Da { get; set; }
        public AddDesignation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void PopulateGridView(string sql = "select * from Designation;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dataGridViewDis.DataSource = ds.Tables[0];
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Admin Ad1 = new Admin();

            this.Hide();
            Ad1.id = id;
            Ad1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var a = comboBoxDis.SelectedValue.ToString();
                int b = Convert.ToInt32(a);
             
                    string sql = "insert into Designation (Desname,Depid) values('" + this.textBdisname.Text + "'," + b + ");";
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
            this.textBdisname.Clear();
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.comboBoxDis.Text) || String.IsNullOrWhiteSpace(this.comboBoxDis.Text) || String.IsNullOrEmpty(this.textBdisname.Text) || String.IsNullOrWhiteSpace(this.textBdisname.Text))

            {
                return false;
            }

            return true;
        }



        private void AddDesignation_Load(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-BSFB417;Initial Catalog=Project;Persist Security Info=True;User ID=admin;Password=parthaadmin@");
            string query = "Select * from Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, sq);
            DataTable dtbl = new DataTable();
            sa.Fill(dtbl);
            comboBoxDis.ValueMember = "Depid";
            comboBoxDis.DisplayMember = "Depname";
            comboBoxDis.DataSource = dtbl;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void comboBoxDis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDesignation_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
