using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_2_Soriano
{
    public partial class FrmRegistration : Form
    {
        private string studentNumber;
        private string lastName;
        private string middleInitial;
        private string firstName;
        private string age;
        private string contactNumber;
        private string program;
        private string gender;
        private string birthday;

        string[] courses = {
            "BS Information Technology",
            "BS Computer Engineering",
            "BS Architecture",
            "BS Psychology",
            "BS Criminology",
            "BS Nursing"
            };

        string[] genders = { "Male", "Female", "Non-binary" };

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initialize variables
            studentNumber = txtStudentNumber.Text;
            lastName = txtLastName.Text;
            middleInitial = txtMiddleInitial.Text;
            firstName = txtFirstName.Text;
            age = txtAge.Text;
            contactNumber = txtContactNumber.Text;
            program = cbProgram.Text;
            gender = cbGender.Text;
            birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");

            string[] values = { //using an array to write easier in the output file
                $"Student Number: {studentNumber}",
                $"Full Name: {firstName} {middleInitial} {lastName}",
                $"Program: {program}",
                $"Gender: {gender}",
                $"Age: {age}",
                $"Birthday: {birthday}",
                $"Contact Number: {contactNumber}"
            };

            string docPath = Path.GetFullPath(@"..\..\..\Registered_Student_Catalog");

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            txtStudentNumber.Text + ".txt")))
            {
                foreach (string value in values)
                {
                    outputFile.WriteLine(value);
                }
            }

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            //Add the values from array courses to the cbProgram combo box
            foreach (string course in courses)
            {
                cbProgram.Items.Add(course);
            }

            //Add the values from array genders to the cbProgram combo box
            foreach (string gender in genders)
            {
                cbGender.Items.Add(gender);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //this form will close then student record will open
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            studentRecord.Show();
        }
    }
}
