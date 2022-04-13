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
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        Patient pt = new Patient();
        public int Registration_No = 0;
        private void SearchRecord_Load(object sender, EventArgs e)
        {
            DataTable dt = pt.GetPatient();
            dgvSearch.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Registration_No = Convert.ToInt32(txtRegNo.Text);
            DataTable dt = pt.GetPatientById(Registration_No);
            if(dt.Rows.Count>0)
            {
                dgvSearch.DataSource=dt;
            }
            else
            {
                MessageBox.Show("Patient not Found.");
            }
            txtRegNo.Clear();
        }
    }
}
