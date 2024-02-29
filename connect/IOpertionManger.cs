using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    // واجهة لإدارة العمليات للمدير
    internal interface IOpertionManger
    {
        // دالة للحصول على قائمة بجميع المدراء
        public abstract List<Manger> GetManger();

        // دالة لتحديث بيانات مدير معين
        public abstract void UpdateManger(Manger manger);

        // دالة لحذف مدير معين
        public abstract void DeleteManger(Manger manger);

        // دالة لإضافة مدير جديد
        public abstract void AddManger(Manger manger);
    }
}
