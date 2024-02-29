using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class patient : parson
    {
        // خصائص الفئة

        // اسم المرض
        private string NameIllness;

        // قائمة بالأطباء المعالجين لهذا المريض
        public List<Doctor> Doctors = new List<Doctor>();

        // قائمة بالممرضات المسؤولات عن رعاية هذا المريض
        public List<nurse> nurses = new List<nurse>();

        // قائمة بالمرضى (يمكن أن يكون فارغًا، لكن قمت بتعريفها هنا)
        public List<patient> patients = new List<patient>();

        // مُنشئ الفئة لتهيئة خصائص المريض
        public patient(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, string nameIllness) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group)
        {
            // تهيئة اسم المرض
            NameIllness = nameIllness;
        }

        // خاصية اسم المرض
        public string nameillness
        {
            get
            {
                return NameIllness;
            }
            set
            {
                // التحقق من أن طول اسم المرض يكون أكبر من 5 أحرف
                if (value.Length >= 5)
                {
                    NameIllness = value;
                }
            }

        }

        // دالة لتحويل الكائن إلى سلسلة نصية
        public override string ToString()
        {
            try
            {
                // إرجاع بيانات المريض كسلسلة نصية مفصولة بفواصل
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{nameillness}";
            }
            catch (Exception ex)
            {
                // في حالة وجود أي خطأ، يتم إرجاع رسالة الخطأ
                return $"{ex}";
            }
        }

        // دالة لتحويل السلسلة النصية إلى كائن من نوع المريض
        public static implicit operator string(patient p)
        {
            // استدعاء دالة التحويل إلى سلسلة نصية
            return p.ToString();
        }

        // دالة لتحويل الكائن إلى كائن من نوع المريض باستخدام السلسلة النصية المعطاة
        public static implicit operator patient(string str)
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
                string nameIllness = arr[9];

                // إنشاء وإرجاع كائن المريض باستخدام البيانات الفردية
                return new patient(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group, nameIllness);
            }
            catch (Exception ex)
            {
                // في حالة وجود أي خطأ، يتم إرجاع رسالة الخطأ
                return $"{ex}";
            }
        }
    }
}
