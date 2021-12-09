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

        public Bullet()
        {
            this.Height = 200;
            this.Width = 20;
            this.BackColor = Color.Red;
        }


    }
}
