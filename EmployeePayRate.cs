using System;
using System.IO;
using System.Windows.Forms;

/*  ID
 *      Employee Pay Data, Kaleb Ehlert, 4/8/2018
 *  Purpose
 *      The purpose of the program is to implement GUI that stores and displays the name and total pay of the employee.
 *  Form Controls
 *      lblEmployeeName: A label for the text field that takes the name of the employee.
 *      lblEmployeeNumber: A label for the text field that takes the number of the employee.
 *      lblEmployeePayRate: A label for the text field that takes the pay rate of the employee.
 *      lblEmployeeHoursWorked: A label for the text field that take the hours worked by the employee.
 *      txtEmployeeName: A text field that either displays or takes the employee's name.
 *      txtEmployeeNumber: A text field that either displays or takes the employee's number.
 *      txtEmployeePayRate: A text field that either displays or takes the employee's pay rate.
 *      txtEmployeeHoursWorked: A text field that either displays or takes the employee's hours worked.
 *  Code & Logic
 *      The input is either the keyboard text the user enters or a file's data.
 *      The processing either writes to a file or organizes a files input.
 *      The output is the stored data to a file or displaying the information to the user throught the GUI.
 */

namespace EhlertProgram10
{
    public partial class EmployeePayRate : Form
    {
        public EmployeePayRate()
        {
            InitializeComponent();
        }

        // Stores the name, number, and total of pay of the employee before deductions
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            StreamWriter file;

            double pay = 0.0;

            // If pay is greater than fourty than calculate time and a half, otherwise just calculate the amount earned
            if (double.Parse(txtEmployeeHoursWorked.Text) >= 40) {
                pay = double.Parse(txtEmployeePayRate.Text) * int.Parse(txtEmployeeHoursWorked.Text) * 1.5;
            } else {
                pay = double.Parse(txtEmployeePayRate.Text) * int.Parse(txtEmployeeHoursWorked.Text);
            }

            // Get the file name and provide two filters
            saveFileDialog.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();

            // Set the file to write to
            file = new StreamWriter(saveFileDialog.FileName);

            // Write the name and number of the employee to the file
            file.WriteLine(txtEmployeeName.Text);
            file.WriteLine(txtEmployeeNumber.Text);

            // Write the amount the employee earned to the file
            file.WriteLine(pay);

            // Close the file
            file.Close();
        }

        // Displays the stored information of the employee
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            StreamReader inFile;
            string name = "";
            string number = "";
            string pay = "";

            try {
                // Find the file and set a filter
                openFileDialog.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.ShowDialog();

                // Open the file
                inFile = new StreamReader(openFileDialog.FileName);

                // Read the file for the name, number, and pay
                name = inFile.ReadLine();
                number = inFile.ReadLine();
                pay = inFile.ReadLine();
            } catch {
                MessageBox.Show("Error the file is unable to be open! The file might be corrupt.");
            }

            // Display the information on the GUI
            if ( double.Parse(pay) - Math.Truncate(double.Parse(pay)) > 0 )
                txtDisplay.Text = "Name: " + name + "\r\n" + "Total Pay: $" + pay + "\r\n";
            else
                txtDisplay.Text = "Name: " + name + "\r\n" + "Total Pay: $" + pay + ".00" + "\r\n";

            // Close the file
            openFileDialog.Dispose();
        }
    }
}
