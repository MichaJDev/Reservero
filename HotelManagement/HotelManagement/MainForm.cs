using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        NewOrderForm no = new NewOrderForm();
        ReservationsForm re = new ReservationsForm();
        public MainForm()
        {
            no.Hide();
            re.Hide();
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            re.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            no.Show();
        }
    }
}
