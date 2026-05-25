using System;
using System.Windows.Forms;

namespace Module4.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.module4DBDataSet);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "module4DBDataSet.Accounts". При необходимости она может быть перемещена или удалена.
            this.accountsTableAdapter.Fill(this.module4DBDataSet.Accounts);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            Close();
        }
    }
}
