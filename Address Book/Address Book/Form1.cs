using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class addressBookForm : Form
    {
        public addressBookForm()
        {
            InitializeComponent();
        }

        // Contact struct that holds contact info
        public struct contact
        {
            public string fName;
            public string lName;
            public string phoneNum;
            public string email;
            public int day;
            public int month;
            public int year;
            public string instagram;
        }

        // Array for contacts
        contact[] contactArray = new contact[100];

        int currentIndex = 0;

        // Goes through contact array and checks if person exists. Return index if true, return -1 if false;
        int findPerson(string fName, string lName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contactArray[i].fName.ToLower() == fName.ToLower() && contactArray[i].lName.ToLower() == lName.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        void clearAddPg()
        {
            // Clear add page
            txtAddFName.Clear();
            txtAddLName.Clear();
            txtAddPhoneNum.Clear();
            txtAddEmail.Clear();
            dtpAddBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            txtAddInsta.Clear();
        }
        void clearSearchPg()
        {
            // Clear search page
            txtSearchFName.Clear();
            txtSearchLName.Clear();
            txtSearchPhoneNum.Clear();
            txtSearchEmail.Clear();
            txtSearchInsta.Clear();
            dtpShowBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        void clearTodayBDPg()
        {
            // Clear listbox
            lbTodayBD.Items.Clear();
        }
        void clearEditDelPg()
        {
            // Clear edit delete page
            txtEditDelFName.Clear();
            txtEditDelLName.Clear();
            txtEditPhoneNum.Clear();
            txtEditEmail.Clear();
            dtpEditBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            txtEditInsta.Clear();
        }

        // Method to add contact info to contactArray
        void addContact(string fName, string lName, string phoneNum, string email, int day, int month, int year, string instagram)
        {
            contactArray[currentIndex].fName = fName;
            contactArray[currentIndex].lName = lName;
            contactArray[currentIndex].phoneNum = phoneNum;
            contactArray[currentIndex].email = email;
            contactArray[currentIndex].day = day;
            contactArray[currentIndex].month = month;
            contactArray[currentIndex].year = year;
            contactArray[currentIndex].instagram = instagram;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                string fName, lName, phoneNum, email, instagram;
                int day, month, year;

                // contactArray is full
                if(currentIndex >= 100)
                {
                    MessageBox.Show("Database is full!");
                }
                else
                {
                    // Retrieves input of contact info
                    fName = txtAddFName.Text.Trim();
                    lName = txtAddLName.Text.Trim();
                    phoneNum = txtAddPhoneNum.Text.Trim();
                    email = txtAddEmail.Text.Trim();
                    instagram = txtAddInsta.Text.Trim();
                    day = dtpAddBD.Value.Day;
                    month = dtpAddBD.Value.Month;
                    year = dtpAddBD.Value.Year;

                    // Checks if all required spaces are filled
                    if (fName == "" || lName == "" || phoneNum == "" || email == "")
                    {
                        MessageBox.Show("Please provide the first name, last name, phone number, email address, and birthday of your contact.");
                        return;
                    }
                    // Checks if birthday is in the future
                    else if(dtpAddBD.Value > DateTime.Now)
                    {
                        MessageBox.Show("You cannot enter a birthday that is in the future.");
                        dtpAddBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        return;
                    }
                    
                    // Finds index of person
                    int index = findPerson(fName, lName);

                    // Adds contact to database if they do not exist
                    if(index == -1)
                    {
                        addContact(fName, lName, phoneNum, email, day, month, year, instagram);
                        currentIndex++;
                        MessageBox.Show("Your contact is successfully in the database");
                        clearAddPg();
                        clearTodayBDPg();
                    }
                    //Gives message if they do
                    else
                    {
                        MessageBox.Show("This person is already in the database.");
                        clearAddPg();
                    }
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearAddPg();
            }
        }

        private void btnShowContact_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                string fName, lName;
                int index;

                // Retrieve inputs
                fName = txtSearchFName.Text.Trim();
                lName = txtSearchLName.Text.Trim();

                // Checks if inputs are empty
                if (fName == "" || lName == "")
                {
                    MessageBox.Show("Please provide your first and last name in order to search.");
                    return;
                }
                // Finds index of person
                index = findPerson(fName, lName);

                // Clears page if they don't exist
                if (index == -1)
                {
                    clearSearchPg();
                    MessageBox.Show("This person in not in our database.");
                }
                // Shows contact info
                else
                {
                    txtSearchPhoneNum.Text = contactArray[index].phoneNum;
                    txtSearchEmail.Text = contactArray[index].email;
                    txtSearchInsta.Text = contactArray[index].instagram;

                    txtSearchFName.ReadOnly = true;
                    txtSearchLName.ReadOnly = true;
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearSearchPg();
            }
        }

        private void btnShowBirthday_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                string fName, lName;
                int index, year, month, day;

                // Retrieve inputs
                fName = txtSearchFName.Text.Trim();
                lName = txtSearchLName.Text.Trim();

                // Checks if inputs are empty
                if (fName == "" || lName == "")
                {
                    MessageBox.Show("Please provide your first and last name in order to search.");
                    return;
                }

                // Finds index of person
                index = findPerson(fName, lName);

                // Clears page if they do not exist
                if (index == -1)
                {
                    clearSearchPg();
                    MessageBox.Show("This person in not in our database.");
                }
                // Shows birthday on dtp of they exist
                else
                {
                    year = contactArray[index].year;
                    month = contactArray[index].month;
                    day = contactArray[index].day;

                    dtpShowBD.Visible = true;
                    dtpShowBD.Value = new DateTime(year, month, day);

                    txtSearchFName.ReadOnly = true;
                    txtSearchLName.ReadOnly = true;
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearSearchPg();
            }
        }
        private void btnShowTodayBD_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear current items
                lbTodayBD.Items.Clear();

                // Initialize variables
                string fullName, output;
                int age;

                // Checks if any birthdays are on the current date
                for (int i = 0; i < currentIndex; i++)
                {
                    if (contactArray[i].day == DateTime.Now.Day && contactArray[i].month == DateTime.Now.Month)
                    {
                        // Outputs name and age on listbox if true
                        fullName = contactArray[i].fName + " " + contactArray[i].lName;
                        age = DateTime.Now.Year - contactArray[i].year;
                        output = fullName + " - " + age + " years old";
                        lbTodayBD.Items.Add(output);
                    }
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearTodayBDPg();
            }
        }

        // Global var for edit contact index 
        int editContactIndex;
        // fName and lName for edit and delete
        string editDelFName, editDelLName;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Contact name input
                editDelFName = txtEditDelFName.Text.Trim();
                editDelLName = txtEditDelLName.Text.Trim();

                // Checks if input is empty
                if(editDelFName == "" || editDelLName == "")
                {
                    MessageBox.Show("Please enter the contact's first and last name in order to edit.");
                    return;
                }

                // Finds index of contact
                editContactIndex = findPerson(editDelFName, editDelLName);

                // Error if they don't exist
                if (editContactIndex == -1)
                {
                    MessageBox.Show("This person is not in our database.");
                    clearEditDelPg();
                }
                else
                {
                    // Add info into txt and dtp so user can edit
                    int day, month, year;
                    day = contactArray[editContactIndex].day;
                    month = contactArray[editContactIndex].month;
                    year = contactArray[editContactIndex].year;
                    txtEditPhoneNum.Text = contactArray[editContactIndex].phoneNum;
                    txtEditEmail.Text = contactArray[editContactIndex].email;
                    dtpEditBD.Value = new DateTime(year, month, day);
                    txtEditInsta.Text = contactArray[editContactIndex].instagram;

                    // Edit and delete buttons disabled during edit info process
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;

                    // Inputs for edit & delete buttons disabled
                    txtEditDelFName.ReadOnly = true;
                    txtEditDelLName.ReadOnly = true;

                    // Save and cancel buttons enabled
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    // Edit info textboxes enabled
                    txtEditPhoneNum.ReadOnly = false;
                    txtEditEmail.ReadOnly = false;
                    dtpEditBD.Enabled = true;
                    txtEditInsta.ReadOnly = false;

                    // Change tabstop so user only tabs in user info
                    txtEditDelFName.TabStop = false;
                    txtEditDelLName.TabStop = false;
                    txtEditPhoneNum.TabStop = true;
                    txtEditEmail.TabStop = true;
                    dtpEditBD.TabStop = true;
                    txtEditInsta.TabStop = true;

                    // Tells user where to edit
                    MessageBox.Show("Please edit the info shown below.");
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearEditDelPg();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                string fName, lName;
                int index;

                // Retrieve inputs
                fName = txtEditDelFName.Text.Trim();
                lName = txtEditDelLName.Text.Trim();

                // Checks if inputs empty
                if (fName == "" || lName == "")
                {
                    MessageBox.Show("Please provide your first and last name in order to delete.");
                    return;
                }

                // Finds index of contact
                index = findPerson(fName, lName);

                // Error if they don't exist
                if (index == -1)
                {
                    MessageBox.Show("This person does not exist.");
                    clearEditDelPg();
                    return;
                }
                // When index last index of contact array, there is no next index to pull information from, so we must manually clear the index
                else if (index == 99)
                {
                    contactArray[index].fName = ""; 
                    contactArray[index].lName = "";
                    contactArray[index].phoneNum = "";
                    contactArray[index].email = "";
                    contactArray[index].day = DateTime.Now.Day;
                    contactArray[index].month = DateTime.Now.Month;
                    contactArray[index].year = DateTime.Now.Year;
                    contactArray[index].instagram = "";
                }
                else
                {
                    // Goes through contact array from contact index 
                    for (int i = index; i < currentIndex; i++)
                    {
                        // index i obtains data of next index so the data can shift down
                        contactArray[i] = contactArray[i + 1];
                    }

                    // Decrement from currentIndex and give message
                    currentIndex -= 1;
                    MessageBox.Show("Your contact has been successfully deleted.");
                }
                // Clear neccessary pages
                clearEditDelPg();

                clearSearchPg();
                txtSearchFName.ReadOnly = false;
                txtSearchLName.ReadOnly = false;

                clearTodayBDPg();
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearEditDelPg();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                string phoneNum, email, insta;

                // Retrieve inputs
                phoneNum = txtEditPhoneNum.Text.Trim();
                email = txtEditEmail.Text.Trim();
                insta = txtEditInsta.Text.Trim();

                // Checks if mandatory inputs are empty
                if (phoneNum == "" || email == "")
                {
                    MessageBox.Show("Please provide the contact's phone number and email in order to save.");
                    return;
                }
                // Checks if birthday is in future
                if(dtpEditBD.Value > DateTime.Now)
                {
                    MessageBox.Show("You cannot provide a birthday that is in the future.");
                    return;
                }

                // Adds new contact info to contactArray
                contactArray[editContactIndex].phoneNum = phoneNum;
                contactArray[editContactIndex].email = email;
                contactArray[editContactIndex].day = dtpEditBD.Value.Day;
                contactArray[editContactIndex].month = dtpEditBD.Value.Month;
                contactArray[editContactIndex].year = dtpEditBD.Value.Year;
                contactArray[editContactIndex].instagram = insta;

                // Disables edit inputs
                txtEditPhoneNum.ReadOnly = true;
                txtEditEmail.ReadOnly = true;
                dtpEditBD.Enabled = false;
                txtEditInsta.ReadOnly = true;

                // Enables input for contact name
                txtEditDelFName.ReadOnly = false;
                txtEditDelLName.ReadOnly = false;

                // Disables cancel and save buttons and enables edit and delete buttons
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                // Change tabstop so user cannot tab edit items
                txtEditDelFName.TabStop = true;
                txtEditDelLName.TabStop = true;
                txtEditPhoneNum.TabStop = false;
                txtEditEmail.TabStop = false;
                dtpEditBD.TabStop = false;
                txtEditInsta.TabStop = false;

                MessageBox.Show("Your edit has been saved.");

                // Clear neccessary pages
                clearEditDelPg();

                clearSearchPg();
                txtSearchFName.ReadOnly = false;
                txtSearchLName.ReadOnly = false;

                clearTodayBDPg();
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearEditDelPg();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Makes edit inputs read only
                txtEditPhoneNum.ReadOnly = true;
                txtEditEmail.ReadOnly = true;
                dtpEditBD.Enabled = false;
                txtEditInsta.ReadOnly = true;

                // Enables input for contact name
                txtEditDelFName.ReadOnly = false;
                txtEditDelLName.ReadOnly = false;

                // Disables cancel and save buttons and enables edit and delete buttons
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                // Change tabstop so user cannot tab edit items
                txtEditDelFName.TabStop = true;
                txtEditDelLName.TabStop = true;
                txtEditPhoneNum.TabStop = false;
                txtEditEmail.TabStop = false;
                dtpEditBD.TabStop = false;
                txtEditInsta.TabStop = false;

                // Message to reassure users
                MessageBox.Show("Your edit has been cancelled.");

                // Clear page
                clearEditDelPg();
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearEditDelPg();
            }
        }

        private void saveTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create save file dialog and file name variable
                SaveFileDialog sfd = new SaveFileDialog();
                string FileName;

                // Filters so only txt files show
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                // Checks if user pressed save button
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Set up textwriter using filename that user picked
                    FileName = sfd.FileName;
                    TextWriter tw = new StreamWriter(FileName);

                    // Write each contact in array to each line of txt file
                    // Items are separated by comma
                    for (int i = 0; i < currentIndex; i++)
                    {
                        tw.Write(contactArray[i].fName + ",");
                        tw.Write(contactArray[i].lName + ",");
                        tw.Write(contactArray[i].phoneNum + ",");
                        tw.Write(contactArray[i].email + ",");
                        tw.Write(contactArray[i].day.ToString() + ",");
                        tw.Write(contactArray[i].month.ToString() + ",");
                        tw.Write(contactArray[i].year.ToString() + ",");
                        tw.WriteLine(contactArray[i].instagram);
                    }
                    // Closes file
                    tw.Close();
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("SAVE TEXT FILE ERROR! PLEASE CONTACT A DEVELOPER!");
            }
        }

        private void menuItemOpenText_Click(object sender, EventArgs e)
        {
            try
            {
                // Create open file dialog and initialize variables
                OpenFileDialog ofd = new OpenFileDialog();
                string FileName;
                string strInput;
                string[] splittedInput;

                // Filters to show txt files only
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                // Checks if user pressed save button
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Creates new textreader of user's chosen file
                    FileName = ofd.FileName;
                    TextReader tr = new StreamReader(FileName);

                    //Resets currentIndex
                    currentIndex = 0;

                    // Runs loop while the input is not null (empty)
                    while ((strInput = tr.ReadLine()) != null)
                    {
                        // Splits the input by comma and adds each splitted item into the current contactArray spot
                        splittedInput = strInput.Split(',');
                        contactArray[currentIndex].fName = splittedInput[0];
                        contactArray[currentIndex].lName = splittedInput[1];
                        contactArray[currentIndex].phoneNum = splittedInput[2];
                        contactArray[currentIndex].email = splittedInput[3];
                        contactArray[currentIndex].day = Convert.ToInt32(splittedInput[4]);
                        contactArray[currentIndex].month = Convert.ToInt32(splittedInput[5]);
                        contactArray[currentIndex].year = Convert.ToInt32(splittedInput[6]);
                        contactArray[currentIndex].instagram = splittedInput[7];

                        // Increment currentIndex
                        currentIndex++;
                    }
                    // Close file
                    tr.Close();
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("OPEN TEXT FILE ERROR! PLEASE CONTACT A DEVELOPER!");
            }
        }

        private void menuItemSaveBinary_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new save file dialog and initialize variable
                SaveFileDialog sfd = new SaveFileDialog();
                string FileName;

                // Filters binary files that end with .lee extension
                sfd.Filter = "binary files (*.lee)|*.lee|All Files (*.*)|*.*";

                // Checks if user pressed save
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Makes new binary reader of user's chosen file
                    FileName = sfd.FileName;
                    FileStream fs = new FileStream(FileName, FileMode.Create);
                    BinaryWriter binWriter = new BinaryWriter(fs);

                    // Goes through contactArray and writes each item into selected binary file
                    for (int i = 0; i < currentIndex; i++)
                    {
                        binWriter.Write(contactArray[i].fName);
                        binWriter.Write(contactArray[i].lName);
                        binWriter.Write(contactArray[i].phoneNum);
                        binWriter.Write(contactArray[i].email);
                        binWriter.Write(contactArray[i].day);
                        binWriter.Write(contactArray[i].month);
                        binWriter.Write(contactArray[i].year);
                        binWriter.Write(contactArray[i].instagram);
                    }
                    // Flush and close binary file
                    binWriter.Flush();
                    binWriter.Close();
                }
            }
            catch
            {
                // Error message
                MessageBox.Show("SAVE BINARY FILE ERROR! PLEASE CONTACT A DEVELOPER!");
            }
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            try
            {
                clearSearchPg();
                txtSearchFName.ReadOnly = false;
                txtSearchLName.ReadOnly = false;
            }
            catch
            {
                // Error message
                MessageBox.Show("ERROR! PLEASE CONTACT A DEVELOPER!");
                clearSearchPg();
            }

        }

        private void menuItemOpenBinary_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new open file dialog and initialize variables
                OpenFileDialog ofd = new OpenFileDialog();
                string FileName;
                long length;

                // Filters binary files that end with .lee extension
                ofd.Filter = "binary files (*.lee)|*.lee|All Files (*.*)|*.*";

                // Checks if user pressed save
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    // Makes new binary reader of user's chosen file
                    FileName = ofd.FileName;
                    FileStream fs = new FileStream(FileName, FileMode.Open);
                    BinaryReader binReader = new BinaryReader(fs);

                    // Resets currentIndex and finds length of file
                    currentIndex = 0;
                    length = binReader.BaseStream.Length;

                    // Add items of each contact from binary file into array and increments currentIndex
                    while(fs.Position < length)
                    {
                        contactArray[currentIndex].fName = binReader.ReadString();
                        contactArray[currentIndex].lName = binReader.ReadString();
                        contactArray[currentIndex].phoneNum = binReader.ReadString();
                        contactArray[currentIndex].email = binReader.ReadString();
                        contactArray[currentIndex].day = binReader.ReadInt32();
                        contactArray[currentIndex].month = binReader.ReadInt32();
                        contactArray[currentIndex].year = binReader.ReadInt32();
                        contactArray[currentIndex].instagram = binReader.ReadString();
                        currentIndex++;
                    }
                    // Closes binary reader
                    binReader.Close();
                }



            }
            catch
            {
                // Error message
                MessageBox.Show("OPEN BINARY FILE ERROR! PLEASE CONTACT A DEVELOPER!");
            }
        }
    }
}
