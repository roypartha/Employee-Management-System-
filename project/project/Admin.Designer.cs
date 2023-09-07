
namespace project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(80, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abcToolStripMenuItem,
            this.aDDProjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(77, 450);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.abcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baToolStripMenuItem,
            this.addEmpToolStripMenuItem,
            this.addEmpToolStripMenuItem1});
            this.abcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abcToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            this.abcToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.abcToolStripMenuItem.Text = "Admin";
            // 
            // baToolStripMenuItem
            // 
            this.baToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.baToolStripMenuItem.Name = "baToolStripMenuItem";
            this.baToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.baToolStripMenuItem.Text = "Add Department ";
            this.baToolStripMenuItem.Click += new System.EventHandler(this.baToolStripMenuItem_Click);
            // 
            // addEmpToolStripMenuItem
            // 
            this.addEmpToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addEmpToolStripMenuItem.Name = "addEmpToolStripMenuItem";
            this.addEmpToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.addEmpToolStripMenuItem.Text = "Add Designation";
            this.addEmpToolStripMenuItem.Click += new System.EventHandler(this.addEmpToolStripMenuItem_Click);
            // 
            // addEmpToolStripMenuItem1
            // 
            this.addEmpToolStripMenuItem1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addEmpToolStripMenuItem1.Name = "addEmpToolStripMenuItem1";
            this.addEmpToolStripMenuItem1.Size = new System.Drawing.Size(205, 24);
            this.addEmpToolStripMenuItem1.Text = "Add Employee";
            this.addEmpToolStripMenuItem1.Click += new System.EventHandler(this.addEmpToolStripMenuItem1_Click);
            // 
            // aDDProjectToolStripMenuItem
            // 
            this.aDDProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.assTaskToolStripMenuItem,
            this.assTaskToolStripMenuItem1});
            this.aDDProjectToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aDDProjectToolStripMenuItem.Name = "aDDProjectToolStripMenuItem";
            this.aDDProjectToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.aDDProjectToolStripMenuItem.Text = "Project";
            this.aDDProjectToolStripMenuItem.Click += new System.EventHandler(this.aDDProjectToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.taskToolStripMenuItem.Text = "Add Project";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // assTaskToolStripMenuItem
            // 
            this.assTaskToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assTaskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.assTaskToolStripMenuItem.Name = "assTaskToolStripMenuItem";
            this.assTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.assTaskToolStripMenuItem.Text = "Add Task";
            this.assTaskToolStripMenuItem.Click += new System.EventHandler(this.assTaskToolStripMenuItem_Click);
            // 
            // assTaskToolStripMenuItem1
            // 
            this.assTaskToolStripMenuItem1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assTaskToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.assTaskToolStripMenuItem1.Name = "assTaskToolStripMenuItem1";
            this.assTaskToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.assTaskToolStripMenuItem1.Text = "Assign Task";
            this.assTaskToolStripMenuItem1.Click += new System.EventHandler(this.assTaskToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(77, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBoxid);
            this.panel1.Controls.Add(this.textBoxname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(311, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 296);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(84, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(104, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(51, 187);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(156, 20);
            this.textBoxname.TabIndex = 12;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(51, 238);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(156, 20);
            this.textBoxid.TabIndex = 13;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEmpToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxname;
    }
}