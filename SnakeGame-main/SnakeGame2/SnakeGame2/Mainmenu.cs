using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame2
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (optEasy.Checked)
            {
                Speelveld snakegame = new Speelveld(700);
                snakegame.Show();
                this.Hide();
            }
            
            else if (optMedium.Checked)
            {
                Speelveld snakegame = new Speelveld(500);
                snakegame.Show();
                this.Hide();
            }

            else if (optHard.Checked)
            {
                Speelveld snakegame = new Speelveld(300);
                snakegame.Show();
                this.Hide();
            }

            else if (optUltra.Checked)
            {
                Speelveld snakegame = new Speelveld(150);
                snakegame.Show();
                this.Hide();
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
