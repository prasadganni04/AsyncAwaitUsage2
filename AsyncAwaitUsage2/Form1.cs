using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace AsyncAwaitUsage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  async void label1_Click(object sender, EventArgs e)
        {
            Task<int> m = new Task<int>(CountChar);
            m.Start();



            lblcount.Text = "Started.....Please wait";
            int c = await m;
            lblcount.Text = c.ToString() + " Characters in file";

        }
        private int CountChar()
        {
            int c = 0;
            using (StreamReader sr = new StreamReader("C:\\Users\\GVSS Prasad\\OneDrive\\Desktop\\testtack access.txt")) 
            {
                string str = sr.ReadToEnd();
                c = str.Length;
                Thread.Sleep(5000);

             };
            return c;
           
        }
    }
}
