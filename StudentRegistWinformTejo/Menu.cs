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

namespace StudentRegistWinformTejo
{
    public partial class Menu : Form
    {
        public static BindingList<Models.Student> students = new BindingList<Models.Student>();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration regForm = new StudentRegistration();
            regForm.Show();
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentList regform = new StudentList();
            regform.Show();
            this.Hide();
        }
    }
}
