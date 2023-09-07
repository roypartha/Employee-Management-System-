
namespace project
{
    partial class Updated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updated));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBUp_Tname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxUP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.comboBUp_Tname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxUP);
            this.panel1.Location = new System.Drawing.Point(237, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 291);
            this.panel1.TabIndex = 0;
            // 
            // comboBUp_Tname
            // 
            this.comboBUp_Tname.FormattingEnabled = true;
            this.comboBUp_Tname.Location = new System.Drawing.Point(56, 63);
            this.comboBUp_Tname.Name = "comboBUp_Tname";
            this.comboBUp_Tname.Size = new System.Drawing.Size(181, 21);
            this.comboBUp_Tname.TabIndex = 6;
            this.comboBUp_Tname.SelectedIndexChanged += new System.EventHandler(this.comboBUp_Tname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Percentage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Percentage";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Updated";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxUP
            // 
            this.textBoxUP.Location = new System.Drawing.Point(56, 134);
            this.textBoxUP.Multiline = true;
            this.textBoxUP.Name = "textBoxUP";
            this.textBoxUP.Size = new System.Drawing.Size(181, 20);
            this.textBoxUP.TabIndex = 0;
            this.textBoxUP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Updated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Updated";
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updated_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBUp_Tname;
        private System.Windows.Forms.Label label2;
    }
}