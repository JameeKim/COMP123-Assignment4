using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class MainForm : Form
    {
        public readonly List<Course> courses;
        public readonly DataList<GradeEntry> grades;
        private int selectedIndex = -1;

        /// <summary>
        /// Currently open course list window. We save it here in order to prevent multiple instances of the window.
        /// </summary>
        private CourseListForm coursesWindow;

        public MainForm(List<Course> courses)
        {
            this.courses = courses;
            grades = new DataList<GradeEntry>();
            InitializeComponent();
        }

        /// <summary>
        /// Clear the reference to the currently open course list window.
        /// </summary>
        public void ClearCoursesWindow()
        {
            coursesWindow = null;
        }

        /// <summary>
        /// Initialize when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            gradeEntryBindingSource.DataSource = grades;
            grades.ListChanged += CalculateAndShowGPA; // calculate the GPA whenever the list changes
        }

        /// <summary>
        /// Newly calculate the GPA and show it to the user
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void CalculateAndShowGPA(object sender, ListChangedEventArgs e)
        {
            if (grades.Count == 0)
            {
                gpaValue.Text = "N/A";
                return;
            }

            double gpa = grades.Average(entry => entry.Grade); // LINQ method (Average)
            gpaValue.Text = $"{gpa:F2}";
        }

        /// <summary>
        /// Open a new course list window if not open; focus the window if open.
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            if (coursesWindow != null)
            {
                coursesWindow.Focus();
            }
            else
            {
                coursesWindow = new CourseListForm(this);
                coursesWindow.Show();
            }
        }

        /// <summary>
        /// Make the grade editable when single entry is selected
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void gradeList_SelectionChanged(object sender, EventArgs e)
        {
            // get the list of selected rows
            DataGridViewSelectedRowCollection selectedRows = gradeList.SelectedRows;

            // disable editing when multiple or no entries are selected
            if (selectedRows.Count != 1)
            {
                selectedIndex = -1;
                gradeEdit.Enabled = false;
                return;
            }

            // store the index of the selected row
            selectedIndex = grades.IndexOf(new GradeEntry(selectedRows[0]));

            // display the grade value and enable editing
            gradeEdit.Value = grades[selectedIndex].Grade;
            gradeEdit.Enabled = true;
        }

        /// <summary>
        /// Set the grade to the new value
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void gradeEdit_ValueChanged(object sender, EventArgs e)
        {
            // do nothing if the index is invalid
            if (selectedIndex < 0)
            {
                return;
            }

            GradeEntry grade = grades[selectedIndex];
            grade.Grade = (int)gradeEdit.Value;
            grades.SendChangedEvent(selectedIndex); // this is important
        }

        /// <summary>
        /// Remove selected entries from the list
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void removeCoursesButton_Click(object sender, EventArgs e)
        {
            // get the list of selected rows
            DataGridViewSelectedRowCollection selectedRows = gradeList.SelectedRows;
            List<GradeEntry> entriesToRemove = new List<GradeEntry>();

            foreach (object rowObject in selectedRows)
            {
                if (rowObject is DataGridViewRow row) // cast to DataGridViewRow
                {
                    entriesToRemove.Add(new GradeEntry(row));
                }
            }

            if (entriesToRemove.Count > 0)
            {
                grades.RemoveBatch(entriesToRemove);
                coursesWindow?.RefreshCourses(); // refresh the course list; add removed courses back into the list
            }
        }

        /// <summary>
        /// Save current grade entries to a JSON file
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream stream = saveFileDialog.OpenFile();

            if (stream == null)
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(stream))
            {
                try
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    string output = serializer.Serialize(grades.List);
                    writer.WriteLine(output);
                }
                catch (IOException)
                {
                    ShowError("Failed to save: error while writing to the file");
                }
                catch
                {
                    ShowError("Failed to save: error occurred");
                }
            }
        }

        /// <summary>
        /// Load grade entries from specified JSON file
        /// </summary>
        /// <param name="sender">Target control that invoked this event</param>
        /// <param name="e">Arguments passed to this event</param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream stream = openFileDialog.OpenFile();

            if (stream == null)
            {
                return;
            }

            using (StreamReader reader = new StreamReader(stream))
            {
                try
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    string input = reader.ReadToEnd(); // serialized data
                    GradeEntry[] entries = serializer.Deserialize<GradeEntry[]>(input); // deserialized data
                    grades.ResetTo(entries); // replace all entries with the deserialized data
                    coursesWindow?.RefreshCourses(); // refresh the course list; filter out courses in the list
                }
                catch (OutOfMemoryException)
                {
                    ShowError("Failed to load: out of memory");
                }
                catch (IOException)
                {
                    ShowError("Failed to load: error while reading the file");
                }
                catch
                {
                    ShowError("Failed to load: the file is not formatted properly");
                }
            }
        }

        /// <summary>
        /// Show an error message to the user
        /// </summary>
        /// <param name="message">Message to show</param>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }
    }
}

