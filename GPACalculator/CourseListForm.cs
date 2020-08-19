using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GPACalculator
{
    /// <summary>
    /// Secondary window with the list of available courses
    /// </summary>
    public partial class CourseListForm : Form
    {
        /// <summary>
        /// Reference to the main form
        /// </summary>
        private readonly MainForm mainForm;

        public CourseListForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        /// <summary>
        /// Refresh the list of courses, applying all filters
        /// </summary>
        /// <param name="sender">Invoker of the event, if any</param>
        /// <param name="e">Arguments for the event, if any</param>
        public void RefreshCourses(object sender = null, EventArgs e = null)
        {
            coursesListView.DataSource = mainForm.courses.FindAll(FilterPredicate);
        }

        /// <summary>
        /// Method to figure out if the given course object should be shown in the DataGridView
        /// </summary>
        /// <param name="course">Course object to be tested</param>
        /// <returns>True if the object should be shown, false if not</returns>
        private bool FilterPredicate(Course course)
        {
            // Only filter out already included courses if search is disabled
            if (!searchEnabled.Checked)
            {
                return !mainForm.grades.Contains(new GradeEntry(course));
            }

            // All strings must be converted to lowercase in order to make the search case-insensitive
            string semester = course.Semester.ToString().ToLower();

            return !mainForm.grades.Contains(new GradeEntry(course))
                && course.Code.ToLower().Contains(searchCode.Text.ToLower())
                && course.Name.ToLower().Contains(searchName.Text.ToLower())
                && semester.Contains(searchYear.Text) // year text will only contain digits; no need to make lowercase
                && semester.Contains(searchSeason.Text.ToLower());
        }

        /// <summary>
        /// Clear the reference to this object in the main form before closing the window
        /// </summary>
        /// <param name="sender">Invoker of this event</param>
        /// <param name="e">Arguments for this event</param>
        private void CourseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.ClearCoursesWindow();
        }

        /// <summary>
        /// Initialize when the window is loaded
        /// </summary>
        /// <param name="sender">Invoker of this event</param>
        /// <param name="e">Arguments for this event</param>
        private void CourseListForm_Load(object sender, EventArgs e)
        {
            RefreshCourses(sender, e);

            // Get values for course codes
            List<string> codes = new List<string> { "" };
            codes.AddRange(mainForm.courses.Select(course => course.Code).Distinct());
            codes.Sort();
            searchCode.DataSource = codes;

            // Get values for course names
            List<string> names = new List<string> { "" };
            names.AddRange(mainForm.courses.Select(course => course.Name).Distinct());
            names.Sort();
            searchName.DataSource = names;

            // Get values for course years
            List<string> years = new List<string> { "" };
            years.AddRange(
                mainForm.courses.Select(course => course.Semester.year).Distinct().Select(year => year.ToString()));
            years.Sort();
            searchYear.DataSource = years;

            // Fill in values for semester seasons
            searchSeason.DataSource = new List<string>
            {
                "",
                Season.Winter.ToString(),
                Season.Summer.ToString(),
                Season.Fall.ToString(),
            };
        }

        /// <summary>
        /// Close the window when the back button is clicked
        /// </summary>
        /// <param name="sender">Invoker of this event</param>
        /// <param name="e">Arguments for this event</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add selected courses to the grades list
        /// </summary>
        /// <param name="sender">Invoker of this event</param>
        /// <param name="e">Arguments for this event</param>
        private void addCoursesButton_Click(object sender, EventArgs e)
        {
            // get the list of selected rows
            DataGridViewSelectedRowCollection selectedRows = coursesListView.SelectedRows;
            List<GradeEntry> entriesToAdd = new List<GradeEntry>();

            foreach (object rowObject in selectedRows)
            {
                if (rowObject is DataGridViewRow row) // cast to DataGridViewRow
                {
                    entriesToAdd.Add(new GradeEntry(row));
                }
            }

            if (entriesToAdd.Count > 0)
            {
                mainForm.grades.AddBatch(entriesToAdd);
                mainForm.grades.Sort();
                RefreshCourses(sender, e);
            }
        }

        private void searchEnabled_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = searchEnabled.Checked;

            searchCode.Enabled = isEnabled;
            searchName.Enabled = isEnabled;
            searchYear.Enabled = isEnabled;
            searchSeason.Enabled = isEnabled;

            RefreshCourses(sender, e);
        }
    }
}
