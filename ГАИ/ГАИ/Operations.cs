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
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Сitizen i = new Сitizen();
            Hide();
            i.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Violations v = new Violations();
            Hide();
            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rules r = new Rules();
            Hide();
            r.Show();
        }
    }
}
