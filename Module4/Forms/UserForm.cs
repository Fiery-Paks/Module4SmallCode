using System;
using System.Windows.Forms;

namespace Module4.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            Close();
        }
    }
}
