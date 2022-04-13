using MedicalMngmt.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalMngmt
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtDisease.Clear();
            txtManufacturer.Clear();
            txtMedicine.Clear();
            txtMedicineName.Clear();
            txtMobile.Clear();
            txtRelative.Clear();
            rdMale.Checked = false;
            rdFemale.Checked = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtAge.Select();
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtAddress.Select();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                txtMobile.Select();
            }
        }

        private void txtMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtMedicineName.Select();
            }
        }

        private void txtMedicineName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtManufacturer.Select();
            }
        }

        private void txtManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtDisease.Select();
            }
        }

        private void txtDisease_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtRelative.Select();
            }
        }
        Patient pt = new Patient();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = Validation();
            if (string.IsNullOrEmpty(msg))
            {
                //pt.Name = txtName.Text ?? "";
                bool malefemale = rdFemale.Checked ? false : true;
                int i = pt.CreateUser(txtName.Text, txtAge.Text, txtAddress.Text, txtMobile.Text , Convert.ToInt32(txtMedicine.Text), txtMedicineName.Text, txtManufacturer.Text, txtDisease.Text, txtRelative.Text, malefemale);
                if (i > 0) 

                {
                    MessageBox.Show("User Created!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
        public string Validation()
        {
            string res = string.Empty;
            double convertedNumber;
            bool IsNumeric = double.TryParse(txtMobile.Text, out convertedNumber);
            double oneNumber;
            bool IsNumber = double.TryParse(txtAge.Text, out oneNumber);
            if (string.IsNullOrEmpty(txtName.Text))
            {
                res = "Please enter Name";
            }
            else if (!IsNumber)
            {
                res="Invalid Age";
            }
            else if(txtAge.Text.Length!=2)
            {
                res = "Please enter Valid Age";
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                res="Please enter Address";
            }
            else if(!IsNumeric)
            {
              res="Invalid Mobile Number";
            }
            else if (string.IsNullOrEmpty(txtMedicine.Text))
            {
                res=" Please enter Medicine No.";
            }
            else if(string.IsNullOrEmpty(txtMedicineName.Text))
            {
               res="Please enter Medicine Name";
            }
            else if(string.IsNullOrEmpty(txtManufacturer.Text))
            {
                res="Please enter Manufacturer Name";
            }
            else if(string.IsNullOrEmpty(txtDisease.Text))
            {
                res="Please enter Disease Name";
            }
            else if(string.IsNullOrEmpty(txtRelative.Text))
            {
                res="Please enter Relative Name";
            }
            return res;
        }
    }
}
