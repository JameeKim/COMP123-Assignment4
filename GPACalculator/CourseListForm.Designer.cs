namespace GPACalculator
{
    partial class CourseListForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.backButtonPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.coursesListView = new System.Windows.Forms.DataGridView();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchCodeLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchCodeLabel = new System.Windows.Forms.Label();
            this.searchCode = new System.Windows.Forms.ComboBox();
            this.searchNameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.ComboBox();
            this.searchSemesterLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchYearLabel = new System.Windows.Forms.Label();
            this.searchSeasonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchSeasonLabel = new System.Windows.Forms.Label();
            this.searchSeason = new System.Windows.Forms.ComboBox();
            this.searchYear = new System.Windows.Forms.ComboBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.addCoursesButton = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlePanel.SuspendLayout();
            this.backButtonPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesListView)).BeginInit();
            this.searchGroup.SuspendLayout();
            this.searchLayout.SuspendLayout();
            this.searchCodeLayout.SuspendLayout();
            this.searchNameLayout.SuspendLayout();
            this.searchSemesterLayout.SuspendLayout();
            this.searchSeasonLayout.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(964, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Courses";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.backButtonPanel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(964, 50);
            this.titlePanel.TabIndex = 2;
            // 
            // backButtonPanel
            // 
            this.backButtonPanel.Controls.Add(this.backButton);
            this.backButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.backButtonPanel.Name = "backButtonPanel";
            this.backButtonPanel.Padding = new System.Windows.Forms.Padding(5);
            this.backButtonPanel.Size = new System.Drawing.Size(104, 50);
            this.backButtonPanel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(5, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.coursesListView);
            this.contentPanel.Controls.Add(this.searchGroup);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 50);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(964, 631);
            this.contentPanel.TabIndex = 3;
            // 
            // coursesListView
            // 
            this.coursesListView.AllowUserToAddRows = false;
            this.coursesListView.AllowUserToDeleteRows = false;
            this.coursesListView.AutoGenerateColumns = false;
            this.coursesListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.coursesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.coursesListView.DataSource = this.courseBindingSource;
            this.coursesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursesListView.Location = new System.Drawing.Point(0, 100);
            this.coursesListView.Name = "coursesListView";
            this.coursesListView.ReadOnly = true;
            this.coursesListView.RowTemplate.Height = 23;
            this.coursesListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coursesListView.Size = new System.Drawing.Size(964, 531);
            this.coursesListView.TabIndex = 1;
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.searchLayout);
            this.searchGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroup.Location = new System.Drawing.Point(0, 0);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(964, 100);
            this.searchGroup.TabIndex = 0;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // searchLayout
            // 
            this.searchLayout.Controls.Add(this.searchCodeLayout);
            this.searchLayout.Controls.Add(this.searchNameLayout);
            this.searchLayout.Controls.Add(this.searchSemesterLayout);
            this.searchLayout.Controls.Add(this.searchSeasonLayout);
            this.searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLayout.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLayout.Location = new System.Drawing.Point(3, 30);
            this.searchLayout.Name = "searchLayout";
            this.searchLayout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.searchLayout.Size = new System.Drawing.Size(958, 67);
            this.searchLayout.TabIndex = 0;
            // 
            // searchCodeLayout
            // 
            this.searchCodeLayout.Controls.Add(this.searchCodeLabel);
            this.searchCodeLayout.Controls.Add(this.searchCode);
            this.searchCodeLayout.Location = new System.Drawing.Point(30, 3);
            this.searchCodeLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchCodeLayout.Name = "searchCodeLayout";
            this.searchCodeLayout.Size = new System.Drawing.Size(162, 61);
            this.searchCodeLayout.TabIndex = 0;
            // 
            // searchCodeLabel
            // 
            this.searchCodeLabel.AutoSize = true;
            this.searchCodeLabel.Location = new System.Drawing.Point(3, 0);
            this.searchCodeLabel.Name = "searchCodeLabel";
            this.searchCodeLabel.Size = new System.Drawing.Size(40, 18);
            this.searchCodeLabel.TabIndex = 0;
            this.searchCodeLabel.Text = "Code";
            // 
            // searchCode
            // 
            this.searchCode.FormattingEnabled = true;
            this.searchCode.Location = new System.Drawing.Point(3, 21);
            this.searchCode.Name = "searchCode";
            this.searchCode.Size = new System.Drawing.Size(150, 26);
            this.searchCode.TabIndex = 1;
            this.searchCode.SelectedValueChanged += new System.EventHandler(this.RefreshCourses);
            this.searchCode.TextChanged += new System.EventHandler(this.RefreshCourses);
            // 
            // searchNameLayout
            // 
            this.searchNameLayout.Controls.Add(this.searchNameLabel);
            this.searchNameLayout.Controls.Add(this.searchName);
            this.searchNameLayout.Location = new System.Drawing.Point(212, 3);
            this.searchNameLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchNameLayout.Name = "searchNameLayout";
            this.searchNameLayout.Size = new System.Drawing.Size(311, 61);
            this.searchNameLayout.TabIndex = 1;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(3, 0);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(45, 18);
            this.searchNameLabel.TabIndex = 0;
            this.searchNameLabel.Text = "Name";
            // 
            // searchName
            // 
            this.searchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchName.FormattingEnabled = true;
            this.searchName.Location = new System.Drawing.Point(3, 21);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(304, 26);
            this.searchName.TabIndex = 1;
            this.searchName.TextUpdate += new System.EventHandler(this.RefreshCourses);
            this.searchName.SelectedValueChanged += new System.EventHandler(this.RefreshCourses);
            this.searchName.TextChanged += new System.EventHandler(this.RefreshCourses);
            // 
            // searchSemesterLayout
            // 
            this.searchSemesterLayout.Controls.Add(this.searchYearLabel);
            this.searchSemesterLayout.Controls.Add(this.searchYear);
            this.searchSemesterLayout.Location = new System.Drawing.Point(543, 3);
            this.searchSemesterLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchSemesterLayout.Name = "searchSemesterLayout";
            this.searchSemesterLayout.Size = new System.Drawing.Size(109, 61);
            this.searchSemesterLayout.TabIndex = 2;
            // 
            // searchYearLabel
            // 
            this.searchYearLabel.AutoSize = true;
            this.searchYearLabel.Location = new System.Drawing.Point(3, 0);
            this.searchYearLabel.Name = "searchYearLabel";
            this.searchYearLabel.Size = new System.Drawing.Size(34, 18);
            this.searchYearLabel.TabIndex = 0;
            this.searchYearLabel.Text = "Year";
            // 
            // searchSeasonLayout
            // 
            this.searchSeasonLayout.Controls.Add(this.searchSeasonLabel);
            this.searchSeasonLayout.Controls.Add(this.searchSeason);
            this.searchSeasonLayout.Location = new System.Drawing.Point(672, 3);
            this.searchSeasonLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchSeasonLayout.Name = "searchSeasonLayout";
            this.searchSeasonLayout.Size = new System.Drawing.Size(129, 61);
            this.searchSeasonLayout.TabIndex = 3;
            // 
            // searchSeasonLabel
            // 
            this.searchSeasonLabel.AutoSize = true;
            this.searchSeasonLabel.Location = new System.Drawing.Point(3, 0);
            this.searchSeasonLabel.Name = "searchSeasonLabel";
            this.searchSeasonLabel.Size = new System.Drawing.Size(52, 18);
            this.searchSeasonLabel.TabIndex = 0;
            this.searchSeasonLabel.Text = "Season";
            // 
            // searchSeason
            // 
            this.searchSeason.FormattingEnabled = true;
            this.searchSeason.Location = new System.Drawing.Point(3, 21);
            this.searchSeason.Name = "searchSeason";
            this.searchSeason.Size = new System.Drawing.Size(121, 26);
            this.searchSeason.TabIndex = 1;
            this.searchSeason.SelectedValueChanged += new System.EventHandler(this.RefreshCourses);
            this.searchSeason.TextChanged += new System.EventHandler(this.RefreshCourses);
            // 
            // searchYear
            // 
            this.searchYear.FormattingEnabled = true;
            this.searchYear.Location = new System.Drawing.Point(3, 21);
            this.searchYear.Name = "searchYear";
            this.searchYear.Size = new System.Drawing.Size(97, 26);
            this.searchYear.TabIndex = 1;
            this.searchYear.SelectedValueChanged += new System.EventHandler(this.RefreshCourses);
            this.searchYear.TextChanged += new System.EventHandler(this.RefreshCourses);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.addCoursesButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 626);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(964, 55);
            this.footerPanel.TabIndex = 4;
            // 
            // addCoursesButton
            // 
            this.addCoursesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCoursesButton.Location = new System.Drawing.Point(802, 13);
            this.addCoursesButton.Name = "addCoursesButton";
            this.addCoursesButton.Size = new System.Drawing.Size(150, 30);
            this.addCoursesButton.TabIndex = 0;
            this.addCoursesButton.Text = "Add Selected Courses";
            this.addCoursesButton.UseVisualStyleBackColor = true;
            this.addCoursesButton.Click += new System.EventHandler(this.addCoursesButton_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 65;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 70;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterDataGridViewTextBoxColumn.Width = 92;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GPACalculator.Course);
            // 
            // CourseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseListForm";
            this.Text = "CourseListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseListForm_FormClosing);
            this.Load += new System.EventHandler(this.CourseListForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.backButtonPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesListView)).EndInit();
            this.searchGroup.ResumeLayout(false);
            this.searchLayout.ResumeLayout(false);
            this.searchCodeLayout.ResumeLayout(false);
            this.searchCodeLayout.PerformLayout();
            this.searchNameLayout.ResumeLayout(false);
            this.searchNameLayout.PerformLayout();
            this.searchSemesterLayout.ResumeLayout(false);
            this.searchSemesterLayout.PerformLayout();
            this.searchSeasonLayout.ResumeLayout(false);
            this.searchSeasonLayout.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.DataGridView coursesListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.FlowLayoutPanel searchLayout;
        private System.Windows.Forms.FlowLayoutPanel searchCodeLayout;
        private System.Windows.Forms.Label searchCodeLabel;
        private System.Windows.Forms.ComboBox searchCode;
        private System.Windows.Forms.Panel backButtonPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel searchNameLayout;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.ComboBox searchName;
        private System.Windows.Forms.FlowLayoutPanel searchSemesterLayout;
        private System.Windows.Forms.Label searchYearLabel;
        private System.Windows.Forms.FlowLayoutPanel searchSeasonLayout;
        private System.Windows.Forms.Label searchSeasonLabel;
        private System.Windows.Forms.ComboBox searchSeason;
        private System.Windows.Forms.ComboBox searchYear;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button addCoursesButton;
    }
}
