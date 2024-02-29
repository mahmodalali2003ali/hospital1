using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    // واجهة لعمليات المرضى
    internal interface IPatientOperiition
    {
        // دالة للحصول على قائمة بجميع المرضى
        public abstract List<patient> GetPatients();

        // دالة لتحديث بيانات مريض معين
        public abstract void UpdatePatients(patient patient);

        // دالة لحذف مريض معين
        public abstract void DeletePatients(patient patient);

        // دالة لإضافة مريض جديد
        public abstract void AddPatients(patient patient);
    }
}
