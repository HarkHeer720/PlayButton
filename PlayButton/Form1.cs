using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayButton
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }
        
        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer newMario = new SoundPlayer(Properties.Resources.newMario);
            newMario.Play();

            Thread.Sleep(500);
            
            StartButton.Text = "Game will start in 3";

            Refresh();
            Thread.Sleep(1000);
             

            StartButton.Text = "Game will start in 2";

            Refresh();
            Thread.Sleep(1000);

            StartButton.Text = "Game will start in 1";

            Refresh();
            Thread.Sleep(1000);

            StartButton.Text = "Go";
            StartButton.BackColor = Color.Green;
            BackColor = Color.Green;

            Refresh();
            Thread.Sleep(5000);
            BackColor = Color.Black;
            StartButton.Text = "Press to start";
            StartButton.BackColor = Color.White;
        }
    }
}
