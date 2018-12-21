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
    public partial class NewOrderForm : Form
    {
        RoomForm room = new RoomForm();
        RestaurantForm rf = new RestaurantForm();
        public NewOrderForm()
        {
            InitializeComponent();
            room.Hide();
            rf.Hide();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            room.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rf.Show();
        }
    }
}
