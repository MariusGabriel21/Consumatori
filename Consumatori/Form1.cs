using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumatori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Consumatori f2 = new Consumatori();
            f2.ShowDialog();
            string mesaj = "Eroare 30x25";
            string antet = "Mesaj de eroare";
            MessageBox.Show(mesaj, antet);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Equals(textBox1.Text) &&
            pass.Equals(user.Text))
                 {
                Consumatori f2 = new Consumatori();
                f2.ShowDialog();
                 }
             else
                 {
                Consumatori f3 = new Consumatori();
                f3.ShowDialog();
                 }
             }
 }
}
