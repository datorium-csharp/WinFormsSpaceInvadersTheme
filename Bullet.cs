using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WinFormsSpaceInvadersTheme.Properties;

namespace WinFormsSpaceInvadersTheme
{
    internal class Bullet : PictureBox
    {

        private int step = 5;
        private System.Windows.Forms.Timer bulletTimer = null;

        public Bullet()
        {
            this.Height = 50;
            this.Width = 2;
            this.BackColor = Color.Red;
            InitialiseBulletTimer();
        }

        private void InitialiseBulletTimer()
        {
            bulletTimer = new System.Windows.Forms.Timer();
            bulletTimer.Interval = 10;
            bulletTimer.Tick += BulletTimer_Tick;
            bulletTimer.Start();
        }

        private void BulletTimer_Tick(object sender, EventArgs e)
        {
            this.Top -= step;
        }
    }
}
