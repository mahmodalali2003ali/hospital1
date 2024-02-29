using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class Employe : parson // تعريف الفئة Employe ويرث الخصائص من الفئة parson
    {
        private int Sal; // خصائص الراتب
        private string NameJob; // خصائص اسم الوظيفة
        private string NameDepartment; // خصائص اسم القسم

        // مُنشئ الفئة لتهيئة الخصائص عند إنشاء كائن من الفئة
        public Employe(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group)
        {
            Sal = sal; // تعيين القيمة الممررة لخصائص الراتب
            NameJob = nameJob; // تعيين القيمة الممررة لخصائص اسم الوظيفة
            NameDepartment = nameDepartment; // تعيين القيمة الممررة لخصائص اسم القسم
        }

        // خاصية الراتب
        public int sal
        {
            get
            {
                return Sal;
            }
            set
            {
                // التحقق من أن الراتب يكون قيمة موجبة
                if (value > 0)
                {
                    Sal = value;
                }
            }
        }

        // خاصية اسم الوظيفة
        public string namejob
        {
            get
            {
                return NameJob;
            }
            set
            {
                // التحقق من أن طول اسم الوظيفة يكون أكبر من 4 أحرف
                if (value.Length > 4)
                {
                    NameJob = value;
                }
            }
        }

        // خاصية اسم القسم
        public string namedepartment
        {
            get
            {
                return NameDepartment;
            }
            set
            {
                // التحقق من أن طول اسم القسم يكون أكبر من 4 أحرف
                if (value.Length > 4)
                {
                    NameDepartment = value;
                }
            }
        }
    }
}
