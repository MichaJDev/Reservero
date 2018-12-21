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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            setDateTimeMinimum();
            fillComboBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReservation();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
        }

        public void ClearForm()
        {
            tbNaam.Clear();
            tbAdres.Clear();
            tbWoonplaats.Clear();
            tbTelefoon.Clear();
            cbPersonen.SelectedIndex = 0;
            cbKamer.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            MessageBox.Show("Formulier gereset!");
        }

        private void tbTelefoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void setDateTimeMinimum()
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }
        private void fillComboBoxes()
        {
            for (int i = 0; i < 4; i++)
            {
                cbKamer.Items.Add(i + 1);
                cbPersonen.Items.Add(i + 1);
            }
            cbKamer.SelectedIndex = 0;
            cbPersonen.SelectedIndex = 0;
        }
        private void AddReservation()
        {
            MessageBox.Show("Reservatie Succesvol Opgeslagen!\n" +
                "Naam: " + tbNaam.Text + "\n" +
                "Adres: " + tbAdres.Text + "\n" +
                "Woonplaats: " + tbWoonplaats.Text + "\n" +
                "Telefoon: " + tbTelefoon.Text + "\n" +
                "Personen: " + cbPersonen.Text + "\n" +
                "Kamer: " + cbKamer.Text + "");
        }
    }
}
