using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Module4.Model;
using System.Windows.Forms;

namespace Module4.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Список картинок
        private List<int> pictures = new List<int>() { 3, 4, 1, 2 };
        //Модель для работы с БД
        private ModelEF modelEF = new ModelEF();
        //Авторизованный аккаунт
        private Accounts accounts;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //Поиск аккаунта в БД
            accounts =
                modelEF.Accounts.FirstOrDefault(
                    x => x.Login == textBoxLogin.Text
                && x.Password == textBoxPassword.Text);
            if (accounts != null)
            {
                if (accounts.StatusID == 1)
                {
                    panelCaptch.Visible = true;
                }
                else
                {
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                }
                return;
            }
            else
            {
                accounts =
               modelEF.Accounts.FirstOrDefault(
                   x => x.Login == textBoxLogin.Text);
                if (accounts != null)
                {
                    if (accounts.StatusID == 2)
                    {
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                        return;
                    }
                    accounts.BadLoginTry += 1;
                    modelEF.SaveChanges();
                    MessageBox.Show($"Вы не правильно ввели пароль. У вас осталось попыток {3 - accounts.BadLoginTry}");
                    if (accounts.BadLoginTry == 3)
                    {
                        accounts.StatusID = 2;
                        modelEF.SaveChanges();
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                }
            }

        }

        private void LoadPictures()
        {
            pictureBoxCaptch1.Image = Image.FromFile($@"Pictures\{pictures[0]}.png");
            pictureBoxCaptch2.Image = Image.FromFile($@"Pictures\{pictures[1]}.png");
            pictureBoxCaptch3.Image = Image.FromFile($@"Pictures\{pictures[2]}.png");
            pictureBoxCaptch4.Image = Image.FromFile($@"Pictures\{pictures[3]}.png");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPictures();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (pictures[0] == 1)
            {
                panelCaptch.Visible = false;
                if (accounts.RoleID == 1)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                    Hide();
                }
                else if (accounts.RoleID == 2)
                {
                    UserForm form = new UserForm();
                    form.Show();
                    Hide();
                }
                accounts.BadLoginTry = 0;
                modelEF.SaveChanges();
                MessageBox.Show("Вы успешно авторизовались");
            }
            else
            {
                accounts.BadLoginTry += 1;
                modelEF.SaveChanges();
                MessageBox.Show($"Каптча не правильная осталось попыток {3 - accounts.BadLoginTry}");
                if (accounts.BadLoginTry >= 3)
                {
                    accounts.StatusID = 2;
                    modelEF.SaveChanges();
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    panelCaptch.Visible = false;
                }
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            int first = pictures[0];
            pictures[0] = pictures[1];
            pictures[1] = pictures[2];
            pictures[2] = pictures[3];
            pictures[3] = first;
            LoadPictures();
        }
    }
}
