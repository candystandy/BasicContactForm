using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* 
 *      This project covers the week 2 (building and displaying info from a form) and week 3 (validations) assignments.
 */

namespace InfoForm
{
    public partial class Form1 : Form
    {
        string strAnniversary;
        string strBirthday;
        string strCardWorthy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stateList.SelectedIndex = 0;
            relationBox.SelectedIndex = 0;
            salutationList.SelectedIndex = 0;

            confirmLabel.Text = "";
            strAnniversary = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void workPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            string fName = firstName.Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            string lName = lastName.Text;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {

            confirmLabel.Text = "";

            if (salutationList.SelectedIndex == 0 && firstName.Text == "" || lastName.Text == "")
            {
                confirmLabel.Text = "Please enter your first and last name.";
            }

            if (addrOne.Text == "" && city.Text == "" && stateList.SelectedIndex == 0 && zipCode.Text == "")
            {
                confirmLabel.Text = "Please fill in all your address information (Address, City, State and Zip).";

                if (ValidationLibrary.isCorrectLength(zipCode.Text, 5))
                {
                    confirmLabel.Text = "Your Zip Code must be exactly 5 characters long.";
                }
            }

            if (homePhone.Text == "" && workPhone.Text == "" && cellPhone.Text == "")
            {
                if (!ValidationLibrary.isCorrectLength(homePhone.Text, 10) && !ValidationLibrary.isCorrectLength(cellPhone.Text, 10) && !ValidationLibrary.isCorrectLength(workPhone.Text, 10))
                {
                    confirmLabel.Text = "Please fill in at least one of your phone numbers. (Incl. area code w/o parenthesis)";
                }

                if (!ValidationLibrary.IsValidEmail(eMail.Text))
                {
                    confirmLabel.Text = "Please fill in a valid email address.";
                }
            }

            if (relationBox.SelectedIndex == 0)
            {
                confirmLabel.Text = "Please select your relation with this contact.";
            }

            if (married.Checked == true)
            {
                strAnniversary = anniversary.Value.ToString();
            }

            strBirthday = dateOfBirth.Value.ToString();

            if (cardWorthy.Checked == true)
            {
                strCardWorthy = "Card Worthy!";
            }
            else
            {
                strCardWorthy = "Not Card Worthy!";
            }

            contactsBox.Items.Add(salutationList.SelectedItem.ToString() + ","
                                    + firstName.Text + ","
                                    + lastName.Text + ","
                                    + addrOne.Text + ","
                                    + city.Text + ","
                                    + stateList.SelectedItem.ToString() + ","
                                    + zipCode.Text + ","
                                    + eMail.Text + ","
                                    + homePhone.Text + ","
                                    + workPhone.Text + ","
                                    + cellPhone.Text + ","
                                    + strBirthday + ","
                                    + strAnniversary + ","
                                    + relationBox.SelectedItem.ToString() + ","
                                    + strCardWorthy);
            
        }

        private void married_CheckedChanged(object sender, EventArgs e)
        {
            if (married.Checked == true)
            {
                anniversary.Enabled = true;
            }
            else
            {
                anniversary.Enabled = false;
            }

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                /* else if (c is ListBox)
                    ((ListBox)c).Items.Clear(); */

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
