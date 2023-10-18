using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxlar_arasi_gecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToString());
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox3.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox3.SelectedItem.ToString());
            listBox3.Items.Remove(listBox3.SelectedItem.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                listBox2.Items.Add(listBox3.Items[i].ToString());
            }
            listBox3.Items.Clear();
        }
    }
}
