using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTracker
{
    public partial class Main : Form
    {
        private FileInfo file;
        private Button currentActiveButton;
        private DateTime startTime;

        private void makeActive(Button butt)
        {
            if(currentActiveButton != null)
            {
                currentActiveButton.BackColor = SystemColors.Control;
            }

            currentActiveButton = butt;
            currentActiveButton.BackColor = Color.GreenYellow;
            descriptionText.Text = "";
        }

        private void logToFile(int type, string text)
        {
            using (StreamWriter sw = file.AppendText())
            {
                if(type > 0)
                {
                    sw.Write("\t" + DateTime.Now.ToString() + "\t\"" + descriptionText.Text + "\"\r\n");
                    sw.Write(type.ToString() + "\t" + text + "\t" + DateTime.Now.ToString());
                }
                else if(type == 0)
                {
                    sw.Write(type.ToString() + "\t" + text + "\t" + DateTime.Now.ToString());
                }
                else if(type == -2)
                {
                    sw.Write("\t" + DateTime.Now.ToString() + "\t\"" + descriptionText.Text + "\"\r\n");
                }
            }
        }

        private void InitializeFile()
        {
            DirectoryInfo dir = new DirectoryInfo("Files");

            if (dir == null || !dir.Exists)
            {
                dir.Create();
            }

            startTime = DateTime.Now;
            string fileName = @"Files\" + startTime.Year.ToString() + "_" + startTime.Month.ToString() + "_" + startTime.Day.ToString() + "_" + Guid.NewGuid().ToString() + ".txt";
            this.file = new FileInfo(fileName);
            this.logToFile(0, "Waiting on system to start");
        }

        public Main()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            InitializeFile();
            this.workTimer.Start();
            this.FormClosing += Main_FormClosing;
        }

        void Main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Tracker", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.logToFile(-2, null);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.makeActive(this.loadingButton);
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            this.logToFile(1, "Lunch");
            this.makeActive((Button)sender);
        }

        private void bathroomButton_Click(object sender, EventArgs e)
        {
            this.logToFile(2, "Bathroom");
            this.makeActive((Button)sender);
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            this.logToFile(3, "Personal");
            this.makeActive((Button)sender);
        }

        private void devTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(4, "Sprint - Development Task");
            this.makeActive((Button)sender);
        }

        private void qcTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(5, "Sprint - Testing Task");
            this.makeActive((Button)sender);
        }

        private void analTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(6, "Sprint - Analysis Task");
            this.makeActive((Button)sender);
        }

        private void otherTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(7, "Sprint - Other Task");
            this.makeActive((Button)sender);
        }

        private void adHocTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(8, "Sprint - Adhoc Task");
            this.makeActive((Button)sender);
        }

        private void boardActivityButton_Click(object sender, EventArgs e)
        {
            this.logToFile(9, "Sprint - Checking or Updating Scrum Board");
            this.makeActive((Button)sender);
        }

        private void emailActivityButton_Click(object sender, EventArgs e)
        {
            this.logToFile(10, "Sprint - Reading or Sending Email");
            this.makeActive((Button)sender);
        }

        private void discussionButton_Click(object sender, EventArgs e)
        {
            this.logToFile(11, "Sprint - Discussion");
            this.makeActive((Button)sender);
        }

        private void baDiscussionButton_Click(object sender, EventArgs e)
        {
            this.logToFile(12, "Sprint - Discussing Requirements with BA");
            this.makeActive((Button)sender);
        }

        private void poDiscussionButton_Click(object sender, EventArgs e)
        {
            this.logToFile(13, "Sprint - Discussing Requirements with PO");
            this.makeActive((Button)sender);
        }

        private void dailyStandUpButton_Click(object sender, EventArgs e)
        {
            this.logToFile(14, "Sprint - Daily Standup");
            this.makeActive((Button)sender);
        }

        private void refinementButton_Click(object sender, EventArgs e)
        {
            this.logToFile(15, "Sprint - Product Refinement");
            this.makeActive((Button)sender);
        }

        private void meetingButton_Click(object sender, EventArgs e)
        {
            this.logToFile(16, "Sprint - Other Meeting");
            this.makeActive((Button)sender);
        }

        private void otherEmailActivityButton_Click(object sender, EventArgs e)
        {
            this.logToFile(17, "Other - Reading or Sending Email");
            this.makeActive((Button)sender);
        }

        private void otherMeetingButton_Click(object sender, EventArgs e)
        {
            this.logToFile(18, "Other - Meeting");
            this.makeActive((Button)sender);
        }

        private void otherDiscussionButton_Click(object sender, EventArgs e)
        {
            this.logToFile(19, "Other - Discussion");
            this.makeActive((Button)sender);
        }

        private void otherNoSprintTaskButton_Click(object sender, EventArgs e)
        {
            this.logToFile(20, "Other - Task");
            this.makeActive((Button)sender);
        }

        private void distractionButton_Click(object sender, EventArgs e)
        {
            this.logToFile(21, "Other - Distraction");
            this.makeActive((Button)sender);
        }

        private void loadingButton_Click(object sender, EventArgs e)
        {
            this.logToFile(22, "Waiting on system to load");
            this.makeActive((Button)sender);
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan workedSoFar = DateTime.Now - startTime;
            timeLabel.Text = workedSoFar.Hours.ToString() + " hr " + workedSoFar.Minutes.ToString() + " min";
        }
    }
}
