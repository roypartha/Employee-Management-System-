
namespace project
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.textBDepname = new System.Windows.Forms.TextBox();
            this.b_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewdep = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.projectDataSet1 = new project.ProjectDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(94, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Department Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.b_cancel);
            this.panel1.Controls.Add(this.b_Save);
            this.panel1.Controls.Add(this.textBDepname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 265);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(181, 220);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_Save
            // 
            this.b_Save.BackColor = System.Drawing.Color.Transparent;
            this.b_Save.Location = new System.Drawing.Point(49, 220);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 4;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = false;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click_1);
            // 
            // textBDepname
            // 
            this.textBDepname.Location = new System.Drawing.Point(49, 116);
            this.textBDepname.Multiline = true;
            this.textBDepname.Name = "textBDepname";
            this.textBDepname.Size = new System.Drawing.Size(207, 20);
            this.textBDepname.TabIndex = 1;
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(207, 351);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 2;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(84, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 56);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(79, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(414, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department Details";
            // 
            // dataGridViewdep
            // 
            this.dataGridViewdep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdep.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdep.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewdep.Location = new System.Drawing.Point(449, 71);
            this.dataGridViewdep.Name = "dataGridViewdep";
            this.dataGridViewdep.Size = new System.Drawing.Size(332, 265);
            this.dataGridViewdep.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectDataSet1
            // 
            this.projectDataSet1.DataSetName = "ProjectDataSet";
            this.projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewdep);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.panel1);
            this.Name = "AddDepartment";
            this.Text = "Add Department";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDepartment_FormClosing);
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.TextBox textBDepname;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewdep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private ProjectDataSet projectDataSet1;
    }
}