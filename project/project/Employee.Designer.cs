
namespace project
{
    partial class Employee
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
            this.button1 = new System.Windows.Forms.Button();
            this.b_P_Task = new System.Windows.Forms.Button();
            this.b_C_Task = new System.Windows.Forms.Button();
            this.b_U_Task = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_A = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_P_Task
            // 
            this.b_P_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_P_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_P_Task.Location = new System.Drawing.Point(0, 14);
            this.b_P_Task.Name = "b_P_Task";
            this.b_P_Task.Size = new System.Drawing.Size(145, 34);
            this.b_P_Task.TabIndex = 2;
            this.b_P_Task.Text = "Panding Task";
            this.b_P_Task.UseVisualStyleBackColor = false;
            this.b_P_Task.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_C_Task
            // 
            this.b_C_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_C_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_C_Task.Location = new System.Drawing.Point(0, 109);
            this.b_C_Task.Name = "b_C_Task";
            this.b_C_Task.Size = new System.Drawing.Size(145, 34);
            this.b_C_Task.TabIndex = 3;
            this.b_C_Task.Text = "Complited Task";
            this.b_C_Task.UseVisualStyleBackColor = false;
            this.b_C_Task.Click += new System.EventHandler(this.b_C_Task_Click);
            // 
            // b_U_Task
            // 
            this.b_U_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_U_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_U_Task.Location = new System.Drawing.Point(-6, 216);
            this.b_U_Task.Name = "b_U_Task";
            this.b_U_Task.Size = new System.Drawing.Size(154, 34);
            this.b_U_Task.TabIndex = 4;
            this.b_U_Task.Text = "Updated Task";
            this.b_U_Task.UseVisualStyleBackColor = false;
            this.b_U_Task.Click += new System.EventHandler(this.b_U_Task_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 53);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.textBoxid);
            this.panel2.Controls.Add(this.textBname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 326);
            this.panel2.TabIndex = 6;
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.Location = new System.Drawing.Point(57, 225);
            this.textBoxid.Multiline = true;
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(184, 20);
            this.textBoxid.TabIndex = 10;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            // 
            // textBname
            // 
            this.textBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBname.Location = new System.Drawing.Point(57, 177);
            this.textBname.Multiline = true;
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(184, 20);
            this.textBname.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 106);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME";
            // 
            // dataGridView_A
            // 
            this.dataGridView_A.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_A.Location = new System.Drawing.Point(473, 63);
            this.dataGridView_A.Name = "dataGridView_A";
            this.dataGridView_A.Size = new System.Drawing.Size(359, 326);
            this.dataGridView_A.TabIndex = 7;
            this.dataGridView_A.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_A_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.b_U_Task);
            this.panel3.Controls.Add(this.b_P_Task);
            this.panel3.Controls.Add(this.b_C_Task);
            this.panel3.Location = new System.Drawing.Point(319, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 326);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "EMPLOYEE ";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView_A);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_P_Task;
        private System.Windows.Forms.Button b_C_Task;
        private System.Windows.Forms.Button b_U_Task;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_A;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.Label label4;
    }
}