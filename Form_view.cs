using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test14032023
{
    public partial class Form_view : Form
    {
        public Form_view()
        {
            InitializeComponent();
        }

        private void Form_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "safinIsp491_tradeDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.safinIsp491_tradeDataSet.Product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_red fm = new Form_red();
            fm.Show();
        }
    }
}
