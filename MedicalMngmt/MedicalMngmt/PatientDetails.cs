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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Patient pt = new Patient();
        private void PatientDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = pt.GetPatient();
            dtvDetails.DataSource = dt;        
        }

        private void dtvDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Registration_No = Convert.ToInt32(dtvDetails.CurrentRow.Cells[0].Value.ToString());
            Update ud = new Update();
            ud.Registration_No = Convert.ToInt32(dtvDetails.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            ud.Show();
        }
    }
}
