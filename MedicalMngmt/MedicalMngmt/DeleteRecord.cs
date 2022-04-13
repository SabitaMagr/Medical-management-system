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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtAge.Clear();
            txtDisease.Clear();
            txtManufacturer.Clear();
            txtMedicine.Clear();
            txtMedicineName.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtRelative.Clear();
            rdFemale.Checked = false;
            rdMale.Checked = false;
            txtRegNo.Clear();
        }
        Patient pt = new Patient();
        public int Registration_No = 0;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = pt.DeletePatient( Registration_No);
            if(i>0)
            {
                MessageBox.Show("Patient Deleted Successfully.");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Registration_No=Convert.ToInt32(txtRegNo.Text.ToString());
            DataTable dt = pt.GetPatientById(Registration_No);
            if (dt.Rows.Count > 0)
            {
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
            else
            {
                MessageBox.Show("Invalid Registration Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
    }
