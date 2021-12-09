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
    internal class Spaceship : PictureBox
    {
        private int rocketImageCounter = 0;

        private System.Windows.Forms.Timer AnimationTimer = null;
        private Bullet bullet = null;
        private Game mainGame = null;

        public Spaceship(Game game)
        {
            mainGame = game;
            this.Height = 160;
            this.Width = 80;
            this.BackColor = Color.Transparent;
            this.Image = (Image)Resources.ResourceManager.GetObject("rocket_off_000");
            this.SizeMode = PictureBoxSizeMode.StretchImage; 
            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            AnimationTimer = new System.Windows.Forms.Timer();
            AnimationTimer.Interval = 80;
            AnimationTimer.Tick += AnimationTimer_Tick;
            AnimationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            string imageName = $"rocket_off_{rocketImageCounter.ToString("000")}";
            this.Image = (Image)Resources.ResourceManager.GetObject(imageName);
            rocketImageCounter += 1;
            if (rocketImageCounter == 4)
            {
                rocketImageCounter = 0;
            }
        }

        public void FireBullet()
        {
            bullet = new Bullet();
            bullet.Top  = mainGame.ClientRectangle.Height - this.Height - bullet.Height;
            bullet.Left = this.Left + 40;
            mainGame.Controls.Add(bullet);
        }

    }
}
