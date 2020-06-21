using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГАИ
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Статья". При необходимости она может быть перемещена или удалена.
            this.статьяTableAdapter.Fill(this.гАИDataSet.Статья);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гАИDataSet.Раздел". При необходимости она может быть перемещена или удалена.
            this.разделTableAdapter.Fill(this.гАИDataSet.Раздел);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operations h = new Operations();
            Hide();
            h.Show();
        }
    }
}
