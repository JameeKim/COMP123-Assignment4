using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Testing;

namespace GPACalculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Course> courses;

            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, "Courses.json");
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string input;

                using (TextReader reader = new StreamReader(filePath))
                {
                    input = reader.ReadToEnd();
                }

               courses = serializer.Deserialize<List<Course>>(input);
            }
            catch (Exception e)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Unable to read course list from file!");
                builder.AppendLine("Failed to start the application.");
                builder.AppendLine();
                builder.Append(e);
                MessageBox.Show(builder.ToString(), "Error", MessageBoxButtons.OK);
                return;
            }

            courses.Sort();
            Application.Run(new SplashScreen(courses));
        }
    }
}
