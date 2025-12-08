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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ic
{
    public partial class Form2 : Form
    {
        private readonly string _connectionString = @"Server=.\SQLEXPRESS;Database=InsuranceCompany;Trusted_Connection=True;";
       
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Деактивируем кнопки и комбобоксы (чтобы "не работали")
            // Если у вас другие имена контролов — замените их
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при инициализации формы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загружает данные из таблицы Dogovory в dataGridView1
        private void LoadData()
        {
            const string query = "SELECT * FROM dbo.Dogovory"; // при необходимости замените на другую таблицу

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Немного настроек отображения (необязательно)
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView1.ReadOnly = true; // чтобы нельзя было редактировать прямо в гриде
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
