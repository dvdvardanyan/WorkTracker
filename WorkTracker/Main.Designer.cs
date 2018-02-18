namespace WorkTracker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadingButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dailyStandUpButton = new System.Windows.Forms.Button();
            this.discussionButton = new System.Windows.Forms.Button();
            this.adHocTaskButton = new System.Windows.Forms.Button();
            this.qcTaskButton = new System.Windows.Forms.Button();
            this.analTaskButton = new System.Windows.Forms.Button();
            this.poDiscussionButton = new System.Windows.Forms.Button();
            this.emailActivityButton = new System.Windows.Forms.Button();
            this.baDiscussionButton = new System.Windows.Forms.Button();
            this.meetingButton = new System.Windows.Forms.Button();
            this.refinementButton = new System.Windows.Forms.Button();
            this.otherTaskButton = new System.Windows.Forms.Button();
            this.devTaskButton = new System.Windows.Forms.Button();
            this.boardActivityButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.personalButton = new System.Windows.Forms.Button();
            this.bathroomButton = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.distractionButton = new System.Windows.Forms.Button();
            this.otherNoSprintTaskButton = new System.Windows.Forms.Button();
            this.otherEmailActivityButton = new System.Windows.Forms.Button();
            this.otherDiscussionButton = new System.Windows.Forms.Button();
            this.otherMeetingButton = new System.Windows.Forms.Button();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadingButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Day";
            // 
            // loadingButton
            // 
            this.loadingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadingButton.Location = new System.Drawing.Point(13, 19);
            this.loadingButton.Name = "loadingButton";
            this.loadingButton.Size = new System.Drawing.Size(153, 56);
            this.loadingButton.TabIndex = 2;
            this.loadingButton.Text = "Waiting to Load";
            this.loadingButton.UseVisualStyleBackColor = true;
            this.loadingButton.Click += new System.EventHandler(this.loadingButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Time";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(39, 31);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(132, 31);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0 hr 0 min";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dailyStandUpButton);
            this.groupBox3.Controls.Add(this.discussionButton);
            this.groupBox3.Controls.Add(this.adHocTaskButton);
            this.groupBox3.Controls.Add(this.qcTaskButton);
            this.groupBox3.Controls.Add(this.analTaskButton);
            this.groupBox3.Controls.Add(this.poDiscussionButton);
            this.groupBox3.Controls.Add(this.emailActivityButton);
            this.groupBox3.Controls.Add(this.baDiscussionButton);
            this.groupBox3.Controls.Add(this.meetingButton);
            this.groupBox3.Controls.Add(this.refinementButton);
            this.groupBox3.Controls.Add(this.otherTaskButton);
            this.groupBox3.Controls.Add(this.devTaskButton);
            this.groupBox3.Controls.Add(this.boardActivityButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work related to sprint";
            // 
            // dailyStandUpButton
            // 
            this.dailyStandUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyStandUpButton.Location = new System.Drawing.Point(11, 95);
            this.dailyStandUpButton.Name = "dailyStandUpButton";
            this.dailyStandUpButton.Size = new System.Drawing.Size(124, 32);
            this.dailyStandUpButton.TabIndex = 10;
            this.dailyStandUpButton.Text = "Daily Standup";
            this.dailyStandUpButton.UseVisualStyleBackColor = true;
            this.dailyStandUpButton.Click += new System.EventHandler(this.dailyStandUpButton_Click);
            // 
            // discussionButton
            // 
            this.discussionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discussionButton.Location = new System.Drawing.Point(271, 57);
            this.discussionButton.Name = "discussionButton";
            this.discussionButton.Size = new System.Drawing.Size(124, 32);
            this.discussionButton.TabIndex = 9;
            this.discussionButton.Text = "Discussion";
            this.discussionButton.UseVisualStyleBackColor = true;
            this.discussionButton.Click += new System.EventHandler(this.discussionButton_Click);
            // 
            // adHocTaskButton
            // 
            this.adHocTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adHocTaskButton.Location = new System.Drawing.Point(531, 19);
            this.adHocTaskButton.Name = "adHocTaskButton";
            this.adHocTaskButton.Size = new System.Drawing.Size(124, 32);
            this.adHocTaskButton.TabIndex = 8;
            this.adHocTaskButton.Text = "AdHoc Task";
            this.adHocTaskButton.UseVisualStyleBackColor = true;
            this.adHocTaskButton.Click += new System.EventHandler(this.adHocTaskButton_Click);
            // 
            // qcTaskButton
            // 
            this.qcTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qcTaskButton.Location = new System.Drawing.Point(141, 19);
            this.qcTaskButton.Name = "qcTaskButton";
            this.qcTaskButton.Size = new System.Drawing.Size(124, 32);
            this.qcTaskButton.TabIndex = 7;
            this.qcTaskButton.Text = "QC Task";
            this.qcTaskButton.UseVisualStyleBackColor = true;
            this.qcTaskButton.Click += new System.EventHandler(this.qcTaskButton_Click);
            // 
            // analTaskButton
            // 
            this.analTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analTaskButton.Location = new System.Drawing.Point(271, 19);
            this.analTaskButton.Name = "analTaskButton";
            this.analTaskButton.Size = new System.Drawing.Size(124, 32);
            this.analTaskButton.TabIndex = 6;
            this.analTaskButton.Text = "Analysis Task";
            this.analTaskButton.UseVisualStyleBackColor = true;
            this.analTaskButton.Click += new System.EventHandler(this.analTaskButton_Click);
            // 
            // poDiscussionButton
            // 
            this.poDiscussionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poDiscussionButton.Location = new System.Drawing.Point(531, 57);
            this.poDiscussionButton.Name = "poDiscussionButton";
            this.poDiscussionButton.Size = new System.Drawing.Size(124, 32);
            this.poDiscussionButton.TabIndex = 5;
            this.poDiscussionButton.Text = "PO Discussion";
            this.poDiscussionButton.UseVisualStyleBackColor = true;
            this.poDiscussionButton.Click += new System.EventHandler(this.poDiscussionButton_Click);
            // 
            // emailActivityButton
            // 
            this.emailActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailActivityButton.Location = new System.Drawing.Point(141, 57);
            this.emailActivityButton.Name = "emailActivityButton";
            this.emailActivityButton.Size = new System.Drawing.Size(124, 32);
            this.emailActivityButton.TabIndex = 2;
            this.emailActivityButton.Text = "Email Activity";
            this.emailActivityButton.UseVisualStyleBackColor = true;
            this.emailActivityButton.Click += new System.EventHandler(this.emailActivityButton_Click);
            // 
            // baDiscussionButton
            // 
            this.baDiscussionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baDiscussionButton.Location = new System.Drawing.Point(401, 57);
            this.baDiscussionButton.Name = "baDiscussionButton";
            this.baDiscussionButton.Size = new System.Drawing.Size(124, 32);
            this.baDiscussionButton.TabIndex = 4;
            this.baDiscussionButton.Text = "BA Discussion";
            this.baDiscussionButton.UseVisualStyleBackColor = true;
            this.baDiscussionButton.Click += new System.EventHandler(this.baDiscussionButton_Click);
            // 
            // meetingButton
            // 
            this.meetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meetingButton.Location = new System.Drawing.Point(271, 95);
            this.meetingButton.Name = "meetingButton";
            this.meetingButton.Size = new System.Drawing.Size(124, 32);
            this.meetingButton.TabIndex = 3;
            this.meetingButton.Text = "Other Meeting";
            this.meetingButton.UseVisualStyleBackColor = true;
            this.meetingButton.Click += new System.EventHandler(this.meetingButton_Click);
            // 
            // refinementButton
            // 
            this.refinementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refinementButton.Location = new System.Drawing.Point(141, 95);
            this.refinementButton.Name = "refinementButton";
            this.refinementButton.Size = new System.Drawing.Size(124, 32);
            this.refinementButton.TabIndex = 2;
            this.refinementButton.Text = "Refinement";
            this.refinementButton.UseVisualStyleBackColor = true;
            this.refinementButton.Click += new System.EventHandler(this.refinementButton_Click);
            // 
            // otherTaskButton
            // 
            this.otherTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherTaskButton.Location = new System.Drawing.Point(401, 19);
            this.otherTaskButton.Name = "otherTaskButton";
            this.otherTaskButton.Size = new System.Drawing.Size(124, 32);
            this.otherTaskButton.TabIndex = 1;
            this.otherTaskButton.Text = "Other Task";
            this.otherTaskButton.UseVisualStyleBackColor = true;
            this.otherTaskButton.Click += new System.EventHandler(this.otherTaskButton_Click);
            // 
            // devTaskButton
            // 
            this.devTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devTaskButton.Location = new System.Drawing.Point(11, 19);
            this.devTaskButton.Name = "devTaskButton";
            this.devTaskButton.Size = new System.Drawing.Size(124, 32);
            this.devTaskButton.TabIndex = 0;
            this.devTaskButton.Text = "DEV Task";
            this.devTaskButton.UseVisualStyleBackColor = true;
            this.devTaskButton.Click += new System.EventHandler(this.devTaskButton_Click);
            // 
            // boardActivityButton
            // 
            this.boardActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardActivityButton.Location = new System.Drawing.Point(11, 57);
            this.boardActivityButton.Name = "boardActivityButton";
            this.boardActivityButton.Size = new System.Drawing.Size(124, 32);
            this.boardActivityButton.TabIndex = 0;
            this.boardActivityButton.Text = "Board Activity";
            this.boardActivityButton.UseVisualStyleBackColor = true;
            this.boardActivityButton.Click += new System.EventHandler(this.boardActivityButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptionText);
            this.groupBox4.Location = new System.Drawing.Point(14, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(663, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Activity Detail";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(9, 19);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(644, 75);
            this.descriptionText.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.personalButton);
            this.groupBox5.Controls.Add(this.bathroomButton);
            this.groupBox5.Controls.Add(this.lunchButton);
            this.groupBox5.Location = new System.Drawing.Point(197, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 85);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Breaks";
            // 
            // personalButton
            // 
            this.personalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalButton.Location = new System.Drawing.Point(173, 19);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(75, 56);
            this.personalButton.TabIndex = 3;
            this.personalButton.Text = "Personal";
            this.personalButton.UseVisualStyleBackColor = true;
            this.personalButton.Click += new System.EventHandler(this.personalButton_Click);
            // 
            // bathroomButton
            // 
            this.bathroomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bathroomButton.Location = new System.Drawing.Point(92, 19);
            this.bathroomButton.Name = "bathroomButton";
            this.bathroomButton.Size = new System.Drawing.Size(75, 56);
            this.bathroomButton.TabIndex = 2;
            this.bathroomButton.Text = "Bathroom";
            this.bathroomButton.UseVisualStyleBackColor = true;
            this.bathroomButton.Click += new System.EventHandler(this.bathroomButton_Click);
            // 
            // lunchButton
            // 
            this.lunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchButton.Location = new System.Drawing.Point(11, 19);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(75, 56);
            this.lunchButton.TabIndex = 2;
            this.lunchButton.Text = "Lunch";
            this.lunchButton.UseVisualStyleBackColor = true;
            this.lunchButton.Click += new System.EventHandler(this.lunchButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.distractionButton);
            this.groupBox7.Controls.Add(this.otherNoSprintTaskButton);
            this.groupBox7.Controls.Add(this.otherEmailActivityButton);
            this.groupBox7.Controls.Add(this.otherDiscussionButton);
            this.groupBox7.Controls.Add(this.otherMeetingButton);
            this.groupBox7.Location = new System.Drawing.Point(14, 252);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(663, 61);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Work not related to sprint";
            // 
            // distractionButton
            // 
            this.distractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distractionButton.Location = new System.Drawing.Point(529, 19);
            this.distractionButton.Name = "distractionButton";
            this.distractionButton.Size = new System.Drawing.Size(124, 32);
            this.distractionButton.TabIndex = 12;
            this.distractionButton.Text = "Distraction";
            this.distractionButton.UseVisualStyleBackColor = true;
            this.distractionButton.Click += new System.EventHandler(this.distractionButton_Click);
            // 
            // otherNoSprintTaskButton
            // 
            this.otherNoSprintTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherNoSprintTaskButton.Location = new System.Drawing.Point(399, 19);
            this.otherNoSprintTaskButton.Name = "otherNoSprintTaskButton";
            this.otherNoSprintTaskButton.Size = new System.Drawing.Size(124, 32);
            this.otherNoSprintTaskButton.TabIndex = 11;
            this.otherNoSprintTaskButton.Text = "Other Task";
            this.otherNoSprintTaskButton.UseVisualStyleBackColor = true;
            this.otherNoSprintTaskButton.Click += new System.EventHandler(this.otherNoSprintTaskButton_Click);
            // 
            // otherEmailActivityButton
            // 
            this.otherEmailActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherEmailActivityButton.Location = new System.Drawing.Point(9, 19);
            this.otherEmailActivityButton.Name = "otherEmailActivityButton";
            this.otherEmailActivityButton.Size = new System.Drawing.Size(124, 32);
            this.otherEmailActivityButton.TabIndex = 10;
            this.otherEmailActivityButton.Text = "Email Activity";
            this.otherEmailActivityButton.UseVisualStyleBackColor = true;
            this.otherEmailActivityButton.Click += new System.EventHandler(this.otherEmailActivityButton_Click);
            // 
            // otherDiscussionButton
            // 
            this.otherDiscussionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherDiscussionButton.Location = new System.Drawing.Point(269, 19);
            this.otherDiscussionButton.Name = "otherDiscussionButton";
            this.otherDiscussionButton.Size = new System.Drawing.Size(124, 32);
            this.otherDiscussionButton.TabIndex = 2;
            this.otherDiscussionButton.Text = "Discussion";
            this.otherDiscussionButton.UseVisualStyleBackColor = true;
            this.otherDiscussionButton.Click += new System.EventHandler(this.otherDiscussionButton_Click);
            // 
            // otherMeetingButton
            // 
            this.otherMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherMeetingButton.Location = new System.Drawing.Point(139, 19);
            this.otherMeetingButton.Name = "otherMeetingButton";
            this.otherMeetingButton.Size = new System.Drawing.Size(124, 32);
            this.otherMeetingButton.TabIndex = 1;
            this.otherMeetingButton.Text = "Meeting";
            this.otherMeetingButton.UseVisualStyleBackColor = true;
            this.otherMeetingButton.Click += new System.EventHandler(this.otherMeetingButton_Click);
            // 
            // workTimer
            // 
            this.workTimer.Interval = 60000;
            this.workTimer.Tick += new System.EventHandler(this.workTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 436);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agile Work Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadingButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button otherTaskButton;
        private System.Windows.Forms.Button devTaskButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Button bathroomButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button otherDiscussionButton;
        private System.Windows.Forms.Button otherMeetingButton;
        private System.Windows.Forms.Button boardActivityButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button dailyStandUpButton;
        private System.Windows.Forms.Button discussionButton;
        private System.Windows.Forms.Button adHocTaskButton;
        private System.Windows.Forms.Button qcTaskButton;
        private System.Windows.Forms.Button analTaskButton;
        private System.Windows.Forms.Button poDiscussionButton;
        private System.Windows.Forms.Button emailActivityButton;
        private System.Windows.Forms.Button baDiscussionButton;
        private System.Windows.Forms.Button meetingButton;
        private System.Windows.Forms.Button refinementButton;
        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button otherNoSprintTaskButton;
        private System.Windows.Forms.Button otherEmailActivityButton;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Button distractionButton;
        private System.Windows.Forms.Timer workTimer;
    }
}

