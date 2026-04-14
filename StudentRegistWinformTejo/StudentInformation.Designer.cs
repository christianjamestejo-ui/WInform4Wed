namespace StudentRegistWinformTejo
{
    partial class StudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformation));
            ofdImageBase64 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtyear = new TextBox();
            label9 = new Label();
            cmbCourse = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            cmbGender = new TextBox();
            label6 = new Label();
            dtpBirthdate = new DateTimePicker();
            label5 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ofdImageBase64).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ofdImageBase64
            // 
            ofdImageBase64.BackColor = SystemColors.ControlDark;
            ofdImageBase64.Location = new Point(337, 12);
            ofdImageBase64.Name = "ofdImageBase64";
            ofdImageBase64.Size = new Size(139, 126);
            ofdImageBase64.TabIndex = 0;
            ofdImageBase64.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(748, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(315, 296);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(324, 23);
            txtyear.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(245, 299);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 32;
            label9.Text = "Year:";
            // 
            // cmbCourse
            // 
            cmbCourse.Location = new Point(315, 267);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(324, 23);
            cmbCourse.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(223, 270);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 30;
            label8.Text = "Course:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(315, 238);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(324, 23);
            txtAddress.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(212, 241);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 28;
            label7.Text = "Address:";
            // 
            // cmbGender
            // 
            cmbGender.Location = new Point(315, 209);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(324, 23);
            cmbGender.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(223, 212);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 26;
            label6.Text = "Gender:";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(315, 180);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(210, 23);
            dtpBirthdate.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(190, 183);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 24;
            label5.Text = "Birthdate:";
            // 
            // txtName
            // 
            txtName.Location = new Point(315, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 23);
            txtName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(245, 156);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 18;
            label2.Text = "Name:";
            // 
            // button1
            // 
            button1.Location = new Point(340, 365);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 34;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtyear);
            Controls.Add(label9);
            Controls.Add(cmbCourse);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(dtpBirthdate);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(ofdImageBase64);
            Name = "StudentInformation";
            Text = "StudentInformation";
            Load += StudentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)ofdImageBase64).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ofdImageBase64;
        private PictureBox pictureBox2;
        private TextBox txtyear;
        private Label label9;
        private TextBox cmbCourse;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private TextBox cmbGender;
        private Label label6;
        private DateTimePicker dtpBirthdate;
        private Label label5;
        private TextBox txtName;
        private Label label2;
        private Button button1;
    }
}