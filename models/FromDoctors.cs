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
    public partial class FromDoctors : Form
    {
        OpertionDoctor opertionDoctor = new OpertionDoctor();
        public FromDoctors()
        {
            InitializeComponent();
        }

        private void getDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FromDoctors_Load(object sender, EventArgs e)
        {
            try
            {


                dataGridView1.DataSource = opertionDoctor.GetDoctors();



            }
            catch (Exception ex)
            {


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void adddoctor_Click(object sender, EventArgs e)
        {
            // استخراج البيانات من حقول الإدخال
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
            // إنشاء كائن Doctor باستخدام البيانات المستخرجة
            Doctor doctor = new Doctor(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            // إضافة الطبيب إلى النظام
            opertionDoctor.AddDoctor(doctor);
            // تحديث عرض البيانات في dataGridView1
            dataGridView1.DataSource = opertionDoctor.GetDoctors();
            // مسح محتوى حقول الإدخال
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
            specialty.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delate_Click(object sender, EventArgs e)
        {
            // استخراج البيانات من حقول الإدخال
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
            // إنشاء كائن Doctor باستخدام البيانات المستخرجة
            Doctor doctor = new Doctor(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            // حذف الدكتور من النظام
            opertionDoctor.DeleteDoctor(doctor);
            // تحديث عرض البيانات في dataGridView1
            dataGridView1.DataSource = opertionDoctor.GetDoctors();

        }

        private void upda_Click(object sender, EventArgs e)
        {
            // الكود الذي يتم تنفيذه عند النقر على الزر للتعديل
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
            Doctor doctor = new Doctor(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            opertionDoctor.UpdateDoctors(doctor);
            dataGridView1.DataSource = opertionDoctor.GetDoctors();
        }
        // تعريف متغير لتخزين معرف العنصر المحدد في الجدول، بدءاً من قيمة سالبة للتأكد من أنه لم يتم تحديد أي عنصر بعد
        int courntid = -1;
        // دالة مستمعة لحدث النقر على خلية في جدول البيانات
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // التحقق مما إذا كان النقر داخل صف صالح في جدول البيانات
            if (e.RowIndex >= 0)
            {
                // استخراج الصف المحدد
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // استخراج معرف العنصر من الخلية في العمود الرابع
                courntid = Convert.ToInt32(row.Cells[4].Value);
                // عرض بيانات العنصر المحدد في عناصر واجهة المستخدم المختلفة
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
                // إنشاء كائن دكتور باستخدام بيانات العنصر المحدد
                Doctor doctor = new Doctor(courntid, first_Name.Text, last_Name.Text, adders.Text, Age.TextLength, phon.Text, email.Text, gender.Text, blood_group.Text, sal.TextLength, namejob.Text,nameDepartment.Text, specialty.Text);
                // تحديث بيانات الدكتور في الملف النصي
                opertionDoctor.UpdateDoctors(doctor);
                // تحديث عرض بيانات الدكتور في جدول البيانات
                dataGridView1.DataSource = opertionDoctor.GetDoctors();

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // استخراج بيانات الدكتور من عناصر واجهة المستخدم
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
            Doctor doctor = new Doctor(0, fname, lname, adder, age, ph, emai, gende, blood_grou, sall, nameDepartmen, namejobb, specialt);
            // حذف الدكتور من قاعدة البيانات وتحديث عرض البيانات في جدول البيانات
            opertionDoctor.DeleteDoctor(doctor);
            dataGridView1.DataSource = opertionDoctor.GetDoctors();
            // التحقق من ما إذا كان المفتاح المضغوط هو "Delete"
            if (e.KeyCode==Keys.Delete)
            {
                // عرض مربع حوار يسأل المستخدم عن تأكيد الحذف
                bool stusu = MessageBox.Show(""+courntid,"",MessageBoxButtons.OKCancel)==DialogResult.Yes;
                // إذا قام المستخدم بتأكيد الحذف
                if (stusu==true&& doctor.id==courntid)
                {
                    // حذف الدكتور من قاعدة البيانات وتحديث عرض البيانات في جدول البيانات
                    opertionDoctor.DeleteDoctor(doctor);
                    dataGridView1.DataSource = opertionDoctor.GetDoctors();

                }
                else
                {

                }
            }
        }
    }
}
