﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOrganizer
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void StartTime()
        {

        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingBarTimer.Start();
        }
        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {

            loadingBarValue += 5;

            statusPercent.Text = loadingBarValue.ToString() +"%";
            loadingProgressBar.Value = loadingBarValue;

            if(loadingBarValue >= loadingProgressBar.Maximum)
            {
                loadingBarTimer.Stop();

                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void statusPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
