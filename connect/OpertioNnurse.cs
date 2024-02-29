using hospital1.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace hospital1.connect
{
    // كلاس يقوم بتنفيذ واجهة INurse ويدير العمليات المتعلقة بالممرضات
    internal class OpertioNnurse : INurse
    {
        // دالة لإضافة ممرضة جديدة إلى الملف
        public void Addnurse(nurse nurse)
        {
            try
            {
                // الحصول على معرف جديد للممرضة
                int new_Idpatients = Operitions.getid("nurse.txt");
                nurse.id = new_Idpatients;
                // فتح الملف وكتابة بيانات الممرضة الجديدة فيه
                FileStream fs = new FileStream("nurse.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(nurse.ToString());
                sr1.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لحذف بيانات الممرضة من الملف
        public void Deletenurser(nurse nurse)
        {
            try
            {
                // فتح الملف وقراءة البيانات منه وحذف السطر الذي يحتوي على بيانات الممرضة المحددة
                FileStream fileStream = new FileStream("nurse.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<nurse> nurses = new List<nurse>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (nurse.id.Equals(line))
                    {
                        nurses.RemoveAll(p => p.id == nurse.id);
                    }
                }
                fileStream.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لجلب بيانات جميع الممرضات من الملف
        public List<nurse> Getnurse()
        {
            try
            {
                // فتح الملف وقراءة البيانات منه وإضافتها إلى قائمة الممرضات
                FileStream fileStream = new FileStream("nurse.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<nurse> nurses = new List<nurse>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    nurses.Add(line);
                }
                return nurses;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }

        // دالة لتحديث بيانات الممرضة في الملف
        public void Updatenurse(nurse nurse)
        {
            try
            {
                List<string> lines = new List<string>();

                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("nurse.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == nurse.id.ToString())
                        {
                            // البحث عن السطر الذي يحتوي على بيانات الممرضة المحددة وتحديثه بالبيانات الجديدة
                            line = $"{nurse.id},{nurse.first_name},{nurse.last_name},{nurse.adders},{nurse.age},{nurse.phon},{nurse.email},{nurse.gender},{nurse.blood_group},{nurse.sal},{nurse.namejob},{nurse.namedepartment},{nurse.specialty}";
                        }
                        lines.Add(line);
                    }
                }

                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("nurse.txt"))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }
    }
}
