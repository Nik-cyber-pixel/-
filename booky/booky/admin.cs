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
    
    public partial class admin : Form
    {
        Thread th;
        //ПОЛНЫЙ ПУТЬ К ФАЙЛУ С КНИГАМИ 
        string path = ("books.txt");
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(home);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void home()
        {
            Application.Run(new Form1());
        }
        private void user()
        {
            Application.Run(new user());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                if(textBox1.Text != "")
                {
                    sw.WriteLineAsync($"\n{textBox1.Text}");
                }
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(user);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
