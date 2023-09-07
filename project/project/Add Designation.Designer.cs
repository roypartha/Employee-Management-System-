
namespace project
{
    partial class AddDesignation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDesignation));
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDis = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBdisname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new project.ProjectDataSet();
            this.departmentTableAdapter = new project.ProjectDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewDis = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDis)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(62, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxDis);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBdisname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 288);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxDis
            // 
            this.comboBoxDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDis.FormattingEnabled = true;
            this.comboBoxDis.Location = new System.Drawing.Point(63, 70);
            this.comboBoxDis.Name = "comboBoxDis";
            this.comboBoxDis.Size = new System.Drawing.Size(207, 21);
            this.comboBoxDis.TabIndex = 6;
            this.comboBoxDis.SelectedIndexChanged += new System.EventHandler(this.comboBoxDis_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(181, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBdisname
            // 
            this.textBdisname.Location = new System.Drawing.Point(63, 137);
            this.textBdisname.Multiline = true;
            this.textBdisname.Name = "textBdisname";
            this.textBdisname.Size = new System.Drawing.Size(207, 20);
            this.textBdisname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(111, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter  Department ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(128, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.projectDataSet;
            // 
            // dataGridViewDis
            // 
            this.dataGridViewDis.AllowUserToAddRows = false;
            this.dataGridViewDis.AllowUserToDeleteRows = false;
            this.dataGridViewDis.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDis.Location = new System.Drawing.Point(423, 68);
            this.dataGridViewDis.Name = "dataGridViewDis";
            this.dataGridViewDis.ReadOnly = true;
            this.dataGridViewDis.Size = new System.Drawing.Size(282, 288);
            this.dataGridViewDis.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(508, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(62, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 53);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(99, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Designation";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(423, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 53);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(48, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Show Information";
            // 
            // AddDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewDis);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "AddDesignation";
            this.Text = "Add Designation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDesignation_FormClosing);
            this.Load += new System.EventHandler(this.AddDesignation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBdisname;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private ProjectDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxDis;
        private System.Windows.Forms.DataGridView dataGridViewDis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}