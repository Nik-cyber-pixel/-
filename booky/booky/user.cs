using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace booky
{
    public partial class user : Form
    {
        //ПОЛНЫЙ ПУТЬ К ФАЙЛУ С КНИГАМИ 
        string path =("books.txt");
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        label1.Text += $"{line}\n";
                    }
                        
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("1");
        }



        private void category_out(string id)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if(!String.IsNullOrEmpty(line))
                    {
                        string id_c = line.Substring(0, line.IndexOf(','));

                        if (id == id_c)
                        {
                            label1.Text += $"{line}\n";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            category_out("8");
        }
    }
}
