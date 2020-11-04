using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GradeCalc
{
    public partial class Form1 : Form
    {
        #region Attributes


        /// <summary>
        /// for number of students text box checking
        /// </summary>
        private int numberOfStudents = 0;
        /// <summary>
        /// for number of assignments text box checking
        /// </summary>
        private int numberOfAssignments = 0;
        /// <summary>
        /// for assignment number temp storage for validation
        /// </summary>
        private int assignmentNum = 0;
        /// <summary>
        /// students array
        /// </summary>
        private String[] studentsArr;
        /// <summary>
        /// Assignments 2d array
        /// </summary>
        private int[,] assignments2DArr;
        /// <summary>
        /// students array index counter
        /// </summary>
        private int studentArrIndex;
        /// <summary>
        /// submit counter
        /// </summary>
        private int submitCounter = 0;
        /// <summary>
        /// assignment score temp storage for validation
        /// </summary>
        private int assignmentScore = 0;
        /// <summary>
        /// assignment score total for average and letter grade
        /// </summary>
        private double Total = 0;

        #endregion

        #region InitializeComp
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        #region Sub Methods
        /// <summary>
        /// Turns buttons on after submit count is done correctly
        /// </summary>
        private void EnableButtons()
        {
            FirstStudentButton.Enabled = true;
            PrevStudentButton.Enabled = true;
            NextStudentButton.Enabled = true;
            LastStudentButton.Enabled = true;
            SaveNameButton.Enabled = true;
            SaveScoreButton.Enabled = true;
            DisplayScoresButton.Enabled = true;
        }

        /// <summary>
        /// disables buttons (used for reset button)
        /// </summary>
        private void DisableButtons()
        {
            FirstStudentButton.Enabled = false;
            PrevStudentButton.Enabled = false;
            NextStudentButton.Enabled = false;
            LastStudentButton.Enabled = false;
            SaveNameButton.Enabled = false;
            SaveScoreButton.Enabled = false;
            DisplayScoresButton.Enabled = false;
        }

        /// <summary>
        /// calculates average for each row
        /// </summary>
        /// <param name="Total">total amount of grades added from each row</param>
        /// <returns></returns>
        private double Average(double Total)
        {
            // variable for calculating average
            double average;

            // calculate average
            average = Total / (double)numberOfAssignments;

            // return average
            return average;
        }

        /// <summary>
        /// get the letter grade from average
        /// </summary>
        /// <param name="average"> average to find letter grade</param>
        /// <returns></returns>
        private String Grade(Double average)
        {

            //find grade from average
            if (average >= 93 && average <= 100)
            {
                return "A";
            }
            else if (average >= 90 && average <= 92.9)
            {
                return "A-";
            }
            else if (average >= 87 && average <= 89.9)
            {
                return "B+";
            }
            else if (average >= 83 && average <= 86.9)
            {
                return "B";
            }
            else if (average >= 80 && average <= 82.9)
            {
                return "B-";
            }
            else if (average >= 77 && average <= 79.9)
            {
                return "C+";
            }
            else if (average >= 73 && average <= 76.9)
            {
                return "C";
            }
            else if (average >= 70 && average <= 72.9)
            {
                return "C-";
            }
            else if (average >= 67 && average <= 69.9)
            {
                return "D+";
            }
            else if (average >= 63 && average <= 66.9)
            {
                return "D";
            }
            else if (average >= 60 && average <= 62.9)
            {
                return "D-";
            }
            else
            {
                return "E";
            }
        }
        #endregion

        #region Array Movement
        /// <summary>
        /// iterates to next student and correct row in 2DAssign array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextStudentButton_Click(object sender, EventArgs e)
        {
            //make sure array doesn't go out of bounds
            if (studentArrIndex == studentsArr.GetUpperBound(0))
            {
                //disable next button
                NextStudentButton.Enabled = false;
                //disable last button
                LastStudentButton.Enabled = false;

            }
            else
            {
                //moves index number forward one 
                studentArrIndex++;
                //changes current student label to where the index is at in students array
                CurrentStudentLabel.Text = studentsArr[studentArrIndex];
                //enable previous button
                PrevStudentButton.Enabled = true;
                //enable first button
                FirstStudentButton.Enabled = true;
                // Shows name
                StudentNameInputTxtBox.Text = studentsArr[studentArrIndex];
            }
        }
        /// <summary>
        /// iterates to previous student in students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevStudentButton_Click(object sender, EventArgs e)
        {
            //make sure array doesn't go out of bounds
            if (studentArrIndex == studentsArr.GetLowerBound(0))
            {
                //disable previous button at end of array
                PrevStudentButton.Enabled = false;
                // disable first student button
                FirstStudentButton.Enabled = false;
            }
            else
            {
                //moves index number backward one 
                studentArrIndex--;
                //changes current student label to where the index is at in students array
                CurrentStudentLabel.Text = studentsArr[studentArrIndex];
                //enable next button
                NextStudentButton.Enabled = true;
                //enable last button
                LastStudentButton.Enabled = true;
                // Shows name
                StudentNameInputTxtBox.Text = studentsArr[studentArrIndex];
            }
        }
        /// <summary>
        /// moves to the first student in students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstStudentButton_Click(object sender, EventArgs e)
        {
            // moves index to 0 (start)
            studentArrIndex = 0;
            //changes current student label to where the index is at in students array
            CurrentStudentLabel.Text = studentsArr[studentArrIndex];

            // Shows name
            StudentNameInputTxtBox.Text = studentsArr[studentArrIndex];

            // button state
            //enable next button
            NextStudentButton.Enabled = true;
            //disable Last button
            LastStudentButton.Enabled = true;
            // disable previous student button
            PrevStudentButton.Enabled = false;
            // enable first student button
            FirstStudentButton.Enabled = false;
        }
        /// <summary>
        /// moves to last student in students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastStudentButton_Click(object sender, EventArgs e)
        {
            // get the last index of array
            studentArrIndex = studentsArr.GetUpperBound(0);
            // more to the end of the array
            CurrentStudentLabel.Text = studentsArr[studentArrIndex];

            // Shows name
            StudentNameInputTxtBox.Text = studentsArr[studentArrIndex];

            // button state
            //enable next button
            NextStudentButton.Enabled = false;
            //disable Last button
            LastStudentButton.Enabled = false;
            // disable previous student button
            PrevStudentButton.Enabled = true;
            // enable first student button
            FirstStudentButton.Enabled = true;
        }


        #endregion

        #region Button Methods
        /// <summary>
        /// takes number of students & number of assignments
        /// checks for errors
        /// populates arrays & enables buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitCountsButton_Click(object sender, EventArgs e)
        {
            //submit counter for reset to no clear null arrays
            submitCounter++;

            // check text box input for number of students
            if (Int32.TryParse(NumofStudentsTxtBox.Text, out numberOfStudents) != true)
            {
                // tells user to enter a valid integer
                NumOfStudentsLabel.Text = "Enter a valid integer: ";
                // clears number of students text box
                NumofStudentsTxtBox.Text = " ";

            }
            else if (numberOfStudents < 1 || numberOfStudents > 10)
            {
                // tells user to enter a number between 1 and 10
                NumOfStudentsLabel.Text = "Integer between 1 and 10: ";
                // clears number of students text box
                NumofStudentsTxtBox.Text = " ";
            }
            else
            {
                // change label back to original
                NumOfStudentsLabel.Text = "Number of Students: ";

            }

            // check text box input for number of assignments
            if (Int32.TryParse(NumofAssignTxtBox.Text, out numberOfAssignments) != true)
            {
                // tells user to enter a valid integer
                NumOfAssignLabel.Text = "Enter a valid integer: ";
                // clears number of assignments text box
                NumofAssignTxtBox.Text = " ";
            }
            else if (numberOfAssignments < 1 || numberOfAssignments > 99)
            {
                // tells user to enter a number between 1 and 99
                NumOfAssignLabel.Text = "Integer between 1 and 99: ";
                // clears number of assignment text box
                NumofAssignTxtBox.Text = " ";
            }
            else
            {
                // change label back to original
                NumOfAssignLabel.Text = "Number of Assignments: ";

            }

            //if number have been entered in both text boxes 
            if (numberOfStudents > 0 && numberOfAssignments > 0)
            {

                // makes student array the number entered
                studentsArr = new String[numberOfStudents];

                // enter default values for students array
                for (int i = 0; i < studentsArr.Length; i++)
                {
                    studentsArr[i] = "Student #" + (i + 1);
                }

                //Shows name
                StudentNameInputTxtBox.Text = studentsArr[studentArrIndex];

                // makes assignments array the number entered
                assignments2DArr = new int[numberOfStudents, numberOfAssignments];

                // 2d array 
                for (int row = 0; row < assignments2DArr.GetLength(0); row++)
                {
                    for (int col = 0; col < assignments2DArr.GetLength(1); col++)
                    {
                        assignments2DArr[row, col] = 0;
                    }
                }

                // enable buttons if both variables are filled
                EnableButtons();

                //change number of assignments on label
                EnterAssignNumLabel.Text = "Enter Assignment Number (1-" + numberOfAssignments + "): ";

                //header for rich text box
                ScoresDisplayRchTxtBox.Text += "STUDENT \t";
                for (int j = 0; j < numberOfAssignments; j++)
                {
                    ScoresDisplayRchTxtBox.Text += "#" + (j + 1) + "\t";
                }
                ScoresDisplayRchTxtBox.Text += "AVG \t";
                ScoresDisplayRchTxtBox.Text += "GRADE \t" + Environment.NewLine;
            }

        }

        /// <summary>
        /// Resets everything to default form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetScoresButton_Click(object sender, EventArgs e)
        {
            // disable buttons to start state
            DisableButtons();
            //set all counters to 0
            studentArrIndex = 0;
            //clear all arrays

            if (submitCounter == 0)
            {
                // do nothing
            }
            else
            {
                Array.Clear(studentsArr, 0, studentsArr.Length);
                Array.Clear(assignments2DArr, 0, assignments2DArr.Length);
            }

            // clears number of students text box
            NumofStudentsTxtBox.Text = " ";
            // clears number of assignment text box
            NumofAssignTxtBox.Text = " ";
            // clears current students label
            CurrentStudentLabel.Text = "Student #1:";
            // clear text box
            StudentNameInputTxtBox.Text = "";
            // submit counter to 0
            submitCounter = 0;
            // reset rich text box
            ScoresDisplayRchTxtBox.Text = "";
        }

        /// <summary>
        /// save students name on index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNameButton_Click(object sender, EventArgs e)
        {
            // put text box input into students array
            studentsArr[studentArrIndex] = StudentNameInputTxtBox.Text;
            // clear text box
            StudentNameInputTxtBox.Text = " ";
        }

        /// <summary>
        /// save assignment scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveScoreButton_Click(object sender, EventArgs e)
        {
            // check assignment text box for correct numbers
            if (Int32.TryParse(EnterAssignTxtBox.Text, out assignmentNum) != true)
            {
                // tells user to enter a valid integer
                EnterAssignNumLabel.Text = "Enter a valid integer: ";
                // clears assignment number text box
                EnterAssignTxtBox.Text = " ";
            }
            else if (assignmentNum < 1 || assignmentNum > numberOfAssignments)
            {
                // tells user to enter a number between 1 and the amount of assignments
                EnterAssignNumLabel.Text = "Integer between 1 and " + numberOfAssignments;
                // clears assignment number text box
                EnterAssignTxtBox.Text = " ";
            }
            else
            {
                //change to original label
                EnterAssignNumLabel.Text = "Enter Assignment Number (1-" + numberOfAssignments + ")";

                // check assignment score for correct numbers
                if (Int32.TryParse(AssignScoreTxtBox.Text, out assignmentScore) != true)
                {
                    // tells user to enter a valid integer
                    AssignScoreLabel.Text = "Enter a valid integer: ";
                    // clears assignment number text box
                    AssignScoreTxtBox.Text = " ";
                }
                else if (assignmentScore < 0 || assignmentScore > 101)
                {
                    // tells user to enter a number between 1 and 100
                    AssignScoreLabel.Text = "Integer between 1 and 100";
                    // clears assignment score text box
                    AssignScoreTxtBox.Text = " ";
                }
                else
                {
                    AssignScoreTxtBox.Text = "assignmentScore: ";

                    // use assignment number and current student to determine where score is inputed in 2D array
                    assignments2DArr[studentArrIndex, assignmentNum - 1] = assignmentScore;

                    //clear text box
                    EnterAssignTxtBox.Text = " ";
                    //clear text box
                    AssignScoreTxtBox.Text = " ";

                }
            }



        }

        /// <summary>
        /// Displays student names, assignment scores and averages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayScoresButton_Click(object sender, EventArgs e)
        {
            // the mega nested loop for rich text box
            for (int row = 0; row < assignments2DArr.GetLength(0); row++)
            {
                // zero total
                Total = 0;

                // print student name
                ScoresDisplayRchTxtBox.Text += studentsArr[row] + "\t";

                // loop through grades for specific row
                for (int col = 0; col < assignments2DArr.GetLength(1); col++)
                {
                    //add numbers
                    Total += assignments2DArr[row, col];
                    // print score
                    ScoresDisplayRchTxtBox.Text += assignments2DArr[row, col].ToString() + "\t";

                }

                // print average
                ScoresDisplayRchTxtBox.Text += Average(Total).ToString() + "%\t";

                // save as variable to call Grade method (I wanted to call the average method inside the grade method but had trouble)
                double rowAverage = Average(Total);

                // print grade
                ScoresDisplayRchTxtBox.Text += Grade(rowAverage).ToString() + "\t" + Environment.NewLine;



            }
        }
        #endregion
        #endregion

        #region buttons_textbox_paint
        /// <summary>
        /// Changes submit count button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitCountsButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SubmitCountsButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes first student button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstStudentButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, FirstStudentButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes previous student button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevStudentButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PrevStudentButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes next student button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextStudentButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, NextStudentButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes last student button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastStudentButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, LastStudentButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes save name button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNameButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SaveNameButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);

        }
        /// <summary>
        /// Changes save score button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveScoreButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SaveScoreButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes reset score button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetScoresButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ResetScoresButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }
        /// <summary>
        /// Changes display scores button borders to look 3d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayScoresButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, DisplayScoresButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }

        #endregion

    }
}
