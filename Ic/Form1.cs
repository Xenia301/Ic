using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ic
{
    public partial class Form1 : Form
    {
        // Если хочешь хранить общую строку подключения — можно, но лучше строить её динамически
        // Здесь: фиксированный сервер/база, но логин/пароль подставляются из полей формы.
        private const string ServerInstance = @"DESKTOP-LMQFAO0\SQLEXPRESS";
        private const string DatabaseName = "InsuranceCompany";

        public Form1()
        {
            InitializeComponent();

            // Рекомендуется скрыть пароль в TextBox (можно выставить в дизайнере)
            txt_Password.PasswordChar = '●';
        }

        private void authorization_Click(object sender, EventArgs e)
        {
            // Валидация на пустые поля
            string user = txt_Login.Text?.Trim() ?? string.Empty;
            string pass = txt_Password.Text ?? string.Empty;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Блокируем кнопку, чтобы не было дублей
            authorization.Enabled = false;
            try
            {
                string message;
                // Выполняем подключение (можно сделать async, но для простоты синхронно)
                if (TrySqlLogin(user, pass, out message))
                {
                    // Успех — открываем следующую форму. Можно передать учётные данные/пользователя.
                    MessageBox.Show("Авторизация успешна!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var main = new Form2(); // при необходимости: new Form2(user)
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации: " + message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                // очищаем поле пароля и разблокируем кнопку
                txt_Password.Clear();
                authorization.Enabled = true;
            }
        }

        private void exit_program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Пытается открыть подключение к SQL Server с переданными учетными данными.
        /// Возвращает true при успешном Open(), иначе false и сообщение об ошибке в out parameter.
        /// </summary>
        public bool TrySqlLogin(string userId, string password, out string message)
        {
            // Собираем корректную строку подключения через SqlConnectionStringBuilder
            var csb = new SqlConnectionStringBuilder
            {
                // DataSource: можно указать "host\\instance" или "host,port"
                DataSource = $"{ServerInstance},1433", // явное указание порта 1433
                InitialCatalog = DatabaseName,
                UserID = userId,
                Password = password,
                IntegratedSecurity = false,
                ConnectTimeout = 5,
                TrustServerCertificate = true // если требуется принять самоподписанный сертификат
            };

            // Не показываем пароль в сообщениях — только для логики.
            try
            {
                using (var conn = new SqlConnection(csb.ConnectionString))
                {
                    conn.Open();
                    // можно дополнительно проверить, что пользователь действительно может подключиться к нужной БД:
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT DB_NAME()";
                        var db = cmd.ExecuteScalar() as string;
                        if (!string.Equals(db, DatabaseName, StringComparison.OrdinalIgnoreCase))
                        {
                            message = $"Подключение установлено, но база по умолчанию '{db}' не совпадает с '{DatabaseName}'.";
                            return false;
                        }
                    }

                    message = "Успешное подключение.";
                    return true;
                }
            }
            catch (SqlException sx)
            {
                // Более дружелюбные сообщения для частых ошибок
                switch (sx.Number)
                {
                    case 18456:
                        message = "Неверный логин или пароль (SQL Server отказал в доступе).";
                        break;
                    default:
                        message = sx.Message;
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // ничего делать не нужно
        }
    }
}