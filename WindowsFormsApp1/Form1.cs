using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(Properties.Resources.freakbobCalling__1_);
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.freakbobCalling__1_);
            player.Play();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
         button1.Visible = true;
            button2.Visible = false;
            label3.Visible = true;
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
