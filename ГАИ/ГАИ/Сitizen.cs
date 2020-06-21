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
    public partial class Сitizen : Form
    {
        public Сitizen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operations z = new Operations();
            Hide();
            z.Show();
        }
        private void Сitizen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Протокол". При необходимости она может быть перемещена или удалена.
            this.протоколTableAdapter.Fill(this.гАИDataSet.Протокол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Список_статей". При необходимости она может быть перемещена или удалена.
            this.список_статейTableAdapter.Fill(this.гАИDataSet.Список_статей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Статья". При необходимости она может быть перемещена или удалена.
            this.статьяTableAdapter.Fill(this.гАИDataSet.Статья);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Список_Нарушений". При необходимости она может быть перемещена или удалена.
            this.список_НарушенийTableAdapter.Fill(this.гАИDataSet.Список_Нарушений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Гражданин". При необходимости она может быть перемещена или удалена.
            this.гражданинTableAdapter.Fill(this.гАИDataSet.Гражданин);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView1.Enabled = true;
            comboBox2.Enabled = true;
            string connectionString = "Data Source=N354;Initial Catalog=ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "SELECT * FROM Гражданин where ФИО ='" + textBox1.Text.ToString() + "' " + "and Номер_паспорта = '" + textBox2.Text.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    label3.Visible = true;
                    comboBox1.Enabled = true;
                    label5.Text = "Пол: " + reader.GetString(2); ;
                    label6.Text = "Дата рождения: " + reader.GetDateTime(3).ToShortDateString();
                    try { label7.Text = "Дата получения прав: " + reader.GetDateTime(4).ToShortDateString(); } catch { label7.Text = "Дата получения прав: нет"; }
                    label8.Text = "Контактный телефон: " + reader.GetString(6);
                    if (textBox1.Text == "Гудкова Маргарита Мефодиевна") { try { this.список_НарушенийTableAdapter.FillBy(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex){System.Windows.Forms.MessageBox.Show(ex.Message);}}
                    if (textBox1.Text == "Блинов Кир Алексеевич") { try { this.список_НарушенийTableAdapter.FillBy2(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Белозерцева Тамара Федоровна") { try { this.список_НарушенийTableAdapter.FillBy3(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Церетели Владилен Давидович") { try { this.список_НарушенийTableAdapter.FillBy4(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Волобуева Таисия Серафимовна") { try { this.список_НарушенийTableAdapter.FillBy5(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Сенькин Александр Матвеевич") { try { this.список_НарушенийTableAdapter.FillBy6(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Флёрова Юнона Федотовна") { try { this.список_НарушенийTableAdapter.FillBy7(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Еромеева Зоя Всеволодовна") { try { this.список_НарушенийTableAdapter.FillBy8(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Перешивкина Лиана Тимуровна") { try { this.список_НарушенийTableAdapter.FillBy9(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Абоимова Вера Иларионовна") { try { this.список_НарушенийTableAdapter.FillBy10(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Бирюкова Агния Серафимовна") { try { this.список_НарушенийTableAdapter.FillBy11(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Янсона Светлана Игоревна") { try { this.список_НарушенийTableAdapter.FillBy12(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Колганов Измаил Натанович") { try { this.список_НарушенийTableAdapter.FillBy13(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Карандашова Татьяна Несторовна") { try { this.список_НарушенийTableAdapter.FillBy14(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Костюк Геннадий Филиппович") { try { this.список_НарушенийTableAdapter.FillBy15(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Еремеева Валентина Юлиевна") { try { this.список_НарушенийTableAdapter.FillBy16(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Кузубова Доминика Николаевна") { try { this.список_НарушенийTableAdapter.FillBy17(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Шипицына Василиса Данииловна") { try { this.список_НарушенийTableAdapter.FillBy18(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Сталин Тимофей Демьянович") { try { this.список_НарушенийTableAdapter.FillBy19(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "Ягешева Антонина Афанасиевна") { try { this.список_НарушенийTableAdapter.FillBy20(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    if (textBox1.Text == "1") { try { this.список_НарушенийTableAdapter.FillBy21(this.гАИDataSet.Список_Нарушений); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }
                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                label3.Visible = true;
                label3.Text = "Ошибка";
                label3.BackColor = Color.Red;
            }           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            string connectionString = "Data Source=N354;Initial Catalog=ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "SELECT * FROM Статья where ID =" + comboBox1.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    label10.Text = "Штраф от " + reader.GetDecimal(5).ToString() +  " до " + reader.GetDecimal(6).ToString();
                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                label3.Visible = true;
                label3.Text = "Ошибка";
                label3.BackColor = Color.Red;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = 0;
            if (textBox1.Text == "Гудкова Маргарита Мефодиевна") { ID = 1; }
            if (textBox1.Text == "Блинов Кир Алексеевич") { ID = 2; }
            if (textBox1.Text == "Белозерцева Тамара Федоровна") { ID = 3; }
            if (textBox1.Text == "Церетели Владилен Давидович") { ID = 4; }
            if (textBox1.Text == "Волобуева Таисия Серафимовна") { ID = 5; }
            if (textBox1.Text == "Сенькин Александр Матвеевич") { ID = 6; }
            if (textBox1.Text == "Флёрова Юнона Федотовна") { ID = 7; }
            if (textBox1.Text == "Еромеева Зоя Всеволодовна") { ID = 8; }
            if (textBox1.Text == "Перешивкина Лиана Тимуровна") { ID = 9; }
            if (textBox1.Text == "Абоимова Вера Иларионовна") { ID = 10; }
            if (textBox1.Text == "Бирюкова Агния Серафимовна") { ID = 11; }
            if (textBox1.Text == "Янсона Светлана Игоревна") { ID = 12; }
            if (textBox1.Text == "Колганов Измаил Натанович") { ID = 13; }
            if (textBox1.Text == "Карандашова Татьяна Несторовна") { ID = 14; }
            if (textBox1.Text == "Костюк Геннадий Филиппович") { ID = 15; }
            if (textBox1.Text == "Еремеева Валентина Юлиевна") { ID = 16; }
            if (textBox1.Text == "Кузубова Доминика Николаевна") { ID = 17; }
            if (textBox1.Text == "Шипицына Василиса Данииловна") { ID = 18; }
            if (textBox1.Text == "Сталин Тимофей Демьянович") { ID = 19; }
            if (textBox1.Text == "Ягешева Антонина Афанасиевна") { ID = 20; }
            if (textBox1.Text == "1") { ID = 21; }
            string connectionString = "Data Source=N354;Initial Catalog=ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
            string sqlExpression = "INSERT INTO [ГАИ].[dbo].[Протокол]([ID_Гражданина],[ID_Статьи],[Дата_и_время_нарушения],[Сумма_штрафа])VALUES(" + ID.ToString() + "," + comboBox1.SelectedValue.ToString() + ", '" + System.DateTime.Now.Year.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Day.ToString() + "', " + Convert.ToDecimal(textBox3.Text).ToString() + ")";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                }
                label_ADD.Visible = true;
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
            button4.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            textBox4.Enabled = true;
            button7.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "DELETE FROM Протокол WHERE ID =" + comboBox2.SelectedValue.ToString() + ";";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                label_del.Visible = true;
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog= ГАИ;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "UPDATE Протокол SET [Сумма_штрафа] = '" + textBox4.Text.ToString() + "'" + "WHERE ID = " + comboBox2.SelectedValue;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                labe_edit_name.Visible = true;
            }
            catch (Exception)
            {
                labe_edit_name.BackColor = System.Drawing.Color.OrangeRed;
                labe_edit_name.Text = "Ошибка";
                labe_edit_name.Visible = true;
            }
        }
    }
}
