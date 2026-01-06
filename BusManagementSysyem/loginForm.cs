using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManagementSysyem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        SqlDbType sqlDbType;
        private void button2_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();   
            signupForm.Show();
            this.Hide();
        }
    }
}
