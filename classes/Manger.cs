using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class Manger : Employe
    {
        public Manger(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment)
        {
        }
        //قايمة بالاطباء 
        public List<Doctor> Doctors = new List<Doctor>();
        // قائمة بالممرضات المسؤول عند هاذا المدير
        public List<nurse> nurses = new List<nurse>();
        // قائمة بالمرضى الذين يتعامل معهم هذا الطبيب

        public List<patient> patients = new List<patient>();

        // دالة لتحويل الكائن إلى سلسلة نصية
        public override string ToString()
        {
            try
            {
                // إرجاع بيانات المدير كسلسلة نصية مفصولة بفواصل
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{sal},{namejob},{namedepartment}";
            }
            catch (Exception ex)
            {
                // في حالة وجود أي خطأ، يتم إرجاع رسالة الخطأ
                return $"{ex}";
            }
        }
        // دالة لتحويل السلسلة النصية إلى كائن من نوع المدير
        public static implicit operator string(Manger manger)
        {
            // استدعاء دالة التحويل إلى سلسلة نصية
            return manger.ToString();
        }

        // دالة لتحويل الكائن إلى كائن من نوع المدير باستخدام السلسلة النصية المعطاة
        public static implicit operator Manger(string str)
        {
            try
            {
                // تقسيم السلسلة النصية إلى أجزاء باستخدام الفواصل
                string[] arr = str.Split(',');
                // استخراج البيانات الفردية من الأجزاء
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


                // إنشاء وإرجاع كائن المدير باستخدام البيانات الفردية
                return new Manger(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment);

            }
            catch (Exception ex)
            {
                // في حالة وجود أي خطأ، يتم إرجاع رسالة الخطأ
                return $"{ex}";
            }
        }

    }
}
