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
    public partial class FormMamger : Form
    {
        OpertionManger OpertionManger = new OpertionManger();
        public FormMamger()
        {
            InitializeComponent();
        }

        private void adddoctor_Click(object sender, EventArgs e)
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

            Manger manger = new Manger(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb);
            OpertionManger.AddManger(manger);
            dataGridView2.DataSource = OpertionManger.GetManger();
          
            first_Name.Clear();
            last_Name.Clear();
            Age.Clear();
            adders.Clear();
            phon.Clear();
            email.Clear();
            gender.Clear();
            blood_group.Clear();
            nameDepartment.Clear();
            sal.Clear();
            namejob.Clear();
            
        }

        private void FormMamger_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = OpertionManger.GetManger();



        }

        private void cloes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delate_Click(object sender, EventArgs e)
        {
            

        }
    }
}
