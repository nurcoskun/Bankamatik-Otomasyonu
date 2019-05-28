using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bm_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 3000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t.Stop();
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }
    }
}
