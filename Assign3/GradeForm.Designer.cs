namespace Assign3
{
    partial class GradeForm
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
            this.ZidBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LessButton1 = new System.Windows.Forms.RadioButton();
            this.GreaterButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsButton2 = new System.Windows.Forms.Button();
            this.GradeComboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MajorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CourseBox1 = new System.Windows.Forms.TextBox();
            this.ResultsButton1 = new System.Windows.Forms.Button();
            this.ResultsButton3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResultsButton4 = new System.Windows.Forms.Button();
            this.CourseBox2 = new System.Windows.Forms.TextBox();
            this.GradeComboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LessButton2 = new System.Windows.Forms.RadioButton();
            this.GreaterButton2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LessButton3 = new System.Windows.Forms.RadioButton();
            this.GreaterButton3 = new System.Windows.Forms.RadioButton();
            this.ResultsButton6 = new System.Windows.Forms.Button();
            this.ResultsButton5 = new System.Windows.Forms.Button();
            this.PercentageBox = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.MainOutputBox = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ZidBox
            // 
            this.ZidBox.Location = new System.Drawing.Point(61, 58);
            this.ZidBox.Name = "ZidBox";
            this.ZidBox.Size = new System.Drawing.Size(100, 20);
            this.ZidBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LessButton1);
            this.groupBox1.Controls.Add(this.GreaterButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // LessButton1
            // 
            this.LessButton1.AutoSize = true;
            this.LessButton1.Location = new System.Drawing.Point(17, 14);
            this.LessButton1.Name = "LessButton1";
            this.LessButton1.Size = new System.Drawing.Size(129, 17);
            this.LessButton1.TabIndex = 5;
            this.LessButton1.TabStop = true;
            this.LessButton1.Text = "Less Than or Equal to";
            this.LessButton1.UseVisualStyleBackColor = true;
            // 
            // GreaterButton1
            // 
            this.GreaterButton1.AutoSize = true;
            this.GreaterButton1.Location = new System.Drawing.Point(17, 43);
            this.GreaterButton1.Name = "GreaterButton1";
            this.GreaterButton1.Size = new System.Drawing.Size(142, 17);
            this.GreaterButton1.TabIndex = 6;
            this.GreaterButton1.TabStop = true;
            this.GreaterButton1.Text = "Greater Than or Equal to";
            this.GreaterButton1.UseVisualStyleBackColor = true;
            this.GreaterButton1.CheckedChanged += new System.EventHandler(this.GreaterButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ZID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grade Report for One Student";
            // 
            // ResultsButton2
            // 
            this.ResultsButton2.Location = new System.Drawing.Point(382, 156);
            this.ResultsButton2.Name = "ResultsButton2";
            this.ResultsButton2.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton2.TabIndex = 16;
            this.ResultsButton2.Text = "Show Results";
            this.ResultsButton2.UseVisualStyleBackColor = true;
            this.ResultsButton2.Click += new System.EventHandler(this.ResultsButton2_Click);
            // 
            // GradeComboBox1
            // 
            this.GradeComboBox1.FormattingEnabled = true;
            this.GradeComboBox1.Location = new System.Drawing.Point(227, 127);
            this.GradeComboBox1.Name = "GradeComboBox1";
            this.GradeComboBox1.Size = new System.Drawing.Size(58, 21);
            this.GradeComboBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Major Students who Failed a Course";
            // 
            // MajorComboBox
            // 
            this.MajorComboBox.FormattingEnabled = true;
            this.MajorComboBox.Location = new System.Drawing.Point(15, 256);
            this.MajorComboBox.Name = "MajorComboBox";
            this.MajorComboBox.Size = new System.Drawing.Size(119, 21);
            this.MajorComboBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Major";
            // 
            // CourseBox1
            // 
            this.CourseBox1.Location = new System.Drawing.Point(148, 256);
            this.CourseBox1.Name = "CourseBox1";
            this.CourseBox1.Size = new System.Drawing.Size(144, 20);
            this.CourseBox1.TabIndex = 24;
            // 
            // ResultsButton1
            // 
            this.ResultsButton1.Location = new System.Drawing.Point(382, 54);
            this.ResultsButton1.Name = "ResultsButton1";
            this.ResultsButton1.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton1.TabIndex = 25;
            this.ResultsButton1.Text = "Show Results";
            this.ResultsButton1.UseVisualStyleBackColor = true;
            this.ResultsButton1.Click += new System.EventHandler(this.ResultsButton1_Click);
            // 
            // ResultsButton3
            // 
            this.ResultsButton3.Location = new System.Drawing.Point(382, 252);
            this.ResultsButton3.Name = "ResultsButton3";
            this.ResultsButton3.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton3.TabIndex = 26;
            this.ResultsButton3.Text = "Show Results";
            this.ResultsButton3.UseVisualStyleBackColor = true;
            this.ResultsButton3.Click += new System.EventHandler(this.ResultsButton3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Grade report for One Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Course";
            // 
            // ResultsButton4
            // 
            this.ResultsButton4.Location = new System.Drawing.Point(382, 314);
            this.ResultsButton4.Name = "ResultsButton4";
            this.ResultsButton4.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton4.TabIndex = 30;
            this.ResultsButton4.Text = "Show Results";
            this.ResultsButton4.UseVisualStyleBackColor = true;
            this.ResultsButton4.Click += new System.EventHandler(this.ResultsButton4_Click);
            // 
            // CourseBox2
            // 
            this.CourseBox2.Location = new System.Drawing.Point(58, 324);
            this.CourseBox2.Name = "CourseBox2";
            this.CourseBox2.Size = new System.Drawing.Size(144, 20);
            this.CourseBox2.TabIndex = 29;
            // 
            // GradeComboBox2
            // 
            this.GradeComboBox2.FormattingEnabled = true;
            this.GradeComboBox2.Location = new System.Drawing.Point(228, 552);
            this.GradeComboBox2.Name = "GradeComboBox2";
            this.GradeComboBox2.Size = new System.Drawing.Size(60, 21);
            this.GradeComboBox2.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LessButton2);
            this.groupBox2.Controls.Add(this.GreaterButton2);
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // LessButton2
            // 
            this.LessButton2.AutoSize = true;
            this.LessButton2.Location = new System.Drawing.Point(17, 15);
            this.LessButton2.Name = "LessButton2";
            this.LessButton2.Size = new System.Drawing.Size(129, 17);
            this.LessButton2.TabIndex = 5;
            this.LessButton2.TabStop = true;
            this.LessButton2.Text = "Less Than or Equal to";
            this.LessButton2.UseVisualStyleBackColor = true;
            // 
            // GreaterButton2
            // 
            this.GreaterButton2.AutoSize = true;
            this.GreaterButton2.Location = new System.Drawing.Point(17, 44);
            this.GreaterButton2.Name = "GreaterButton2";
            this.GreaterButton2.Size = new System.Drawing.Size(142, 17);
            this.GreaterButton2.TabIndex = 6;
            this.GreaterButton2.TabStop = true;
            this.GreaterButton2.Text = "Greater Than or Equal to";
            this.GreaterButton2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Fail Report for all courses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Grade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Grade Threshold for One Course";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Pass Report for all courses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LessButton3);
            this.groupBox3.Controls.Add(this.GreaterButton3);
            this.groupBox3.Location = new System.Drawing.Point(14, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // LessButton3
            // 
            this.LessButton3.AutoSize = true;
            this.LessButton3.Location = new System.Drawing.Point(15, 19);
            this.LessButton3.Name = "LessButton3";
            this.LessButton3.Size = new System.Drawing.Size(129, 17);
            this.LessButton3.TabIndex = 5;
            this.LessButton3.TabStop = true;
            this.LessButton3.Text = "Less Than or Equal to";
            this.LessButton3.UseVisualStyleBackColor = true;
            // 
            // GreaterButton3
            // 
            this.GreaterButton3.AutoSize = true;
            this.GreaterButton3.Location = new System.Drawing.Point(15, 45);
            this.GreaterButton3.Name = "GreaterButton3";
            this.GreaterButton3.Size = new System.Drawing.Size(142, 17);
            this.GreaterButton3.TabIndex = 6;
            this.GreaterButton3.TabStop = true;
            this.GreaterButton3.Text = "Greater Than or Equal to";
            this.GreaterButton3.UseVisualStyleBackColor = true;
            // 
            // ResultsButton6
            // 
            this.ResultsButton6.Location = new System.Drawing.Point(382, 552);
            this.ResultsButton6.Name = "ResultsButton6";
            this.ResultsButton6.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton6.TabIndex = 38;
            this.ResultsButton6.Text = "Show Results";
            this.ResultsButton6.UseVisualStyleBackColor = true;
            this.ResultsButton6.Click += new System.EventHandler(this.ResultsButton6_Click);
            // 
            // ResultsButton5
            // 
            this.ResultsButton5.Location = new System.Drawing.Point(382, 443);
            this.ResultsButton5.Name = "ResultsButton5";
            this.ResultsButton5.Size = new System.Drawing.Size(86, 23);
            this.ResultsButton5.TabIndex = 39;
            this.ResultsButton5.Text = "Show Results";
            this.ResultsButton5.UseVisualStyleBackColor = true;
            this.ResultsButton5.Click += new System.EventHandler(this.ResultsButton5_Click);
            // 
            // PercentageBox
            // 
            this.PercentageBox.Location = new System.Drawing.Point(228, 447);
            this.PercentageBox.Name = "PercentageBox";
            this.PercentageBox.Size = new System.Drawing.Size(39, 20);
            this.PercentageBox.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Percentage";
            // 
            // MainOutputBox
            // 
            this.MainOutputBox.Location = new System.Drawing.Point(493, 53);
            this.MainOutputBox.Name = "MainOutputBox";
            this.MainOutputBox.Size = new System.Drawing.Size(372, 501);
            this.MainOutputBox.TabIndex = 42;
            this.MainOutputBox.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(612, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Query Results";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 44;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 595);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MainOutputBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PercentageBox);
            this.Controls.Add(this.ResultsButton5);
            this.Controls.Add(this.ResultsButton6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GradeComboBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResultsButton4);
            this.Controls.Add(this.CourseBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResultsButton3);
            this.Controls.Add(this.ResultsButton1);
            this.Controls.Add(this.CourseBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MajorComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GradeComboBox1);
            this.Controls.Add(this.ResultsButton2);
            this.Controls.Add(this.ZidBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GradeForm";
            this.Text = "NIU Academic Performance Query System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ZidBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LessButton1;
        private System.Windows.Forms.RadioButton GreaterButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultsButton2;
        private System.Windows.Forms.ComboBox GradeComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MajorComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CourseBox1;
        private System.Windows.Forms.Button ResultsButton1;
        private System.Windows.Forms.Button ResultsButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResultsButton4;
        private System.Windows.Forms.TextBox CourseBox2;
        private System.Windows.Forms.ComboBox GradeComboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton LessButton2;
        private System.Windows.Forms.RadioButton GreaterButton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton LessButton3;
        private System.Windows.Forms.RadioButton GreaterButton3;
        private System.Windows.Forms.Button ResultsButton6;
        private System.Windows.Forms.Button ResultsButton5;
        private System.Windows.Forms.NumericUpDown PercentageBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox MainOutputBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}

