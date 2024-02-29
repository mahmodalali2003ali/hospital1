using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class parson
    {
        // تعريف الخصائص الخاصة بالشخص

        // خصائص خاصة بالمعرف
        private int Id;

        // خصائص خاصة بالاسم
        private string First_Name;
        private string Last_Name;

        // خصائص خاصة بالعنوان
        private string Adders;

        // خصائص خاصة بالعمر
        private int Age;

        // خصائص خاصة برقم الهاتف والبريد الإلكتروني
        private string Phon;
        private string Email;

        // خصائص خاصة بالجنس وفصيلة الدم
        private string Gender;
        private string Blood_group;

        // مُنشئ الفئة لتهيئة الخصائص عند إنشاء كائن من الفئة
        public parson(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group)
        {
            // تعيين القيم الممررة إلى الخصائص الخاصة
            Id = id;
            First_Name = first_Name;
            Last_Name = last_Name;
            Adders = adders;
            Age = age;
            Phon = phon;
            Email = email;
            Gender = gender;
            Blood_group = blood_group;
        }

        // تعريف الخصائص العامة للوصول والتعيين

        // خاصية المعرف
        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                // التحقق من أن المعرف يكون قيمة موجبة
                if (value >= 0)
                {
                    Id = value;
                }
            }
        }

        // خاصية الاسم الأول
        public string first_name
        {
            get
            {
                return First_Name;
            }
            set
            {
                // التحقق من أن طول الاسم الأول يكون أكبر من 2 أحرف
                if (value.Length >= 2)
                {
                    First_Name = value;
                }
            }
        }

        // خاصية الاسم الأخير
        public string last_name
        {
            get
            {
                return Last_Name;
            }
            set
            {
                // التحقق من أن طول الاسم الأخير يكون أكبر من 2 أحرف
                if (value.Length >= 2)
                {
                    last_name = value;
                }
            }
        }

        // خاصية العنوان
        public string adders
        {
            get
            {
                return Adders;
            }
            set
            {
                // التحقق من أن طول العنوان يكون أكبر من 2 أحرف
                if (value.Length >= 2)
                {
                    Adders = value;
                }
            }
        }

        // خاصية العمر
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                // التحقق من أن العمر يكون قيمة موجبة
                if (value >= 0)
                {
                    Age = value;
                }
            }
        }

        // خاصية رقم الهاتف
        public string phon
        {
            get
            {
                return Phon;
            }
            set
            {
                // التحقق من أن طول رقم الهاتف يكون 5 أرقام
                if (value.Length == 5)
                {
                    Phon = value;
                }
            }
        }

        // خاصية البريد الإلكتروني
        public string email
        {

            get
            {
                return Email;
            }
            set
            {
                // التحقق من أن طول البريد الإلكتروني يكون أكبر من 10 أحرف
                if (value.Length >= 10)
                {
                    Email = value;
                }
            }
        }

        // خاصية الجنس
        public string gender
        {
            get
            {
                return Gender;
            }
            set
            {
                // التحقق من أن طول الجنس يكون أكبر من 4 أحرف
                if (value.Length >= 4)
                {
                    Gender = value;
                }
            }

        }

        // خاصية فصيلة الدم
        public string blood_group
        {
            get
            {
                return Blood_group;
            }
            set
            {
                // التحقق من أن طول فصيلة الدم يكون أكبر من 2 أحرف
                if (value.Length >= 2)
                {
                    Blood_group = value;
                }
            }

        }
    }
}
