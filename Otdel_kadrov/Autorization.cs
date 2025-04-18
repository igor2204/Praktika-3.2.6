using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otdel_kadrov
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogin();
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            DirectorLogin();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin();
        }
        private void EmployeeLogin()
        {
            MessageBox.Show("Добро пожаловать, сотрудник!");
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }

        private void AdminLogin()
        {
            MessageBox.Show("Добро пожаловать, администратор!");
            Administrator AdministratorForm = new Administrator();
            AdministratorForm.Show();
            this.Hide();
        }

        private void DirectorLogin()
        {
            MessageBox.Show("Добро пожаловать, руководитель!");
            Directors directorsForm = new Directors();
            directorsForm.Show();
            this.Hide();
        }
    }
}
