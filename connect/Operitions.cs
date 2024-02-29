using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// استيراد المكتبات اللازمة
using System.IO;

namespace hospital1.connect
{
    internal class Operitions
    {
        // دالة للحصول على الهوية الفريدة بناءً على آخر هوية مسجلة في الملف
        public static int getid(string filename)
        {
            int id = 0;
            // فتح أو إنشاء ملف وصول إليه
            FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            string lastline = "";
            string line;
            // قراءة الخطوط من الملف للعثور على آخر هوية
            while ((line = sr.ReadLine()) != null)
            {
                lastline = line;
            }
            // استخراج الهوية من آخر سطر وزيادة القيمة بواحد للحصول على الهوية الجديدة
            int lastid = Convert.ToInt32(lastline.Split(',')[0]);
            return lastid + 1;
        }
    }
}
