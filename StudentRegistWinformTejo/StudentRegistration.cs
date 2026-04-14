using Microsoft.VisualBasic;
using Newtonsoft.Json;
using StudentRegistWinformTejo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentRegistWinformTejo.StudentList;

namespace StudentRegistWinformTejo
{
    public partial class StudentRegistration : Form
    {

        public string selectedImagePath;

        public StudentRegistration()
        {
            InitializeComponent();
        }

        public void StudentRegistration_Load(object sender, EventArgs e)
        {
            cmbGender.Items.AddRange(new string[]
            {
                "Male",
                "Female"
            });

            cmbCourse.Items.AddRange(new string[]
            {
                "Bachelor of Science of Information Technology",
                "Bachelor of Science of Mechanical Engineering"
            });
            StudentList.LoadJson();

            dtpBirthdate.Format = DateTimePickerFormat.Custom;
            dtpBirthdate.CustomFormat = "yyyy-MM-dd";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRegistration regForm = new StudentRegistration();
            regForm.Show();
        }

        private void SavejSON()
        {
            string json = JsonConvert.SerializeObject(Menu.students.ToList(), Formatting.Indented);
            File.WriteAllText("Students.json", json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();

            ofdImageBase64.SizeMode = PictureBoxSizeMode.Zoom;

            image.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (image.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = image.FileName;
                ofdImageBase64.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtMiddleInitial.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Invalid Please fill all fields.");
                    return;
                }

                int year;
                if (!int.TryParse(txtYear.Text, out year) !& year <= 4 !& year >= 1)
                {
                    MessageBox.Show("Invalid, Please enter year level.");
                }

                Menu.students.Add(new Student
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleInitial = txtMiddleInitial.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    Birthdate = dtpBirthdate.Value.Date,
                    Address = txtAddress.Text,
                    Course = cmbCourse.SelectedItem.ToString(),
                    Year = year,
                    ImageBase64 = ConvertImageToBase64(selectedImagePath)
                });

                SavejSON();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtMiddleInitial.Clear();
                txtAddress.Clear();
                txtYear.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu regForm = new Menu();
            regForm.Show();
            this.Close();
        }

        public string ConvertImageToBase64(string path)
        {
            byte[] imageBytes = File.ReadAllBytes(path);
            return Convert.ToBase64String(imageBytes);
        }
    }
}
