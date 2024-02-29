using hospital1.classes;
using hospital1.connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital1.models
{
    public partial class FormPatient : Form
    {
        OPertionPatient oPertionPatient = new OPertionPatient();
        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = oPertionPatient.GetPatients();

        }

        private void addMA_Click(object sender, EventArgs e)
        {
            string fname = first_Name.Text;
            string lname = last_Name.Text;
            int age = Convert.ToInt32(Age.Text);
            string adder = adders.Text;
            string ph = phon.Text;
            string emai = email.Text;
            string gende = gender.Text;
            string blood_grou = blood_group.Text;
            string nameIllnes = nameIllness.Text;
            patient patient = new patient(0, fname, lname, adder, age, ph, emai, gende, blood_grou, nameIllnes);
            oPertionPatient.AddPatients(patient);
            dataGridView1.DataSource = oPertionPatient.GetPatients();
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
