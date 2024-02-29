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
    public partial class FormNurse : Form
    {
        OpertioNnurse opertioNnurse = new OpertioNnurse();

        public FormNurse()
        {
            InitializeComponent();
        }

        private void FormNurse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = opertioNnurse.Getnurse();
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
            string nameDepartmen = nameDepartment.Text;
            int sall = Convert.ToInt32(sal.Text);
            string namejobb = namejob.Text;
            string specialt = specialty.Text;
            nurse nurse = new nurse(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            opertioNnurse.Addnurse(nurse);
            dataGridView1.DataSource = opertioNnurse.Getnurse();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delate_Click(object sender, EventArgs e)
        {
            string fname = first_Name.Text;
            string lname = last_Name.Text;
            int age = Convert.ToInt32(Age.Text);
            string adder = adders.Text;
            string ph = phon.Text;
            string emai = email.Text;
            string gende = gender.Text;
            string blood_grou = blood_group.Text;
            string nameDepartmen = nameDepartment.Text;
            int sall = Convert.ToInt32(sal.Text);
            string namejobb = namejob.Text;
            string specialt = specialty.Text;
            nurse nurse = new nurse(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            opertioNnurse.Deletenurser(nurse);
            dataGridView1.DataSource = opertioNnurse.Getnurse();
        }

        private void upda_Click(object sender, EventArgs e)
        {
            
        }
        int courntid = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                courntid = Convert.ToInt32(row.Cells[4].Value);
                specialty.Text = row.Cells[0].Value.ToString();
                sal.Text = row.Cells[1].Value.ToString();
                namejob.Text = row.Cells[2].Value.ToString();
                nameDepartment.Text = row.Cells[3].Value.ToString();
                first_Name.Text = row.Cells[5].Value.ToString();
                last_Name.Text = row.Cells[6].Value.ToString();
                adders.Text = row.Cells[7].Value.ToString();
                Age.Text = row.Cells[8].Value.ToString();
                phon.Text = row.Cells[9].Value.ToString();
                email.Text = row.Cells[10].Value.ToString();
                gender.Text = row.Cells[11].Value.ToString();
                blood_group.Text = row.Cells[12].Value.ToString();
                nurse nurse = new nurse(courntid, first_Name.Text, last_Name.Text, adders.Text, Age.TextLength, phon.Text, email.Text, gender.Text, blood_group.Text, sal.TextLength, namejob.Text, nameDepartment.Text, specialty.Text);
                opertioNnurse.Updatenurse(nurse);
                dataGridView1.DataSource = opertioNnurse.Getnurse();

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string fname = first_Name.Text;
            string lname = last_Name.Text;
            int age = Convert.ToInt32(Age.Text);
            string adder = adders.Text;
            string ph = phon.Text;
            string emai = email.Text;
            string gende = gender.Text;
            string blood_grou = blood_group.Text;
            string nameDepartmen = nameDepartment.Text;
            int sall = Convert.ToInt32(sal.Text);
            string namejobb = namejob.Text;
            string specialt = specialty.Text;
            nurse nurse = new nurse(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            opertioNnurse.Deletenurser(nurse);
            dataGridView1.DataSource = opertioNnurse.Getnurse() ;

            if (e.KeyCode == Keys.Delete)
            {

                bool stusu = MessageBox.Show("" + courntid, "", MessageBoxButtons.OKCancel) == DialogResult.Yes;
                if (stusu == true && nurse.id == courntid)
                {

                    opertioNnurse.Deletenurser(nurse);
                    dataGridView1.DataSource = opertioNnurse.Getnurse();

                }
                else
                {

                }
            }
        }

    }
}
