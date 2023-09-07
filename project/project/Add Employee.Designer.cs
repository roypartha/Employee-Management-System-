
namespace project
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBEu_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBemprole = new System.Windows.Forms.ComboBox();
            this.dateHireEmp = new System.Windows.Forms.DateTimePicker();
            this.comboBDepname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBEmpSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboB_S = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewemp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBPass);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBEu_name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBemprole);
            this.panel1.Controls.Add(this.dateHireEmp);
            this.panel1.Controls.Add(this.comboBDepname);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBEmpSalary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBEmpName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 355);
            this.panel1.TabIndex = 0;
            // 
            // textBPass
            // 
            this.textBPass.Location = new System.Drawing.Point(130, 192);
            this.textBPass.Multiline = true;
            this.textBPass.Name = "textBPass";
            this.textBPass.Size = new System.Drawing.Size(185, 20);
            this.textBPass.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(30, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Password";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBEu_name
            // 
            this.textBEu_name.Location = new System.Drawing.Point(130, 160);
            this.textBEu_name.Multiline = true;
            this.textBEu_name.Name = "textBEu_name";
            this.textBEu_name.Size = new System.Drawing.Size(185, 20);
            this.textBEu_name.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(30, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "UserName";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(240, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(33, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBemprole
            // 
            this.comboBemprole.FormattingEnabled = true;
            this.comboBemprole.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBemprole.Location = new System.Drawing.Point(130, 86);
            this.comboBemprole.Name = "comboBemprole";
            this.comboBemprole.Size = new System.Drawing.Size(185, 21);
            this.comboBemprole.TabIndex = 13;
            // 
            // dateHireEmp
            // 
            this.dateHireEmp.Location = new System.Drawing.Point(130, 125);
            this.dateHireEmp.Name = "dateHireEmp";
            this.dateHireEmp.Size = new System.Drawing.Size(185, 20);
            this.dateHireEmp.TabIndex = 12;
            // 
            // comboBDepname
            // 
            this.comboBDepname.FormattingEnabled = true;
            this.comboBDepname.Location = new System.Drawing.Point(130, 52);
            this.comboBDepname.Name = "comboBDepname";
            this.comboBDepname.Size = new System.Drawing.Size(185, 21);
            this.comboBDepname.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(30, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Salary";
            // 
            // textBEmpSalary
            // 
            this.textBEmpSalary.Location = new System.Drawing.Point(130, 230);
            this.textBEmpSalary.Multiline = true;
            this.textBEmpSalary.Name = "textBEmpSalary";
            this.textBEmpSalary.Size = new System.Drawing.Size(185, 20);
            this.textBEmpSalary.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(30, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hire Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(30, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rule";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(30, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Department name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // textBEmpName
            // 
            this.textBEmpName.Location = new System.Drawing.Point(130, 12);
            this.textBEmpName.Multiline = true;
            this.textBEmpName.Name = "textBEmpName";
            this.textBEmpName.Size = new System.Drawing.Size(185, 20);
            this.textBEmpName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(30, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Full Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 53);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(427, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(789, 53);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboB_S);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(433, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 53);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboB_S
            // 
            this.comboB_S.BackColor = System.Drawing.Color.Navy;
            this.comboB_S.ForeColor = System.Drawing.Color.Black;
            this.comboB_S.FormattingEnabled = true;
            this.comboB_S.Location = new System.Drawing.Point(81, 15);
            this.comboB_S.Name = "comboB_S";
            this.comboB_S.Size = new System.Drawing.Size(144, 21);
            this.comboB_S.TabIndex = 18;
            this.comboB_S.SelectedIndexChanged += new System.EventHandler(this.comboB_S_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(254, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(136, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewemp
            // 
            this.dataGridViewemp.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewemp.Location = new System.Drawing.Point(433, 67);
            this.dataGridViewemp.Name = "dataGridViewemp";
            this.dataGridViewemp.Size = new System.Drawing.Size(362, 351);
            this.dataGridViewemp.TabIndex = 17;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.dataGridViewemp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployee_FormClosing);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBemprole;
        private System.Windows.Forms.DateTimePicker dateHireEmp;
        private System.Windows.Forms.ComboBox comboBDepname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBEmpSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBEu_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewemp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboB_S;
    }
}