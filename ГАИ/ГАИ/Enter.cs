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

namespace ГАИ
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
            string sqlExpression = "SELECT * FROM Инспектор_ГАИ  where ФИО='" + textBox1.Text + "'"
                + "and Пароль = '" + textBox2.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    label2.Text = "Загрузка...";
                    Operations a = new Operations();
                    Hide();
                    a.Show();
                }
                else
                    label2.Text = "Ошибка авторизации";
                reader.Close();
            }

            Console.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
