
namespace Laba4Dima.Views
{
    partial class Add
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.statusText = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notnotman = new System.Windows.Forms.RadioButton();
            this.notman = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(13, 27);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(289, 20);
            this.Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Class";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(13, 67);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 20);
            this.Age.TabIndex = 9;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(17, 303);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(40, 13);
            this.statusText.TabIndex = 11;
            this.statusText.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(57, 224);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 12;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(13, 224);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 21);
            this.ClassBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notnotman);
            this.groupBox1.Controls.Add(this.notman);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Location = new System.Drawing.Point(16, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
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
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton notnotman;
        private System.Windows.Forms.RadioButton notman;
        private System.Windows.Forms.RadioButton man;
    }
}