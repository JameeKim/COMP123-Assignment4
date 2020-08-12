using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GPACalculator
{
    /// <summary>
    /// Season of a semester (fall, winter, or summer)
    /// </summary>
    public enum Season
    {
        /// <summary>
        /// Winter semester (Jan - Apr)
        /// </summary>
        Winter,

        /// <summary>
        /// Summer semester (May - Aug)
        /// </summary>
        Summer,

        /// <summary>
        /// Fall semester (Sep - Dec)
        /// </summary>
        Fall,
    }

    /// <summary>
    /// Semester with year and season
    /// </summary>
    public struct Semester : IEquatable<Semester>, IComparable<Semester>
    {
        public Semester(int year, Season season)
        {
            this.year = year;
            this.season = season;
        }

        /// <summary>
        /// The year of the semester
        /// </summary>
        public readonly int year;

        /// <summary>
        /// The season of the semester
        /// </summary>
        public readonly Season season;

        public override string ToString()
        {
            return $"{season} {year}";
        }

        // Implementations related to equality and comparison
        // Year is compared first, then season
        #region Equality

        public override bool Equals(object obj) => obj is Semester semester && Equals(semester);
        public bool Equals(Semester other) => year == other.year && season == other.season;

        // Generated code
        public override int GetHashCode()
        {
            var hashCode = -1448333612;
            hashCode = hashCode * -1521134295 + year.GetHashCode();
            hashCode = hashCode * -1521134295 + season.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Semester lhs, Semester rhs) => lhs.year == rhs.year && lhs.season == rhs.season;
        public static bool operator !=(Semester lhs, Semester rhs) => lhs.year != rhs.year || lhs.season != rhs.season;

        public int CompareTo(Semester other) =>
            year == other.year ? season.CompareTo(other.season) : year.CompareTo(other.year);

        #endregion
    }

    /// <summary>
    /// Course information
    /// </summary>
    public class Course : IEquatable<Course>, IComparable<Course>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Semester Semester { get; set; }

        // Empty constructor for deserialization
        public Course() { }

        public Course(DataGridViewRow row)
        {
            Code = (string)row.Cells["codeDataGridViewTextBoxColumn"].Value;
            Name = (string)row.Cells["nameDataGridViewTextBoxColumn"].Value;
            Semester = (Semester)row.Cells["semesterDataGridViewTextBoxColumn"].Value;
        }

        public Course(string code, string name, Semester semester)
        {
            Code = code;
            Name = name;
            Semester = semester;
        }

        public Course(string code, string name, int year, Season season)
        {
            Code = code;
            Name = name;
            Semester = new Semester(year, season);
        }

        // Implementations related to equality and comparison
        // Two courses are equal if the code and semester are same
        // Semester is compared first, then code
        #region Equality

        public override bool Equals(object obj) => Equals(obj as Course);
        public bool Equals(Course other) =>
            !Object.ReferenceEquals(other, null) && Code == other.Code && Semester.Equals(other.Semester);

        // Generated code
        public override int GetHashCode()
        {
            var hashCode = -1332520221;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + Semester.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Course lhs, Course rhs)
        {
            // check for null
            if (Object.ReferenceEquals(lhs, null))
            {
                // null == null, so return true if rhs is also null and false if rhs is not null
                return Object.ReferenceEquals(rhs, null);
            }

            // lhs is not null here, so this is safe to call
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Course lhs, Course rhs) => !(lhs == rhs);

        public int CompareTo(Course other) =>
            Semester == other.Semester ? Code.CompareTo(other.Code) : Semester.CompareTo(other.Semester);

        #endregion
    }

    /// <summary>
    /// Grade with course information
    /// </summary>
    ///
    /// When comparing two instances, grade is not taken into account. This is intentional, as there will never be two
    /// instances with same course and different grades in use at the same moment. This allows us to find the grade
    /// value from a list of grade entries only with an instance of course or a newly created instance of grade entry.
    public class GradeEntry : Course
    {
        private int grade = 100;

        /// <summary>
        /// Grade of this course, represented as an integer from 0 to 100
        /// </summary>
        public int Grade { get => grade; set => grade = Math.Min(100, Math.Max(0, value)); }

        // Empty constructor for deserialization
        public GradeEntry() { }

        public GradeEntry(DataGridViewRow row) : base(row) { }

        public GradeEntry(Course course, int grade = 100)
            : base(course.Code, course.Name, course.Semester)
        {
            Grade = grade;
        }
    }
}
