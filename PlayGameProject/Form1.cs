using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;//allow us to use a sound player

namespace PlayGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //clear screen
            playButton.Visible = false;

            //show changes and pause
            Refresh();
            Thread.Sleep(1000);

            //change message in output label
            outputLabel.Text = "Game Will Start In: 3";

            //create sound player and create new sound
            SoundPlayer readySetPlayer = new SoundPlayer(Properties.Resources.readySet);
            readySetPlayer.Play();

            //show changes and pause
            Refresh();
            Thread.Sleep(1000);

            //change message in output label
            outputLabel.Text = "Game Will Start In: 2";

            //show changes and pause
            Refresh();
            Thread.Sleep(1000);

            //change message in output label
            outputLabel.Text = "Game Will Start In: 1";

            //show changes and pause
            Refresh();
            Thread.Sleep(1000);

            //change background colour of form
            BackColor = Color.Lime;

            //change message in output label
            outputLabel.Text = "GO!";

            //create sound player and create new sound
            SoundPlayer goPlayer = new SoundPlayer(Properties.Resources.go);
            goPlayer.Play();



        }
    }
}
