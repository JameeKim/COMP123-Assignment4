using System.ComponentModel;

namespace GPACalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.viewCoursesButton = new System.Windows.Forms.Button();
            this.gradeList = new System.Windows.Forms.DataGridView();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.viewCoursesButtonPanel = new System.Windows.Forms.Panel();
            this.gradeEdit = new System.Windows.Forms.NumericUpDown();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaValue = new System.Windows.Forms.Label();
            this.removeCoursesButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.verticalLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradeList)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.viewCoursesButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeEdit)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.verticalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(964, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GPA Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewCoursesButton
            // 
            this.viewCoursesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCoursesButton.Location = new System.Drawing.Point(5, 5);
            this.viewCoursesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewCoursesButton.Name = "viewCoursesButton";
            this.viewCoursesButton.Size = new System.Drawing.Size(114, 50);
            this.viewCoursesButton.TabIndex = 1;
            this.viewCoursesButton.Text = "View Courses";
            this.viewCoursesButton.UseVisualStyleBackColor = true;
            this.viewCoursesButton.Click += new System.EventHandler(this.viewCoursesButton_Click);
            // 
            // gradeList
            // 
            this.gradeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeList.AutoGenerateColumns = false;
            this.gradeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradeDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.gradeList.DataSource = this.gradeEntryBindingSource;
            this.gradeList.Location = new System.Drawing.Point(3, 3);
            this.gradeList.Name = "gradeList";
            this.gradeList.RowTemplate.Height = 23;
            this.gradeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gradeList.Size = new System.Drawing.Size(958, 480);
            this.gradeList.StandardTab = true;
            this.gradeList.TabIndex = 2;
            this.gradeList.SelectionChanged += new System.EventHandler(this.gradeList_SelectionChanged);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.viewCoursesButtonPanel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(964, 60);
            this.titlePanel.TabIndex = 3;
            // 
            // viewCoursesButtonPanel
            // 
            this.viewCoursesButtonPanel.Controls.Add(this.viewCoursesButton);
            this.viewCoursesButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewCoursesButtonPanel.Location = new System.Drawing.Point(840, 0);
            this.viewCoursesButtonPanel.Name = "viewCoursesButtonPanel";
            this.viewCoursesButtonPanel.Padding = new System.Windows.Forms.Padding(5);
            this.viewCoursesButtonPanel.Size = new System.Drawing.Size(124, 60);
            this.viewCoursesButtonPanel.TabIndex = 1;
            // 
            // gradeEdit
            // 
            this.gradeEdit.Location = new System.Drawing.Point(61, 3);
            this.gradeEdit.Name = "gradeEdit";
            this.gradeEdit.Size = new System.Drawing.Size(120, 25);
            this.gradeEdit.TabIndex = 3;
            this.gradeEdit.ValueChanged += new System.EventHandler(this.gradeEdit_ValueChanged);
            // 
            // gpaLabel
            // 
            this.gpaLabel.Location = new System.Drawing.Point(3, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(83, 20);
            this.gpaLabel.TabIndex = 5;
            this.gpaLabel.Text = "Overall GPA";
            // 
            // gpaValue
            // 
            this.gpaValue.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaValue.Location = new System.Drawing.Point(92, 0);
            this.gpaValue.Name = "gpaValue";
            this.gpaValue.Size = new System.Drawing.Size(50, 20);
            this.gpaValue.TabIndex = 6;
            this.gpaValue.Text = "100.00";
            this.gpaValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // removeCoursesButton
            // 
            this.removeCoursesButton.Location = new System.Drawing.Point(749, 12);
            this.removeCoursesButton.Name = "removeCoursesButton";
            this.removeCoursesButton.Size = new System.Drawing.Size(200, 40);
            this.removeCoursesButton.TabIndex = 4;
            this.removeCoursesButton.Text = "Remove Selected Courses";
            this.removeCoursesButton.UseVisualStyleBackColor = true;
            this.removeCoursesButton.Click += new System.EventHandler(this.removeCoursesButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.loadButton);
            this.footerPanel.Controls.Add(this.saveButton);
            this.footerPanel.Controls.Add(this.flowLayoutPanel3);
            this.footerPanel.Controls.Add(this.flowLayoutPanel2);
            this.footerPanel.Controls.Add(this.removeCoursesButton);
            this.footerPanel.Location = new System.Drawing.Point(3, 489);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(958, 112);
            this.footerPanel.TabIndex = 3;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(165, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(150, 40);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load Grades";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 40);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Grades";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.gradeEdit);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(508, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(190, 35);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gpaLabel);
            this.flowLayoutPanel2.Controls.Add(this.gpaValue);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(407, 75);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 27);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // verticalLayout
            // 
            this.verticalLayout.Controls.Add(this.gradeList);
            this.verticalLayout.Controls.Add(this.footerPanel);
            this.verticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.verticalLayout.Location = new System.Drawing.Point(0, 60);
            this.verticalLayout.Name = "verticalLayout";
            this.verticalLayout.Size = new System.Drawing.Size(964, 621);
            this.verticalLayout.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "MyGrades.json";
            this.saveFileDialog.Filter = "JSON files (*.json)|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.Filter = "JSON files (*.json)|*.json";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 70;
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
            // gradeEntryBindingSource
            // 
            this.gradeEntryBindingSource.DataSource = typeof(GPACalculator.GradeEntry);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.verticalLayout);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "GPA Calculator - Grades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeList)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.viewCoursesButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeEdit)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.verticalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeEntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewCoursesButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView gradeList;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel viewCoursesButtonPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gradeEntryBindingSource;
        private System.Windows.Forms.NumericUpDown gradeEdit;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label gpaValue;
        private System.Windows.Forms.Button removeCoursesButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.FlowLayoutPanel verticalLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadButton;
    }
}

