using System.Text.RegularExpressions;

namespace OrganizationalProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public frmRegistration()
        {
            InitializeComponent();
            btnRegister.Click += new EventHandler(btnRegister_Click);
        }

        // Return for student Number with Format Exception
        public long StudentNumber(string studNum)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(studNum))
                {
                    throw new ArgumentNullException(nameof(studNum), "Student number cannot be empty.");
                }

                _StudentNo = long.Parse(studNum);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Argument Null Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: Invalid student number format. " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: Student number is too large. " + ex.Message);
            }
            return _StudentNo;
        }

        // Return for Contact Number with ArgumentNullException, FormatException, and OverflowException handling
        public long ContactNo(string Contact)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(Contact))
                {
                    throw new ArgumentNullException(nameof(Contact), "Contact number cannot be empty.");
                }

                if (!Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    throw new FormatException("Contact number must be 10 to 11 digits.");
                }

                _ContactNo = long.Parse(Contact);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Argument Null Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: Number exceeds maximum value. " + ex.Message);
            }

            return _ContactNo;
        }

        // Return for Full Name with ArgumentNullException and FormatException handling
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(FirstName))
                {
                    throw new ArgumentNullException("Name Fields", "First name and Last name are required.");
                }

                if (!Regex.IsMatch(LastName, @"^[a-zA-Z\s]+$") ||
                    !Regex.IsMatch(FirstName, @"^[a-zA-Z\s]+$") ||
                    (!string.IsNullOrEmpty(MiddleInitial) && !Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$")))
                {
                    throw new FormatException("Names must only contain alphabetic characters.");
                }

                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Argument Null Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }

            return _FullName;
        }

        // Return for age with ArgumentNullException, FormatException, and OverflowException handling
        public int Age(string age)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(age))
                {
                    throw new ArgumentNullException(nameof(age), "Age field cannot be empty.");
                }

                if (!Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    throw new FormatException("Age must be a valid number up to 3 digits.");
                }

                _Age = Int32.Parse(age);

                if (_Age < 0 || _Age > 120)
                {
                    throw new OverflowException("Age is out of realistic range (0 - 120).");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Argument Null Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: " + ex.Message);
            }

            return _Age;
        }

        // load form with index out of range exception handling
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] Listofprograms = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
                };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i >= Listofprograms.Length)
                    {
                        throw new IndexOutOfRangeException($"Index {i} is out of range for Listofprograms.");
                    }
                    cbPrograms.Items.Add(Listofprograms[i].ToString());
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Index Out of Range Error: " + ex.Message);
            }

            string[] listofGender = new string[] {
                "Male",
                "Female" };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(listofGender[i].ToString());
            }


        }

        


          





        private void btnRegister_Click(object sender, EventArgs e)
        {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }
    }
}
