namespace GradeCalc
{
    partial class Form1
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
            this.CountsGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitCountsButton = new System.Windows.Forms.Button();
            this.NumofAssignTxtBox = new System.Windows.Forms.TextBox();
            this.NumofStudentsTxtBox = new System.Windows.Forms.TextBox();
            this.NumOfAssignLabel = new System.Windows.Forms.Label();
            this.NumOfStudentsLabel = new System.Windows.Forms.Label();
            this.NavigateGroupBox = new System.Windows.Forms.GroupBox();
            this.LastStudentButton = new System.Windows.Forms.Button();
            this.NextStudentButton = new System.Windows.Forms.Button();
            this.PrevStudentButton = new System.Windows.Forms.Button();
            this.FirstStudentButton = new System.Windows.Forms.Button();
            this.StudentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveNameButton = new System.Windows.Forms.Button();
            this.StudentNameInputTxtBox = new System.Windows.Forms.TextBox();
            this.CurrentStudentLabel = new System.Windows.Forms.Label();
            this.StudentInfo2GroupBox = new System.Windows.Forms.GroupBox();
            this.SaveScoreButton = new System.Windows.Forms.Button();
            this.AssignScoreTxtBox = new System.Windows.Forms.TextBox();
            this.EnterAssignTxtBox = new System.Windows.Forms.TextBox();
            this.AssignScoreLabel = new System.Windows.Forms.Label();
            this.EnterAssignNumLabel = new System.Windows.Forms.Label();
            this.ScoresDisplayRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.DisplayScoresButton = new System.Windows.Forms.Button();
            this.ResetScoresButton = new System.Windows.Forms.Button();
            this.CountsGroupBox.SuspendLayout();
            this.NavigateGroupBox.SuspendLayout();
            this.StudentInfoGroupBox.SuspendLayout();
            this.StudentInfo2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountsGroupBox
            // 
            this.CountsGroupBox.Controls.Add(this.SubmitCountsButton);
            this.CountsGroupBox.Controls.Add(this.NumofAssignTxtBox);
            this.CountsGroupBox.Controls.Add(this.NumofStudentsTxtBox);
            this.CountsGroupBox.Controls.Add(this.NumOfAssignLabel);
            this.CountsGroupBox.Controls.Add(this.NumOfStudentsLabel);
            this.CountsGroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountsGroupBox.Location = new System.Drawing.Point(15, 15);
            this.CountsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountsGroupBox.Name = "CountsGroupBox";
            this.CountsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountsGroupBox.Size = new System.Drawing.Size(717, 142);
            this.CountsGroupBox.TabIndex = 0;
            this.CountsGroupBox.TabStop = false;
            this.CountsGroupBox.Text = "Counts";
            // 
            // SubmitCountsButton
            // 
            this.SubmitCountsButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SubmitCountsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitCountsButton.FlatAppearance.BorderSize = 0;
            this.SubmitCountsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.SubmitCountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitCountsButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitCountsButton.Location = new System.Drawing.Point(518, 55);
            this.SubmitCountsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitCountsButton.Name = "SubmitCountsButton";
            this.SubmitCountsButton.Size = new System.Drawing.Size(156, 38);
            this.SubmitCountsButton.TabIndex = 4;
            this.SubmitCountsButton.Text = "Submit Counts";
            this.SubmitCountsButton.UseVisualStyleBackColor = false;
            this.SubmitCountsButton.Click += new System.EventHandler(this.SubmitCountsButton_Click);
            this.SubmitCountsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.SubmitCountsButton_Paint);
            // 
            // NumofAssignTxtBox
            // 
            this.NumofAssignTxtBox.Location = new System.Drawing.Point(352, 79);
            this.NumofAssignTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumofAssignTxtBox.Name = "NumofAssignTxtBox";
            this.NumofAssignTxtBox.Size = new System.Drawing.Size(112, 26);
            this.NumofAssignTxtBox.TabIndex = 3;
            // 
            // NumofStudentsTxtBox
            // 
            this.NumofStudentsTxtBox.Location = new System.Drawing.Point(352, 41);
            this.NumofStudentsTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumofStudentsTxtBox.Name = "NumofStudentsTxtBox";
            this.NumofStudentsTxtBox.Size = new System.Drawing.Size(112, 26);
            this.NumofStudentsTxtBox.TabIndex = 2;
            // 
            // NumOfAssignLabel
            // 
            this.NumOfAssignLabel.AutoSize = true;
            this.NumOfAssignLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfAssignLabel.Location = new System.Drawing.Point(18, 82);
            this.NumOfAssignLabel.Name = "NumOfAssignLabel";
            this.NumOfAssignLabel.Size = new System.Drawing.Size(227, 18);
            this.NumOfAssignLabel.TabIndex = 1;
            this.NumOfAssignLabel.Text = "Number of Assignments: ";
            // 
            // NumOfStudentsLabel
            // 
            this.NumOfStudentsLabel.AutoSize = true;
            this.NumOfStudentsLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfStudentsLabel.Location = new System.Drawing.Point(51, 44);
            this.NumOfStudentsLabel.Name = "NumOfStudentsLabel";
            this.NumOfStudentsLabel.Size = new System.Drawing.Size(195, 18);
            this.NumOfStudentsLabel.TabIndex = 0;
            this.NumOfStudentsLabel.Text = "Number of Students: ";
            // 
            // NavigateGroupBox
            // 
            this.NavigateGroupBox.Controls.Add(this.LastStudentButton);
            this.NavigateGroupBox.Controls.Add(this.NextStudentButton);
            this.NavigateGroupBox.Controls.Add(this.PrevStudentButton);
            this.NavigateGroupBox.Controls.Add(this.FirstStudentButton);
            this.NavigateGroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateGroupBox.Location = new System.Drawing.Point(15, 172);
            this.NavigateGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavigateGroupBox.Name = "NavigateGroupBox";
            this.NavigateGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavigateGroupBox.Size = new System.Drawing.Size(745, 110);
            this.NavigateGroupBox.TabIndex = 1;
            this.NavigateGroupBox.TabStop = false;
            this.NavigateGroupBox.Text = "Navigate";
            // 
            // LastStudentButton
            // 
            this.LastStudentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LastStudentButton.Enabled = false;
            this.LastStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LastStudentButton.FlatAppearance.BorderSize = 0;
            this.LastStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.LastStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastStudentButton.Location = new System.Drawing.Point(561, 39);
            this.LastStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastStudentButton.Name = "LastStudentButton";
            this.LastStudentButton.Size = new System.Drawing.Size(162, 38);
            this.LastStudentButton.TabIndex = 3;
            this.LastStudentButton.Text = ">> Last Student";
            this.LastStudentButton.UseVisualStyleBackColor = false;
            this.LastStudentButton.Click += new System.EventHandler(this.LastStudentButton_Click);
            this.LastStudentButton.Paint += new System.Windows.Forms.PaintEventHandler(this.LastStudentButton_Paint);
            // 
            // NextStudentButton
            // 
            this.NextStudentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NextStudentButton.Enabled = false;
            this.NextStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NextStudentButton.FlatAppearance.BorderSize = 0;
            this.NextStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.NextStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextStudentButton.Location = new System.Drawing.Point(381, 39);
            this.NextStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextStudentButton.Name = "NextStudentButton";
            this.NextStudentButton.Size = new System.Drawing.Size(162, 38);
            this.NextStudentButton.TabIndex = 2;
            this.NextStudentButton.Text = "> Next Student";
            this.NextStudentButton.UseVisualStyleBackColor = false;
            this.NextStudentButton.Click += new System.EventHandler(this.NextStudentButton_Click);
            this.NextStudentButton.Paint += new System.Windows.Forms.PaintEventHandler(this.NextStudentButton_Paint);
            // 
            // PrevStudentButton
            // 
            this.PrevStudentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PrevStudentButton.Enabled = false;
            this.PrevStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrevStudentButton.FlatAppearance.BorderSize = 0;
            this.PrevStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.PrevStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevStudentButton.Location = new System.Drawing.Point(201, 39);
            this.PrevStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrevStudentButton.Name = "PrevStudentButton";
            this.PrevStudentButton.Size = new System.Drawing.Size(162, 38);
            this.PrevStudentButton.TabIndex = 1;
            this.PrevStudentButton.Text = "< PrevStudent";
            this.PrevStudentButton.UseVisualStyleBackColor = false;
            this.PrevStudentButton.Click += new System.EventHandler(this.PrevStudentButton_Click);
            this.PrevStudentButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PrevStudentButton_Paint);
            // 
            // FirstStudentButton
            // 
            this.FirstStudentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstStudentButton.Enabled = false;
            this.FirstStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FirstStudentButton.FlatAppearance.BorderSize = 0;
            this.FirstStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstStudentButton.Location = new System.Drawing.Point(21, 39);
            this.FirstStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstStudentButton.Name = "FirstStudentButton";
            this.FirstStudentButton.Size = new System.Drawing.Size(162, 38);
            this.FirstStudentButton.TabIndex = 0;
            this.FirstStudentButton.Text = "<<First Student";
            this.FirstStudentButton.UseVisualStyleBackColor = false;
            this.FirstStudentButton.Click += new System.EventHandler(this.FirstStudentButton_Click);
            this.FirstStudentButton.Paint += new System.Windows.Forms.PaintEventHandler(this.FirstStudentButton_Paint);
            // 
            // StudentInfoGroupBox
            // 
            this.StudentInfoGroupBox.Controls.Add(this.SaveNameButton);
            this.StudentInfoGroupBox.Controls.Add(this.StudentNameInputTxtBox);
            this.StudentInfoGroupBox.Controls.Add(this.CurrentStudentLabel);
            this.StudentInfoGroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfoGroupBox.Location = new System.Drawing.Point(15, 304);
            this.StudentInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            this.StudentInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentInfoGroupBox.Size = new System.Drawing.Size(791, 95);
            this.StudentInfoGroupBox.TabIndex = 2;
            this.StudentInfoGroupBox.TabStop = false;
            this.StudentInfoGroupBox.Text = "Student Info";
            // 
            // SaveNameButton
            // 
            this.SaveNameButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveNameButton.Enabled = false;
            this.SaveNameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveNameButton.FlatAppearance.BorderSize = 0;
            this.SaveNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNameButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNameButton.Location = new System.Drawing.Point(614, 34);
            this.SaveNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveNameButton.Name = "SaveNameButton";
            this.SaveNameButton.Size = new System.Drawing.Size(156, 38);
            this.SaveNameButton.TabIndex = 5;
            this.SaveNameButton.Text = "Save Name";
            this.SaveNameButton.UseVisualStyleBackColor = false;
            this.SaveNameButton.Click += new System.EventHandler(this.SaveNameButton_Click);
            this.SaveNameButton.Paint += new System.Windows.Forms.PaintEventHandler(this.SaveNameButton_Paint);
            // 
            // StudentNameInputTxtBox
            // 
            this.StudentNameInputTxtBox.Location = new System.Drawing.Point(184, 41);
            this.StudentNameInputTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentNameInputTxtBox.Name = "StudentNameInputTxtBox";
            this.StudentNameInputTxtBox.Size = new System.Drawing.Size(403, 26);
            this.StudentNameInputTxtBox.TabIndex = 1;
            // 
            // CurrentStudentLabel
            // 
            this.CurrentStudentLabel.AutoSize = true;
            this.CurrentStudentLabel.Location = new System.Drawing.Point(18, 44);
            this.CurrentStudentLabel.Name = "CurrentStudentLabel";
            this.CurrentStudentLabel.Size = new System.Drawing.Size(112, 18);
            this.CurrentStudentLabel.TabIndex = 0;
            this.CurrentStudentLabel.Text = "Student #1:";
            // 
            // StudentInfo2GroupBox
            // 
            this.StudentInfo2GroupBox.Controls.Add(this.SaveScoreButton);
            this.StudentInfo2GroupBox.Controls.Add(this.AssignScoreTxtBox);
            this.StudentInfo2GroupBox.Controls.Add(this.EnterAssignTxtBox);
            this.StudentInfo2GroupBox.Controls.Add(this.AssignScoreLabel);
            this.StudentInfo2GroupBox.Controls.Add(this.EnterAssignNumLabel);
            this.StudentInfo2GroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfo2GroupBox.Location = new System.Drawing.Point(15, 421);
            this.StudentInfo2GroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentInfo2GroupBox.Name = "StudentInfo2GroupBox";
            this.StudentInfo2GroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentInfo2GroupBox.Size = new System.Drawing.Size(791, 116);
            this.StudentInfo2GroupBox.TabIndex = 3;
            this.StudentInfo2GroupBox.TabStop = false;
            this.StudentInfo2GroupBox.Text = "Student Info";
            // 
            // SaveScoreButton
            // 
            this.SaveScoreButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveScoreButton.Enabled = false;
            this.SaveScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveScoreButton.FlatAppearance.BorderSize = 0;
            this.SaveScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveScoreButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveScoreButton.Location = new System.Drawing.Point(518, 40);
            this.SaveScoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveScoreButton.Name = "SaveScoreButton";
            this.SaveScoreButton.Size = new System.Drawing.Size(117, 38);
            this.SaveScoreButton.TabIndex = 5;
            this.SaveScoreButton.Text = "Save Score";
            this.SaveScoreButton.UseVisualStyleBackColor = false;
            this.SaveScoreButton.Click += new System.EventHandler(this.SaveScoreButton_Click);
            this.SaveScoreButton.Paint += new System.Windows.Forms.PaintEventHandler(this.SaveScoreButton_Paint);
            // 
            // AssignScoreTxtBox
            // 
            this.AssignScoreTxtBox.Location = new System.Drawing.Point(352, 68);
            this.AssignScoreTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AssignScoreTxtBox.Name = "AssignScoreTxtBox";
            this.AssignScoreTxtBox.Size = new System.Drawing.Size(112, 26);
            this.AssignScoreTxtBox.TabIndex = 3;
            // 
            // EnterAssignTxtBox
            // 
            this.EnterAssignTxtBox.Location = new System.Drawing.Point(352, 27);
            this.EnterAssignTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterAssignTxtBox.Name = "EnterAssignTxtBox";
            this.EnterAssignTxtBox.Size = new System.Drawing.Size(112, 26);
            this.EnterAssignTxtBox.TabIndex = 2;
            // 
            // AssignScoreLabel
            // 
            this.AssignScoreLabel.AutoSize = true;
            this.AssignScoreLabel.Location = new System.Drawing.Point(71, 71);
            this.AssignScoreLabel.Name = "AssignScoreLabel";
            this.AssignScoreLabel.Size = new System.Drawing.Size(175, 18);
            this.AssignScoreLabel.TabIndex = 1;
            this.AssignScoreLabel.Text = "Assignment Score: ";
            // 
            // EnterAssignNumLabel
            // 
            this.EnterAssignNumLabel.AutoSize = true;
            this.EnterAssignNumLabel.Location = new System.Drawing.Point(18, 31);
            this.EnterAssignNumLabel.Name = "EnterAssignNumLabel";
            this.EnterAssignNumLabel.Size = new System.Drawing.Size(253, 18);
            this.EnterAssignNumLabel.TabIndex = 0;
            this.EnterAssignNumLabel.Text = "Enter Assignment Number : ";
            // 
            // ScoresDisplayRchTxtBox
            // 
            this.ScoresDisplayRchTxtBox.Location = new System.Drawing.Point(15, 590);
            this.ScoresDisplayRchTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScoresDisplayRchTxtBox.Name = "ScoresDisplayRchTxtBox";
            this.ScoresDisplayRchTxtBox.Size = new System.Drawing.Size(879, 218);
            this.ScoresDisplayRchTxtBox.TabIndex = 4;
            this.ScoresDisplayRchTxtBox.Text = "";
            // 
            // DisplayScoresButton
            // 
            this.DisplayScoresButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisplayScoresButton.Enabled = false;
            this.DisplayScoresButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DisplayScoresButton.FlatAppearance.BorderSize = 0;
            this.DisplayScoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplayScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayScoresButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayScoresButton.Location = new System.Drawing.Point(381, 545);
            this.DisplayScoresButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayScoresButton.Name = "DisplayScoresButton";
            this.DisplayScoresButton.Size = new System.Drawing.Size(150, 38);
            this.DisplayScoresButton.TabIndex = 6;
            this.DisplayScoresButton.Text = "Display Scores";
            this.DisplayScoresButton.UseVisualStyleBackColor = false;
            this.DisplayScoresButton.Click += new System.EventHandler(this.DisplayScoresButton_Click);
            this.DisplayScoresButton.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayScoresButton_Paint);
            // 
            // ResetScoresButton
            // 
            this.ResetScoresButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ResetScoresButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetScoresButton.FlatAppearance.BorderSize = 0;
            this.ResetScoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.ResetScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetScoresButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetScoresButton.Location = new System.Drawing.Point(759, 52);
            this.ResetScoresButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetScoresButton.Name = "ResetScoresButton";
            this.ResetScoresButton.Size = new System.Drawing.Size(135, 74);
            this.ResetScoresButton.TabIndex = 7;
            this.ResetScoresButton.Text = "Reset Scores";
            this.ResetScoresButton.UseVisualStyleBackColor = false;
            this.ResetScoresButton.Click += new System.EventHandler(this.ResetScoresButton_Click);
            this.ResetScoresButton.Paint += new System.Windows.Forms.PaintEventHandler(this.ResetScoresButton_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 828);
            this.Controls.Add(this.ResetScoresButton);
            this.Controls.Add(this.DisplayScoresButton);
            this.Controls.Add(this.ScoresDisplayRchTxtBox);
            this.Controls.Add(this.StudentInfo2GroupBox);
            this.Controls.Add(this.StudentInfoGroupBox);
            this.Controls.Add(this.NavigateGroupBox);
            this.Controls.Add(this.CountsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "GradeCalc";
            this.CountsGroupBox.ResumeLayout(false);
            this.CountsGroupBox.PerformLayout();
            this.NavigateGroupBox.ResumeLayout(false);
            this.StudentInfoGroupBox.ResumeLayout(false);
            this.StudentInfoGroupBox.PerformLayout();
            this.StudentInfo2GroupBox.ResumeLayout(false);
            this.StudentInfo2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CountsGroupBox;
        private System.Windows.Forms.Label NumOfStudentsLabel;
        private System.Windows.Forms.Button SubmitCountsButton;
        private System.Windows.Forms.TextBox NumofAssignTxtBox;
        private System.Windows.Forms.TextBox NumofStudentsTxtBox;
        private System.Windows.Forms.Label NumOfAssignLabel;
        private System.Windows.Forms.GroupBox NavigateGroupBox;
        private System.Windows.Forms.Button FirstStudentButton;
        private System.Windows.Forms.Button LastStudentButton;
        private System.Windows.Forms.Button NextStudentButton;
        private System.Windows.Forms.Button PrevStudentButton;
        private System.Windows.Forms.GroupBox StudentInfoGroupBox;
        private System.Windows.Forms.Button SaveNameButton;
        private System.Windows.Forms.TextBox StudentNameInputTxtBox;
        private System.Windows.Forms.Label CurrentStudentLabel;
        private System.Windows.Forms.GroupBox StudentInfo2GroupBox;
        private System.Windows.Forms.Button SaveScoreButton;
        private System.Windows.Forms.TextBox AssignScoreTxtBox;
        private System.Windows.Forms.TextBox EnterAssignTxtBox;
        private System.Windows.Forms.Label AssignScoreLabel;
        private System.Windows.Forms.Label EnterAssignNumLabel;
        private System.Windows.Forms.RichTextBox ScoresDisplayRchTxtBox;
        private System.Windows.Forms.Button DisplayScoresButton;
        private System.Windows.Forms.Button ResetScoresButton;
    }
}

