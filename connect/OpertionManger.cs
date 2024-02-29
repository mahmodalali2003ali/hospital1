using hospital1.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace hospital1.connect
{
    // كلاس يقوم بتنفيذ واجهة IOpertionManger ويدير العمليات المتعلقة بالمدير
    internal class OpertionManger : IOpertionManger
    {
        // دالة لإضافة مدير جديد إلى الملف
        public void AddManger(Manger manger)
        {
            try
            {
                // الحصول على معرف جديد للمدير
                int new_Idpatients = Operitions.getid("Manger.txt");
                manger.id = new_Idpatients;
                // فتح الملف وكتابة بيانات المدير الجديدة فيه
                FileStream fs = new FileStream("Manger.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(manger.ToString());
                sr1.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لحذف بيانات المدير من الملف
        public void DeleteManger(Manger manger)
        {
            try
            {
                FileStream fileStream = new FileStream("Manger.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<Manger> mangers = new List<Manger>();
                string line;
                // البحث عن السطر الذي يحتوي على بيانات المدير المحدد وحذفه
                while ((line = sr.ReadLine()) != null)
                {
                    if (manger.id.Equals(line))
                    {
                        mangers.RemoveAll(p => p.id == manger.id);
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

        // دالة لجلب بيانات جميع المديرين من الملف
        public List<Manger> GetManger()
        {
            try
            {
                FileStream fileStream = new FileStream("Manger.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr1 = new StreamReader(fileStream);
                List<Manger> Mangers = new List<Manger>();
                string line;
                // قراءة بيانات المديرين من الملف وإضافتها إلى قائمة
                while ((line = sr1.ReadLine()) != null)
                {
                    Mangers.Add(line);
                }
                return Mangers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }

        // دالة لتحديث بيانات المدير في الملف
        public void UpdateManger(Manger manger)
        {
            try
            {
                List<string> lines = new List<string>();
                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("Manger.txt"))
                {
                    string line;
                    // البحث عن السطر الذي يحتوي على بيانات المدير المحدد وتحديثه بالبيانات الجديدة
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == manger.id.ToString())
                        {
                            line = $"{manger.id},{manger.first_name},{manger.last_name},{manger.adders},{manger.age},{manger.phon},{manger.email},{manger.gender},{manger.blood_group}";
                        }
                        lines.Add(line);
                    }
                }

                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("Manger.txt"))
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
