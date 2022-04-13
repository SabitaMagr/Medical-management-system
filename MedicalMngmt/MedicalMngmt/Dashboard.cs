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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
            this.Hide();
           
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord ar=new AddRecord();
            {
                ar.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           this.Hide();

        }

        private void updateReToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update ud = new Update();
            ud.Show();

        }

        private void deleteReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecord dr=new DeleteRecord();
            dr.Show();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails pd = new PatientDetails();
            pd.Show();
        }

        private void tandCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermandCondition cd = new TermandCondition();
            cd.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillCals bc = new BillCals();
            bc.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRecord sr = new SearchRecord();
            sr.Show();
        }
    }
}
