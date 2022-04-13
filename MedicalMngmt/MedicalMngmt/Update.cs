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
    public partial class Update : Form
    {
        public Update()
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
            rdFemale.Dispose();
            rdMale.Dispose();
        }
        public int Registration_No=0;
        Patient pt = new Patient();

        private void Update_Load(object sender, EventArgs e)
        {
           
            DataTable dt = pt.GetPatientById(Registration_No);
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtAge.Text = dt.Rows[0]["Age"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile_No"].ToString();
            txtMedicine.Text = dt.Rows[0]["Medicine_No"].ToString();
            txtMedicineName.Text = dt.Rows[0]["Medicine_Name"].ToString();
            txtDisease.Text = dt.Rows[0]["Disease_Name"].ToString();
            txtManufacturer.Text = dt.Rows[0]["Manufacturer_Name"].ToString();
            txtRelative.Text = dt.Rows[0]["Relative_Name"].ToString();
            if (dt.Rows[0]["Gender"] != null)
            {
                if (Convert.ToBoolean(dt.Rows[0]["Gender"]))
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool malefemale = rdFemale.Checked ? false : true;
            int i = pt.UpdatePatient(txtName.Text, txtAge.Text, txtAddress.Text, txtMobile.Text, Convert.ToInt32 (txtMedicine.Text), txtMedicineName.Text, txtManufacturer.Text, txtDisease.Text, txtRelative.Text,Registration_No, malefemale);

            if (i>0)
            {
                MessageBox.Show("Patient Updated!!!");
            }

        }
    }
}
