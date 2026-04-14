using Newtonsoft.Json;
using StudentRegistWinformTejo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentRegistWinformTejo.EditStudentInformation;
using static StudentRegistWinformTejo.Menu;

namespace StudentRegistWinformTejo
{
    public partial class StudentList : Form
    {
        public List<Models.Student>? students;
        public StudentList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration regForm = new StudentRegistration();
            regForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu regForm = new Menu();
            regForm.Show();
            this.Close();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            dataGridView1.AutoGenerateColumns = false;
        }

        public static List<Models.Student> LoadJson()
        {
            if (!File.Exists("Students.json"))
                return new List<Student>();

            string json = File.ReadAllText("Students.json");

            return JsonConvert.DeserializeObject<List<Student>>(json)!;
        }

        public void LoadDataGrid()
        {
            students = LoadJson();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students
            .Select(s => new
             {
                s.FirstName,
                s.LastName,
                s.Course

             })
            .ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Student selectedStudent = (Student)dataGridView1.Rows[e.RowIndex].DataBoundItem!;

            StudentInformation regForm = new StudentInformation(selectedStudent);
            regForm.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow == null) return;


        //}


    }
}
