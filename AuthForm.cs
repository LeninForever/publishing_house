using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_1
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.Tag = false;
            button1.Image = kursach_1.Properties.Resources.eye_visible_hide_hidden_show_icon_145988__1_;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string _connectionString;
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Поле логина или пароля не должно быть пустым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                // DialogResult = DialogResult.Retry;
                return;
            }
            {
                _connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=publishing_house;" +
                $"User ID={textBoxLogin.Text.Trim()}; Password = {textBoxPassword.Text.Trim()}";
            }
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                DialogResult = DialogResult.OK;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введён логин или пароль", "Ошибка при подключении", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            Properties.Settings.Default.publishing_houseConnectionString = _connectionString;
            DBHelper.UserName = textBoxLogin.Text.Trim();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isShoiwing = (bool)button1.Tag;

            if (!isShoiwing)
            {
                button1.Image = kursach_1.Properties.Resources.view_hide_icon_124813__1_;
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                button1.Image = kursach_1.Properties.Resources.eye_visible_hide_hidden_show_icon_145988__1_;
                textBoxPassword.UseSystemPasswordChar = true;
            }
            button1.Tag = !isShoiwing;
        }
    }



}
