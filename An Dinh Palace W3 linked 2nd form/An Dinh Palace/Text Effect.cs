using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// add a user control to build text effect box with a timer
/// </summary>

namespace An_Dinh_Palace
{
    public partial class Text_Effect : Label
    {
        public Text_Effect()
        {
            InitializeComponent();
            UseCompatibleTextRendering = true;
            this.BackColor = Color.White;
            timer1.Start();
        }
        int position, speed;
        public int Set_Speed { get { return speed; } set { speed = value;Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)position, 0);
            base.OnPaint(e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position<-Width)
            {
                position = Width;
            }
            position -= speed;
            Invalidate();
        }
    }
}
