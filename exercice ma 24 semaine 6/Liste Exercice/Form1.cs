using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arche_de_Noé
{
    public partial class Form1 : Form
    {
        List<string> l1;
        string selectedItemText;
        int SelectedIndex;


        public Form1()
        {
            InitializeComponent();
            l1 = new List<string>();
            l1.Add("Araignée");
            l1.Add("Chat");
            l1.Add("Cheval");
            l1.Add("Chien");
            l1.Add("Cobra");
            l1.Add("Coccinelle");
            l1.Add("Kangourou");
            l1.Add("Perroquet");
            l1.Add("Rat");
            l1.Add("Ver de terre");

            listTerre.DataSource = l1;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdTerreToBord_Click(object sender, EventArgs e)
        {
            
        
            if (listTerre.SelectedItem != null /*&& l1 !=null*/)
            {
                selectedItemText = listTerre.SelectedItem.ToString();
                SelectedIndex = listTerre.SelectedIndex;
                listBord.Items.Add(selectedItemText);
                l1.RemoveAt(SelectedIndex);
            }

            DataBinding();
        }
        private void DataBinding()
        {
            listTerre.DataSource = null;
            listTerre.DataSource = l1;
        }

        private void cmdBordToTerre_Click(object sender, EventArgs e)
        {
            SelectedIndex = listBord.SelectedIndex;
            if (SelectedIndex != -1)
            {

                selectedItemText = listBord.SelectedItem.ToString();
                SelectedIndex = listBord.SelectedIndex;
                l1.Add(selectedItemText);
                listBord.Items.RemoveAt(listBord.Items.IndexOf(listBord.SelectedItem));
                DataBinding();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
