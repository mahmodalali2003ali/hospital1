using hospital1.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace hospital1.connect
{
    // كلاس يقوم بتنفيذ واجهة IDoctorOperition ويدير العمليات المتعلقة بالأطباء
    internal class OpertionDoctor : IDoctorOperition
    {
        // دالة لإضافة طبيب جديد إلى الملف
        public void AddDoctor(Doctor doctor)
        {
            try
            {
                // الحصول على معرف جديد للطبيب
                int new_Idpatients = Operitions.getid("doctors.txt");
                doctor.id = new_Idpatients;
                // فتح الملف وكتابة بيانات الطبيب الجديدة فيه
                FileStream fs = new FileStream("doctors.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(doctor.ToString());
                sr1.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لحذف بيانات الطبيب من الملف
        public void DeleteDoctor(Doctor doctor)
        {
            try
            {
                // فتح الملف وقراءة البيانات منه
                FileStream fileStream = new FileStream("doctors.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<Doctor> doctors = new List<Doctor>();
                string line;
                // البحث عن السطر الذي يحتوي على بيانات الطبيب المحدد وحذفه
                while ((line = sr.ReadLine()) != null)
                {
                    if (doctor.id.Equals(line))
                    {
                        doctors.RemoveAt(doctor.id);
                    }

                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        // دالة لجلب بيانات جميع الأطباء من الملف
        public List<Doctor> GetDoctors()
        {
            try
            {
                // فتح الملف وقراءة البيانات منه وإعادتها كقائمة من كائنات الأطباء
                FileStream fileStream = new FileStream("doctors.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr1 = new StreamReader(fileStream);
                List<Doctor> doctors = new List<Doctor>();
                string line;
                while ((line = sr1.ReadLine()) != null)
                {
                    doctors.Add(line);
                }
                return doctors;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }

        // دالة لتحديث بيانات الطبيب في الملف
        public void UpdateDoctors(Doctor doctor)
        {
            try
            {
                List<Doctor> lines = new List<Doctor>();
                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("doctors.txt"))
                {
                    string line;
                    // البحث عن السطر الذي يحتوي على بيانات الطبيب المحدد وتحديثه بالبيانات الجديدة
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == doctor.id.ToString())
                        {
                            line = $"{doctor.id},{doctor.first_name},{doctor.last_name},{doctor.adders},{doctor.age},{doctor.phon},{doctor.email},{doctor.gender},{doctor.blood_group},{doctor.sal},{doctor.namejob},{doctor.namedepartment},{doctor.specialty}";
                        }
                        lines.Add(line);
                    }
                }
                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("doctors.txt"))
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
