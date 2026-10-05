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

        // Список картинок капчи. Хранит порядок отображения изображений.
        // Изначальный порядок: 3, 4, 1, 2.
        private List<int> pictures = new List<int>() { 3, 4, 1, 2 };

        // Модель Entity Framework для работы с базой данных
        private ModelEF modelEF = new ModelEF();

        // Авторизованный аккаунт (заполняется после успешного входа)
        private Accounts accounts;

        // Обработчик нажатия кнопки "Войти"
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Поиск аккаунта в БД по логину и паролю
            accounts =
                modelEF.Accounts.FirstOrDefault(
                    x => x.Login == textBoxLogin.Text
                && x.Password == textBoxPassword.Text);

            // Если аккаунт найден (логин и пароль совпали)
            if (accounts != null)
            {
                // Если статус аккаунта = 1 (активен) — показываем капчу
                if (accounts.StatusID == 1)
                {
                    panelCaptch.Visible = true;
                }
                else
                {
                    // Иначе аккаунт заблокирован
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                }
                return;
            }
            else
            {
                // Если аккаунт с таким логином и паролем не найден,
                // ищем аккаунт только по логину (чтобы проверить, существует ли пользователь)
                accounts =
               modelEF.Accounts.FirstOrDefault(
                   x => x.Login == textBoxLogin.Text);

                if (accounts != null)
                {
                    // Если аккаунт заблокирован (статус 2) — выводим сообщение
                    if (accounts.StatusID == 2)
                    {
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                        return;
                    }

                    // Увеличиваем счётчик неудачных попыток входа
                    accounts.BadLoginTry += 1;
                    modelEF.SaveChanges();
                    MessageBox.Show($"Вы не правильно ввели пароль. У вас осталось попыток {3 - accounts.BadLoginTry}");

                    // Если количество неудачных попыток достигло 3 — блокируем аккаунт
                    if (accounts.BadLoginTry == 3)
                    {
                        accounts.StatusID = 2;
                        modelEF.SaveChanges();
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    }
                }
                else
                {
                    // Логин не найден в базе данных
                    MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                }
            }
        }

        // Загрузка изображений капчи в PictureBox'ы согласно списку pictures
        private void LoadPictures()
        {
            pictureBoxCaptch1.Image = Image.FromFile($@"Pictures\{pictures[0]}.png");
            pictureBoxCaptch2.Image = Image.FromFile($@"Pictures\{pictures[1]}.png");
            pictureBoxCaptch3.Image = Image.FromFile($@"Pictures\{pictures[2]}.png");
            pictureBoxCaptch4.Image = Image.FromFile($@"Pictures\{pictures[3]}.png");
        }

        // Обработчик загрузки главной формы — загружаем картинки капчи
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPictures();
        }

        // Обработчик нажатия кнопки "Готово" (проверка капчи)
        private void buttonReady_Click(object sender, EventArgs e)
        {
            // Если первая картинка в списке — правильная (номер 1)
            if (pictures[0] == 1)
            {
                // Скрываем панель капчи
                panelCaptch.Visible = false;

                // Открываем форму в зависимости от роли пользователя:
                // RoleID = 1 — администратор, RoleID = 2 — обычный пользователь
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

                // Сбрасываем счётчик неудачных попыток входа
                accounts.BadLoginTry = 0;
                modelEF.SaveChanges();
                MessageBox.Show("Вы успешно авторизовались");
            }
            else
            {
                // Капча введена неверно — увеличиваем счётчик неудачных попыток
                accounts.BadLoginTry += 1;
                modelEF.SaveChanges();
                MessageBox.Show($"Каптча не правильная осталось попыток {3 - accounts.BadLoginTry}");

                // Если попыток стало 3 и более — блокируем аккаунт
                if (accounts.BadLoginTry >= 3)
                {
                    accounts.StatusID = 2;
                    modelEF.SaveChanges();
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    panelCaptch.Visible = false;
                }
            }
        }

        // Обработчик нажатия кнопки "Вправо" — циклический сдвиг картинок капчи
        private void buttonRight_Click(object sender, EventArgs e)
        {
            // Сохраняем первую картинку
            int first = pictures[0];
            // Сдвигаем остальные элементы влево
            pictures[0] = pictures[1];
            pictures[1] = pictures[2];
            pictures[2] = pictures[3];
            // Первую картинку ставим в конец
            pictures[3] = first;
            // Перезагружаем изображения в PictureBox'ах
            LoadPictures();
        }
    }
}
