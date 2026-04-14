using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using StudentRegistWinformTejo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentRegistWinformTejo.Menu;
using static StudentRegistWinformTejo.StudentList;
using static StudentRegistWinformTejo.StudentRegistration;

namespace StudentRegistWinformTejo
{
    public partial class EditStudentInformation : Form
    {
        public Student? selectedStudent;

        public EditStudentInformation()
        {
            InitializeComponent();
            //students = selectedStudent;
            
            //LoadStudentData();
        }

        private void LoadStudentData()
        {
            txtFirstName.Text = selectedStudent.FirstName;
            txtLastName.Text = selectedStudent.LastName;
            txtMiddleInitial.Text = selectedStudent.MiddleInitial;
            cmbGender.Text = selectedStudent.Gender;
            dtpBirthdate.Value = selectedStudent.Birthdate.Value;
            txtAddress.Text = selectedStudent.Address;
            cmbCourse.Text = selectedStudent.Course
            //year = selectedStudent.Year;
             = selectedStudent.ImageBase64;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EditStudentInformation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var list = LoadJson();
            students = new BindingList<Models.Student>(list);

            //dataGridView1.DataSource = students;
        }

        //private void SaveJsonFile()
        //{
        //    string json = JsonConvert.SerializeObject(students.ToList(), Formatting.Indented);
        //    File.WriteAllText("Students.json", json);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //SaveJsonFile();
            selectedStudent.FirstName = txtFirstName.Text;
            selectedStudent.LastName = txtLastName.Text;
            selectedStudent.MiddleInitial = txtMiddleInitial.Text;
            selectedStudent.Gender = cmbGender.Text;
            selectedStudent.Birthdate = dtpBirthdate.Value.Date;
            selectedStudent.Address = txtAddress.Text;
            selectedStudent.Course = cmbCourse.Text;
            //selectedStudent.Year = txtyear.Text;
            //selectedStudent.ImageBase64 = StudentRegistration.ConvertImageToBase64();

            //JsonHelper.SaveStudents();
        }
    }
}
