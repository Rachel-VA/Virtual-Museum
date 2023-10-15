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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// use label control, add a time, then click in timer to create function for four different colors when blinking.
        /// Finally, execute the start timer funtion in the form when it loads (click in the event programming/flashing symbol).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            int One = rn.Next(0, 255);
            int Two = rn.Next(0, 255);
            int Three = rn.Next(0, 255);
            int Four = rn.Next(0, 255);
            labelBlinkingText.ForeColor = Color.FromArgb(One, Two, Three, Four);
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //the code below to link the third form in a button
        private void buttonLinkThirdForm_Click(object sender, EventArgs e)
        {
            ThirdForm f1 = new ThirdForm();
            f1.Show();
        }
    }
}
