using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace An_Dinh_Palace
{
    public partial class ThirdForm : Form
    {
        //create a private acess string text
        private string text;
        private int length = 0; 
        public ThirdForm()
        {
            InitializeComponent();
        }

       // private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
       // {

       // }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (length < text.Length)
            {
                labelAnimatedText.Text = labelAnimatedText.Text + text.ElementAt(length);  
                length++;   
            }else
                timer1.Stop();

        }

        private void ThirdForm_Load(object sender, EventArgs e)
        {
            text = labelAnimatedText.Text;
            labelAnimatedText.Text = "";
            timer1.Start();
        }
    }
}
