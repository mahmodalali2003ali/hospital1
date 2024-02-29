using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    // واجهة لعمليات الممرضة
    internal interface INurse
    {
        // دالة للحصول على قائمة بجميع الممرضات
        public abstract List<nurse> Getnurse();

        // دالة لتحديث بيانات ممرضة معينة
        public abstract void Updatenurse(nurse nurse);

        // دالة لحذف ممرضة معينة
        public abstract void Deletenurser(nurse nurse);

        // دالة لإضافة ممرضة جديدة
        public abstract void Addnurse(nurse nurse);
    }
}
