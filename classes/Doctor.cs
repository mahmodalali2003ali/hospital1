using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class Doctor : Employe
    {
        // يتم استدعاء البناء للفئة الأساسية Employe باستخدام البناء السريع
        public Doctor(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment, string specialty) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment)
        {
            Specialty = specialty;
        }

        // قائمة لتخزين المرضى الذين يعالجهم الطبيب
        public List<patient> patients = new List<patient>();

        // تخصص الطبيب
        private string Specialty;

        // خاصية للوصول وتعديل تخصص الطبيب مع تحقق من الطول
        public string specialty
        {
            get
            {
                return Specialty;
            }
            set
            {
                if (value.Length > 5)
                {
                    Specialty = value;
                }
            }
        }

        // دالة لتحويل كائن Doctor إلى سلسلة نصية
        public override string ToString()
        {
            try
            {
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{sal},{namejob},{namedepartment},{specialty}";
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        // عملية ضمنية لتحويل كائن Doctor إلى سلسلة نصية
        public static implicit operator string(Doctor p)
        {
            return p.ToString();
        }

        // عملية ضمنية لتحويل سلسلة نصية إلى كائن Doctor
        public static implicit operator Doctor(string str)
        {
            try
            {
                string[] arr = str.Split(',');
                int ID = Convert.ToInt32(arr[0]);
                string first_Name = arr[1];
                string last_Name = arr[2];
                string adders = arr[3];
                int age = Convert.ToInt32(arr[4]);
                string phon = arr[5];
                string email = arr[6];
                string gender = arr[7];
                string blood_group = arr[8];
                int sal = Convert.ToInt32(arr[9]);
                string nameJob = arr[10];
                string nameDepartment = arr[11];
                string specialty = arr[12];

                return new Doctor(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment, specialty);
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }
    }
}
