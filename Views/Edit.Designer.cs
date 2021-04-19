
namespace Laba4Dima.Views
{
    partial class Edit
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Namei = new System.Windows.Forms.TextBox();
            this.Agei = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notnotman = new System.Windows.Forms.RadioButton();
            this.notman = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.Classi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Agei)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Namei
            // 
            this.Namei.Location = new System.Drawing.Point(233, 12);
            this.Namei.Name = "Namei";
            this.Namei.Size = new System.Drawing.Size(100, 20);
            this.Namei.TabIndex = 2;
            // 
            // Agei
            // 
            this.Agei.Location = new System.Drawing.Point(386, 12);
            this.Agei.Name = "Agei";
            this.Agei.Size = new System.Drawing.Size(120, 20);
            this.Agei.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(256, 247);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notnotman);
            this.groupBox1.Controls.Add(this.notman);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Location = new System.Drawing.Point(233, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
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
            // Classi
            // 
            this.Classi.FormattingEnabled = true;
            this.Classi.Location = new System.Drawing.Point(240, 172);
            this.Classi.Name = "Classi";
            this.Classi.Size = new System.Drawing.Size(121, 21);
            this.Classi.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Class";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Classi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agei);
            this.Controls.Add(this.Namei);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Agei)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Namei;
        private System.Windows.Forms.NumericUpDown Agei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton notnotman;
        private System.Windows.Forms.RadioButton notman;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.ComboBox Classi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}