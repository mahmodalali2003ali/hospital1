using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    // واجهة لعمليات الطبيب
    internal interface IDoctorOperition
    {
        // دالة للحصول على قائمة بجميع الأطباء
        public abstract List<Doctor> GetDoctors();

        // دالة لتحديث بيانات طبيب معين
        public abstract void UpdateDoctors(Doctor doctor);

        // دالة لحذف طبيب معين
        public abstract void DeleteDoctor(Doctor doctor);

        // دالة لإضافة طبيب جديد
        public abstract void AddDoctor(Doctor doctor);
    }
}
