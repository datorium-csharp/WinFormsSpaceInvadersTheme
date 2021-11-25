using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsSpaceInvadersTheme
{
    internal class Spaceship : PictureBox
    {
        public Spaceship()
        {
            this.Height = 200;
            this.Width = 40;
            this.BackColor = Color.Blue;
        }

    }
}
