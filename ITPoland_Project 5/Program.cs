using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITPoland_Project_5
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int size;
            int floor;
            int age;
            string address;
            int rooms;
            int bathrooms;
            int price;
            Boolean checkBox1;
            Boolean checkBox2;
            Boolean checkBox3;
            Boolean checkBox4;
            Boolean checkBox5;
            Boolean checkBox6;
            Boolean checkBox7;
            Boolean checkBox8;
            Boolean checkBox9;
            Boolean checkBox10;
            Boolean checkBox11;
            Boolean checkBox12;
            string name;
            string surname;
            string dateOfBirth;
            string addressOwner;
            long phoneNumber;
            string email;
            string pathImage;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                size = Convert.ToInt32(sr.ReadLine());
                floor = Convert.ToInt32(sr.ReadLine());
                age = Convert.ToInt32(sr.ReadLine());
                address = sr.ReadLine();
                rooms = Convert.ToInt32(sr.ReadLine());
                bathrooms = Convert.ToInt32(sr.ReadLine());
                price = Convert.ToInt32(sr.ReadLine());
                checkBox1 = Convert.ToBoolean(sr.ReadLine());
                checkBox2 = Convert.ToBoolean(sr.ReadLine());
                checkBox3 = Convert.ToBoolean(sr.ReadLine());
                checkBox4 = Convert.ToBoolean(sr.ReadLine());
                checkBox5 = Convert.ToBoolean(sr.ReadLine());
                checkBox6 = Convert.ToBoolean(sr.ReadLine());
                checkBox7 = Convert.ToBoolean(sr.ReadLine());
                checkBox8 = Convert.ToBoolean(sr.ReadLine());
                checkBox9 = Convert.ToBoolean(sr.ReadLine());
                checkBox10 = Convert.ToBoolean(sr.ReadLine());
                checkBox11 = Convert.ToBoolean(sr.ReadLine());
                checkBox12 = Convert.ToBoolean(sr.ReadLine());
                name = sr.ReadLine();
                surname = sr.ReadLine();
                dateOfBirth = sr.ReadLine();
                addressOwner = sr.ReadLine();
                phoneNumber = Convert.ToInt64(sr.ReadLine());
                email = sr.ReadLine();
                pathImage = sr.ReadLine();

                ListProperties.properties.Add(new Property(size, floor, age, address, rooms, bathrooms, price, checkBox1, checkBox2,
                    checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9,
                    checkBox10, checkBox11, checkBox12, name, surname, dateOfBirth, addressOwner, phoneNumber, email, pathImage));
            }

            sr.Close();
            fs.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
