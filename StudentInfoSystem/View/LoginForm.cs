using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using StudentInfoSystem.Data;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class LoginForm : Form
    {
        public User user { get; private set; }
        
        public LoginForm()
        {
            InitializeComponent();
            user = null;
        
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginValidation lv = new LoginValidation(textBox1.Text, textBox2.Text);
            User usr;
            if (lv.ValidateUserInput(out usr))
              
            {
                this.user = usr;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(lv.errText);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}



//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
