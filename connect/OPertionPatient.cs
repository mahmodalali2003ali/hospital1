using hospital1.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace hospital1.connect
{
    // كلاس يقوم بتنفيذ واجهة IPatientOperiition ويدير العمليات المتعلقة بالمرضى
    internal class OPertionPatient : IPatientOperiition
    {
        // دالة لإضافة مريض جديد إلى الملف
        public void AddPatients(patient patient)
        {
            try
            {
                // الحصول على معرف جديد للمريض
                int new_Idpatients = Operitions.getid("patient.txt");
                patient.id = new_Idpatients;
                // فتح الملف وكتابة بيانات المريض الجديدة فيه
                FileStream fs = new FileStream("patient.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(patient.ToString());
                sr1.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لحذف بيانات المريض من الملف
        public void DeletePatients(patient patient)
        {
            try
            {
                // فتح الملف وقراءة البيانات منه وحذف السطر الذي يحتوي على بيانات المريض المحدد
                FileStream fileStream = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<patient> patients = new List<patient>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (patient.id.Equals(line))
                    {
                        patients.RemoveAll(p => p.id == patient.id);
                    }
                }
                fileStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لجلب بيانات جميع المرضى من الملف
        public List<patient> GetPatients()
        {
            try
            {
                // فتح الملف وقراءة البيانات منه وإضافتها إلى قائمة المرضى
                FileStream fileStream = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<patient> patients = new List<patient>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    patients.Add(line);
                }
                return patients;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }

        // دالة لتحديث بيانات المريض في الملف
        public void UpdatePatients(patient patient)
        {
            try
            {
                List<string> lines = new List<string>();

                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("patient.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == patient.id.ToString())
                        {
                            // بدلاً من حذف السطر، يمكننا تعديله مباشرة
                            // يتم تجاوز البيانات بالبيانات الجديدة للمريض
                            line = $"{patient.id},{patient.first_name},{patient.last_name},{patient.adders},{patient.age},{patient.phon},{patient.email},{patient.gender},{patient.blood_group},{patient.nameillness}";
                        }
                        lines.Add(line);
                    }
                }

                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("patient.txt"))
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
