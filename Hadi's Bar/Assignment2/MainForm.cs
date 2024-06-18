using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
        private void button2_Click(object sender, System.EventArgs e) {
            listBox1.DataSource = null;
            if (textBox1.Text.Length <= 0) {
                itemManager.SetDrinks(comboBox1.Text);
                listBox1.DataSource = itemManager.GetDrinks();
            }
            else {
                itemManager.SearchForDrinks(textBox1.Text, comboBox1.Text);
                listBox1.DataSource = itemManager.GetDrinks();
            }
        }

        private void listBox1_TextChanged(object sender, EventArgs e) {

        }




        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem != null) {
                if (comboBox2.SelectedItem != null)
                    System.Windows.Forms.MessageBox.Show(listBox1.SelectedItem + " ordered at table number " + comboBox2.Text + "!");
                else
                    System.Windows.Forms.MessageBox.Show("No selected table!");
            }
            else
                System.Windows.Forms.MessageBox.Show("No selected item!");
        }
    }
}
