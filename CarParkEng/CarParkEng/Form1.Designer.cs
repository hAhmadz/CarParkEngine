namespace CarParkEng
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExitDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EntryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EntryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.currDateLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tally Car Park";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entry Time";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.outputLbl);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.calculateBtn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(35, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 422);
            this.panel1.TabIndex = 4;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(384, 294);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 35);
            this.outputLbl.TabIndex = 9;
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.SeaShell;
            this.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Navy;
            this.resetBtn.Location = new System.Drawing.Point(509, 173);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(220, 78);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Clear";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.Honeydew;
            this.calculateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.ForeColor = System.Drawing.Color.Navy;
            this.calculateBtn.Location = new System.Drawing.Point(283, 173);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(220, 78);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExitTimePicker);
            this.groupBox2.Controls.Add(this.ExitDatePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(509, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 134);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit";
            // 
            // ExitTimePicker
            // 
            this.ExitTimePicker.CustomFormat = "";
            this.ExitTimePicker.Font = new System.Drawing.Font("Myriad Hebrew", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExitTimePicker.Location = new System.Drawing.Point(179, 91);
            this.ExitTimePicker.Name = "ExitTimePicker";
            this.ExitTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitTimePicker.ShowUpDown = true;
            this.ExitTimePicker.Size = new System.Drawing.Size(273, 34);
            this.ExitTimePicker.TabIndex = 7;
            this.ExitTimePicker.Value = new System.DateTime(2019, 1, 31, 21, 0, 0, 0);
            // 
            // ExitDatePicker
            // 
            this.ExitDatePicker.CustomFormat = "";
            this.ExitDatePicker.Font = new System.Drawing.Font("Myriad Hebrew", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExitDatePicker.Location = new System.Drawing.Point(179, 38);
            this.ExitDatePicker.Name = "ExitDatePicker";
            this.ExitDatePicker.Size = new System.Drawing.Size(273, 34);
            this.ExitDatePicker.TabIndex = 6;
            this.ExitDatePicker.Value = new System.DateTime(2019, 1, 31, 21, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exit Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Hebrew", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "ExitTime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EntryTimePicker);
            this.groupBox1.Controls.Add(this.EntryDatePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry";
            // 
            // EntryTimePicker
            // 
            this.EntryTimePicker.CustomFormat = "";
            this.EntryTimePicker.Font = new System.Drawing.Font("Myriad Hebrew", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EntryTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EntryTimePicker.Location = new System.Drawing.Point(191, 91);
            this.EntryTimePicker.Name = "EntryTimePicker";
            this.EntryTimePicker.ShowUpDown = true;
            this.EntryTimePicker.Size = new System.Drawing.Size(273, 34);
            this.EntryTimePicker.TabIndex = 5;
            this.EntryTimePicker.Value = new System.DateTime(2019, 1, 31, 21, 0, 0, 0);
            // 
            // EntryDatePicker
            // 
            this.EntryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryDatePicker.CustomFormat = "";
            this.EntryDatePicker.Font = new System.Drawing.Font("Myriad Hebrew", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EntryDatePicker.Location = new System.Drawing.Point(191, 38);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(273, 34);
            this.EntryDatePicker.TabIndex = 4;
            this.EntryDatePicker.Value = new System.DateTime(2019, 1, 31, 21, 0, 0, 0);
            this.EntryDatePicker.ValueChanged += new System.EventHandler(this.EntryDatePicker_ValueChanged);
            // 
            // currDateLbl
            // 
            this.currDateLbl.AutoSize = true;
            this.currDateLbl.Font = new System.Drawing.Font("Myriad Hebrew", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currDateLbl.Location = new System.Drawing.Point(12, 506);
            this.currDateLbl.Name = "currDateLbl";
            this.currDateLbl.Size = new System.Drawing.Size(0, 24);
            this.currDateLbl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1066, 535);
            this.Controls.Add(this.currDateLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TallyIT Car Park";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EntryDatePicker;
        private System.Windows.Forms.DateTimePicker ExitTimePicker;
        private System.Windows.Forms.DateTimePicker ExitDatePicker;
        private System.Windows.Forms.DateTimePicker EntryTimePicker;
        private System.Windows.Forms.Label currDateLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

