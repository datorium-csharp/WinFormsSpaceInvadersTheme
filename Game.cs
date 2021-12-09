namespace WinFormsSpaceInvadersTheme
{
    public partial class Game : Form
    {
        Spaceship spaceship = null;
        
        int step = 5;
        int horVelocity = 0;

        public Game()
        {
            InitializeComponent();
            spaceship = new Spaceship(this);
            spaceship.Left = 300;
            spaceship.Top = this.ClientRectangle.Height - spaceship.Height;
            this.Controls.Add(spaceship);

            GameTimer.Start();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                horVelocity = step;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                horVelocity = -step;
            }
            else if (e.KeyCode == Keys.Space)
            {
                //fire a bullet
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            spaceship.Left += horVelocity;
            BorderCollisionCheck();
        }

        private void BorderCollisionCheck()
        {
            if(spaceship.Left <= 0)
            {
                //left border collision
                horVelocity = step;
            }
            else if(spaceship.Left + spaceship.Width >= this.ClientRectangle.Width)
            {
                //right border collision
                horVelocity -= step;
            }
        }
    }
}