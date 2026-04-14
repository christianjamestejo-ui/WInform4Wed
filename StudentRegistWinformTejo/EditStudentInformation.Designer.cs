namespace StudentRegistWinformTejo
{
    partial class EditStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentInformation));
            cmbGender = new ComboBox();
            cmbCourse = new ComboBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            ofdImageBase64 = new PictureBox();
            label10 = new Label();
            year = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dtpBirthdate = new DateTimePicker();
            label5 = new Label();
            txtMiddleInitial = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ofdImageBase64).BeginInit();
            SuspendLayout();
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(285, 184);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(324, 23);
            cmbGender.TabIndex = 49;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(285, 242);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(324, 23);
            cmbCourse.TabIndex = 48;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.images;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(744, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 37);
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 316);
            button2.Name = "button2";
            button2.Size = new Size(98, 22);
            button2.TabIndex = 47;
            button2.Text = "Browse...";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Location = new Point(371, 387);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 15);
            linkLabel1.TabIndex = 45;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Add another?";
            // 
            // button1
            // 
            button1.Location = new Point(361, 364);
            button1.Name = "button1";
            button1.Size = new Size(98, 22);
            button1.TabIndex = 44;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdImageBase64
            // 
            ofdImageBase64.Location = new Point(389, 300);
            ofdImageBase64.Name = "ofdImageBase64";
            ofdImageBase64.Size = new Size(116, 56);
            ofdImageBase64.TabIndex = 43;
            ofdImageBase64.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(204, 315);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 42;
            label10.Text = "Image:";
            // 
            // year
            // 
            year.Location = new Point(285, 271);
            year.Name = "year";
            year.Size = new Size(324, 23);
            year.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(215, 274);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 40;
            label9.Text = "Year:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(193, 245);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 39;
            label8.Text = "Course:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(285, 213);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(324, 23);
            txtAddress.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(182, 216);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 37;
            label7.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(193, 187);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 36;
            label6.Text = "Gender:";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(285, 155);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(210, 23);
            dtpBirthdate.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(160, 158);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 34;
            label5.Text = "Birthdate:";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(285, 126);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(324, 23);
            txtMiddleInitial.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(105, 129);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 32;
            label4.Text = "Middle Initial:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(285, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(324, 23);
            txtLastName.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(160, 100);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 30;
            label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(285, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(324, 23);
            txtFirstName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SimSun", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(149, 71);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 28;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(197, 10);
            label1.Name = "label1";
            label1.Size = new Size(395, 42);
            label1.TabIndex = 27;
            label1.Text = "Student Registration";
            // 
            // EditStudentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(cmbGender);
            Controls.Add(cmbCourse);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(ofdImageBase64);
            Controls.Add(label10);
            Controls.Add(year);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpBirthdate);
            Controls.Add(label5);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditStudentInformation";
            Text = "EditStudentInformation";
            Load += EditStudentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ofdImageBase64).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGender;
        private ComboBox cmbCourse;
        private PictureBox pictureBox2;
        private Button button2;
        private LinkLabel linkLabel1;
        private Button button1;
        public PictureBox ofdImageBase64;
        private Label label10;
        private TextBox year;
        private Label label9;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpBirthdate;
        private Label label5;
        private TextBox txtMiddleInitial;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
    }
}