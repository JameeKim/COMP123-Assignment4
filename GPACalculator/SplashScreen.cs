using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GPACalculator;

namespace Testing
{
    public partial class SplashScreen : Form
    {
        private readonly List<Course> courses;

        public SplashScreen(List<Course> courses)
        {
            this.courses = courses;
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashEndTimer.Start();
        }

        private void splashEndTimer_Tick(object sender, EventArgs e)
        {
            splashEndTimer.Stop();

            Hide();
            MainForm mainForm = new MainForm(courses, this);
            mainForm.ShowDialog();
        }
    }
}
