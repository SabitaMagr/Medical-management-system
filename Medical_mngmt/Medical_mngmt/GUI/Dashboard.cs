using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_mngmt.GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
 

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bll=new Bill();
            bll.Show();
        }
       

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient ad = new AddPatient();
            ad.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDetaills vd = new ViewDetaills();
            vd.Show();
        }

        private void updatePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete dt = new Delete();
            dt.Show();
        }

        private void searchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            sr.Show();
        }

        private void searchByAddressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchByAddress sd = new SearchByAddress();
            sd.Show();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctor ad=new AddDoctor();
            ad.Show();
        }

        private void doctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorDetails dd=new DoctorDetails();
            dd.Show();
        }

        private void updateDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UpdateDoctor ud=new UpdateDoctor();
            ud.Show();
        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDoctor dad = new DeleteDoctor();
            dad.Show();
        }

        private void searchDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDoctor sd=new SearchDoctor();
            sd.Show();
        }

        private void MedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine md = new Medicine();
            md.Show();
        }

        private void BilltoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Bill bll = new Bill();
            bll.Show();
        }

        private void LogouttoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void tcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermsandCondition tc = new TermsandCondition();
            tc.Show();
        }

        private void departmentlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Department dt = new Department();
            dt.Show ();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment ap=new Appointment();
            ap.Show();
        }
    }
}
