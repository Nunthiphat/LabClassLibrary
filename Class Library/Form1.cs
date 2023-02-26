using StudentClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace Class_Library
{
    public partial class Form1 : Form
    {
        List<Student> listStudents = new List<Student>();
        StudentController controller = new StudentController();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_student_id = this.tbID.Text;
            Student newStudent = new Student(input_name, input_student_id);
            this.listStudents.Add(newStudent);
            for(int i = 0; i < this.listStudents.Count; i++)
            {
                Student currentStudent = this.listStudents[i];
                string display = currentStudent.displayInfo();
                this.tbListofstudent.Text += display;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save_data = this.tbListofstudent.Text;
            File.WriteAllText("C:/Test/text.csv", save_data);
        }

        private void tbListofstudent_TextChanged(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("C:/Test/text.csv");
        }
    }
}