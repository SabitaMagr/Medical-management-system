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
    public partial class BillCals : Form
    {
        public BillCals()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Patient pt = new Patient();
        public int Registration_No = 0;
        private void BillCals_Load(object sender, EventArgs e)
        {
            DataTable dt = pt.GetPatient();
            dgvBill.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Registration_No = Convert.ToInt32(txtRegNo.Text);
            DataTable dt = pt.GetPatientById(Registration_No);
            if (dt.Rows.Count > 0)
            {
                dgvBill.DataSource = dt;
            }
            txtRegNo.Clear();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            int total = pt.Addition(Convert.ToInt32(txtAdmit.Text), Convert.ToInt32(txtcharge.Text), Convert.ToInt32(txtdoctorFees.Text), Convert.ToInt32(txtmedicinefees.Text));
            txtTotal.Text=total.ToString();
        }

        private void txtAdmit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtcharge.Select();
            }
        }

        private void txtcharge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtdoctorFees.Select();
            }
        }

        private void txtmedicinefees_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtmedicinefees.Select();
            }
        }
    }
}
