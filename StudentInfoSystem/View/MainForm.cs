using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Data;
using StudentInfoSystem.Logic;

namespace StudentInfoSystem.View
{
    public partial class MainForm : Form
    {
        public UserStatus userStatus { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Оценки_Click(object sender, EventArgs e)
        {

        }

        private void Студент_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Iztrivane()
        {
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox1.Text = String.Empty;
        }
        private void Imenuvane (Student st)
        {
          
            textBox3.Text = st.FirstName;
            textBox4.Text = st.SecondName;
            textBox5.Text = st.LastName;
            textBox2.Text = st.Faculty;
            textBox6.Text = st.Potok;

            //textBox3.Text = "Petar";
            //textBox4.Text = "Ivanov";
            //textBox5.Text = "Georgiev";
            //textBox2.Text = "FKSU";
            //textBox6.Text = "KST";
        }
        public void disableControls()
        {
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = false;
            label8.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            comboBox1.Enabled = false;
        }
        public void enableControls()
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox2.Enabled = true;
            textBox6.Enabled = true;
            label8.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm aForm = new LoginForm();
            DialogResult result = aForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Imenuvane();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {

    }
            private void buttonDelete_Click(object sender, EventArgs e)
        {
            Iztrivane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disableControls();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enableControls();
        }

        public void checkLogin(User user)
        {
           Student st =  StudentValidation.IsThereStudent(user);
          
            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:
                    Iztrivane();
                    disableControls();
                    break;
                case UserStatus.STUDENT:
                    Imenuvane(st);
                    break;
                case UserStatus.ADMIN:
                    Imenuvane(st);
                    break;
                default:
                    break;
            }
        {

        }
    
    }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
        
        }
    }
}

