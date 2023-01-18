using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consumatori
{
    public partial class Consumatori : Form
    {
        enum ListaNume
        {
            Andrei,
            Marius,
            George,
            Enache,
            Mihai,
            Aurel,
            Adrian,
            Spiridon,

        }

        public Consumatori()
        {
            InitializeComponent();
        }

        List<Comanda> comenzi = new List<Comanda>();
        private void DisplayOrders(List<Comanda> filteredOrders)
        {
            listView1.Items.Clear();
            foreach (var comanda in filteredOrders)
            {
                listView1.Items.Add(comanda.ToString());
            }
        }


        private void Consumatori_Load(object sender, EventArgs e)
        {

            //Sursa de date
            comenzi.Add(new Comanda
            {
                comandaID = 1,
                Consumator = ListaNume.Andrei.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Calculator", Cantitate = 10, Pret = 10.35m},
                    new Articole(){Descriere = "Caiete", Cantitate = 9, Pret = 7.35m},
                    new Articole(){Descriere = "Creioane", Cantitate = 20, Pret = 12.25m},
                    new Articole(){Descriere = "Stilouri", Cantitate = 30, Pret = 20.35m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 2,
                Consumator = ListaNume.Marius.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Hartie", Cantitate = 10, Pret = 7.35m},
                    new Articole(){Descriere = "Detergent", Cantitate = 9, Pret = 8.35m},
                    new Articole(){Descriere = "Pixuri", Cantitate = 10, Pret = 10.25m},
                    new Articole(){Descriere = "Agrafe", Cantitate = 30, Pret = 6.35m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 3,
                Consumator = ListaNume.George.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Blocuri de Desen", Cantitate = 9, Pret = 20.35m},
                    new Articole(){Descriere = "Carti", Cantitate = 5, Pret = 7.35m},
                    new Articole(){Descriere = "Detergent", Cantitate = 8, Pret = 12.25m},                    
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 4,
                Consumator = ListaNume.Enache.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Calculator", Cantitate = 20, Pret = 8.35m},
                    new Articole(){Descriere = "Caiete", Cantitate = 15, Pret = 7.35m},                   
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 5,
                Consumator = ListaNume.Andrei.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Calculator", Cantitate = 20, Pret = 10.35m},
                    new Articole(){Descriere = "Caiete", Cantitate = 15, Pret = 7.35m},
                    new Articole(){Descriere = "Creioane", Cantitate = 2, Pret = 12.25m},
                    new Articole(){Descriere = "Stilouri", Cantitate = 30, Pret = 20.35m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 6,
                Consumator = ListaNume.Marius.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Calculator", Cantitate = 10, Pret = 7.35m},
                    new Articole(){Descriere = "Caiete", Cantitate = 9, Pret = 8.35m},
                    new Articole(){Descriere = "Creioane", Cantitate = 20, Pret = 12.25m},
                    new Articole(){Descriere = "Stilouri", Cantitate = 30, Pret = 10.35m},
                    new Articole(){Descriere = "Tablete", Cantitate = 35, Pret = 10.40m},
                }
            });
            
            comenzi.Add(new Comanda
            {
                comandaID = 7,
                Consumator = ListaNume.Mihai.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Plansa", Cantitate = 5, Pret = 15.35m},
                    new Articole(){Descriere = "Carioci", Cantitate = 8, Pret = 9.35m},
                    new Articole(){Descriere = "Capsatoare", Cantitate = 21, Pret = 12.25m},
                    new Articole(){Descriere = "Pensare", Cantitate = 18, Pret = 9.50m},
                    new Articole(){Descriere = "Tablete", Cantitate = 25, Pret = 24.40m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 8,
                Consumator = ListaNume.Aurel.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Benzi", Cantitate = 5, Pret = 15.35m},
                    new Articole(){Descriere = "Mape", Cantitate = 8, Pret = 9.35m},
                    new Articole(){Descriere = "Carti de joc", Cantitate = 21, Pret = 2.25m},
                    new Articole(){Descriere = "Jucarii Nerf", Cantitate = 8, Pret = 90.55m},
                    new Articole(){Descriere = "Aparate Radio", Cantitate = 2, Pret = 264.64m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 9,
                Consumator = ListaNume.Adrian.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Aparat foto", Cantitate = 1, Pret = 356.35m},
                    new Articole(){Descriere = "Carti de joc", Cantitate = 25, Pret = 2.25m},
                    new Articole(){Descriere = "Detergent", Cantitate = 8, Pret = 12.25m},
                }
            });

            comenzi.Add(new Comanda
            {
                comandaID = 10,
                Consumator = ListaNume.Spiridon.ToString(),
                Articole = new List<Articole>()
                {
                    new Articole(){Descriere = "Forma prajitura", Cantitate = 20, Pret = 10.35m},
                    new Articole(){Descriere = "Mocheta", Cantitate = 15, Pret = 7.35m},
                    new Articole(){Descriere = "Sistem de Supraveghere", Cantitate = 2, Pret = 12.25m},
                    new Articole(){Descriere = "Laser", Cantitate = 30, Pret = 20.35m},
                }
            });




            //Interogarea Linq pentru total costuri/consumator
            foreach (Comanda comanda in comenzi)
            {
                var totalCost = from a in comanda.Articole
                                select a.Pret * a.Cantitate;


                //Total cost pe fiecare consumator
                comanda.TotalCost = totalCost.Sum();
            }
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            var totalComenzi = from Comanda comanda in comenzi
                               select comanda;
                                    //comanda.comandaID + "\t" +
                                    //comanda.Consumator + "\t" +
                                    //comanda.TotalCost.ToString();

            ListaAfisare.DataSource = totalComenzi.ToArray();
        }

        private void btnListaCosturi_Click(object sender, EventArgs e)
        {
            var totalComenzi = from Comanda comanda in comenzi
                               orderby comanda.TotalCost descending
                               select comanda;
            

            ListaAfisare.DataSource = totalComenzi.ToArray();
        }

        private void btnConsumator_Click(object sender, EventArgs e)
        {
            string nume = cbmConsumatori.Text;

            var totalComenzi = from Comanda comanda in comenzi
                               where comanda.Consumator == nume
                               select comanda;
            

            ListaAfisare.DataSource = totalComenzi.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal numar;
            decimal.TryParse(txtMaiMareDecat.Text, out numar);

            var totalComenzi = from Comanda comanda in comenzi
                               where comanda.TotalCost > numar
                               select comanda;
            

            ListaAfisare.DataSource = totalComenzi.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var comanda in comenzi)
            {
               
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTextBox.Text, out id))
            {
                var filteredOrders = comenzi.Where(x => x.comandaID == id).ToList();
                DisplayOrders(filteredOrders);
            }
            else
            {
                var filteredOrders = comenzi.Where(x => x.Consumator == searchTextBox.Text).ToList();
                DisplayOrders(filteredOrders);
            }
        }

        private void cbmConsumatori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
