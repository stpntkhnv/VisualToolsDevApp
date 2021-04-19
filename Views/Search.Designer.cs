
namespace Laba4Dima.Views
{
    partial class Search
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
            this.Namei = new System.Windows.Forms.TextBox();
            this.Agei = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notnotman = new System.Windows.Forms.RadioButton();
            this.notman = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Agei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namei
            // 
            this.Namei.Location = new System.Drawing.Point(13, 26);
            this.Namei.Name = "Namei";
            this.Namei.Size = new System.Drawing.Size(100, 20);
            this.Namei.TabIndex = 0;
            // 
            // Agei
            // 
            this.Agei.Location = new System.Drawing.Point(13, 67);
            this.Agei.Name = "Agei";
            this.Agei.Size = new System.Drawing.Size(120, 20);
            this.Agei.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Age,
            this.Class,
            this.Gender});
            this.dataGridView1.Location = new System.Drawing.Point(161, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 312);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notnotman);
            this.groupBox1.Controls.Add(this.notman);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gender";
            // 
            // notnotman
            // 
            this.notnotman.AutoSize = true;
            this.notnotman.Location = new System.Drawing.Point(7, 68);
            this.notnotman.Name = "notnotman";
            this.notnotman.Size = new System.Drawing.Size(108, 17);
            this.notnotman.TabIndex = 2;
            this.notnotman.TabStop = true;
            this.notnotman.Text = "Не определился";
            this.notnotman.UseVisualStyleBackColor = true;
            // 
            // notman
            // 
            this.notman.AutoSize = true;
            this.notman.Location = new System.Drawing.Point(7, 44);
            this.notman.Name = "notman";
            this.notman.Size = new System.Drawing.Size(56, 17);
            this.notman.TabIndex = 1;
            this.notman.TabStop = true;
            this.notman.Text = "Тварь";
            this.notman.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(7, 20);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(65, 17);
            this.man.TabIndex = 0;
            this.man.TabStop = true;
            this.man.Text = "Мжчина";
            this.man.UseVisualStyleBackColor = true;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(9, 229);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 21);
            this.ClassBox.TabIndex = 17;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(53, 229);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Class";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agei);
            this.Controls.Add(this.Namei);
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.Agei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Namei;
        private System.Windows.Forms.NumericUpDown Agei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton notnotman;
        private System.Windows.Forms.RadioButton notman;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
    }
}