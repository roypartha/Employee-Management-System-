
namespace project
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView_A_P = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Show = new System.Windows.Forms.Button();
            this.comboB_Search = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.A_P_Save = new System.Windows.Forms.Button();
            this.comboB_T_D = new System.Windows.Forms.ComboBox();
            this.textB_T_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A_P)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Location = new System.Drawing.Point(55, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 53);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(254, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 26);
            this.button6.TabIndex = 5;
            this.button6.Text = "ADD TASK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView_A_P
            // 
            this.dataGridView_A_P.AllowUserToAddRows = false;
            this.dataGridView_A_P.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_A_P.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView_A_P.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_A_P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_A_P.Location = new System.Drawing.Point(403, 151);
            this.dataGridView_A_P.Name = "dataGridView_A_P";
            this.dataGridView_A_P.ReadOnly = true;
            this.dataGridView_A_P.Size = new System.Drawing.Size(342, 263);
            this.dataGridView_A_P.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_Show);
            this.panel3.Controls.Add(this.comboB_Search);
            this.panel3.Controls.Add(this.button_Search);
            this.panel3.Location = new System.Drawing.Point(403, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 50);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(255, 14);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(75, 23);
            this.button_Show.TabIndex = 2;
            this.button_Show.Text = "Show All";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // comboB_Search
            // 
            this.comboB_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_Search.FormattingEnabled = true;
            this.comboB_Search.Location = new System.Drawing.Point(100, 16);
            this.comboB_Search.Name = "comboB_Search";
            this.comboB_Search.Size = new System.Drawing.Size(121, 21);
            this.comboB_Search.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(19, 16);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(55, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 50);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(81, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 26);
            this.button5.TabIndex = 5;
            this.button5.Text = "Fill The Form";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.A_P_Save);
            this.panel1.Controls.Add(this.comboB_T_D);
            this.panel1.Controls.Add(this.textB_T_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 263);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // A_P_Save
            // 
            this.A_P_Save.Location = new System.Drawing.Point(63, 203);
            this.A_P_Save.Name = "A_P_Save";
            this.A_P_Save.Size = new System.Drawing.Size(62, 26);
            this.A_P_Save.TabIndex = 4;
            this.A_P_Save.Text = "Save";
            this.A_P_Save.UseVisualStyleBackColor = true;
            this.A_P_Save.Click += new System.EventHandler(this.A_P_Save_Click);
            // 
            // comboB_T_D
            // 
            this.comboB_T_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_T_D.FormattingEnabled = true;
            this.comboB_T_D.Location = new System.Drawing.Point(63, 119);
            this.comboB_T_D.Name = "comboB_T_D";
            this.comboB_T_D.Size = new System.Drawing.Size(221, 21);
            this.comboB_T_D.TabIndex = 3;
            // 
            // textB_T_name
            // 
            this.textB_T_name.Location = new System.Drawing.Point(63, 47);
            this.textB_T_name.Name = "textB_T_name";
            this.textB_T_name.Size = new System.Drawing.Size(221, 20);
            this.textB_T_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(55, 420);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 12;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_A_P);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Task";
            this.Text = "Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Task_FormClosing);
            this.Load += new System.EventHandler(this.Task_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A_P)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView_A_P;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.ComboBox comboB_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button A_P_Save;
        private System.Windows.Forms.ComboBox comboB_T_D;
        private System.Windows.Forms.TextBox textB_T_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
    }
}