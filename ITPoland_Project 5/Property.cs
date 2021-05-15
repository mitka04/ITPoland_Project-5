using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPoland_Project_5
{
    class Property
    {
        public int size;
        public int floor;
        public int age;
        public string address;
        public int rooms;
        public int bathrooms;
        public int price;
        public Boolean checkBox1;
        public Boolean checkBox2;
        public Boolean checkBox3;
        public Boolean checkBox4;
        public Boolean checkBox5;
        public Boolean checkBox6;
        public Boolean checkBox7;
        public Boolean checkBox8;
        public Boolean checkBox9;
        public Boolean checkBox10;
        public Boolean checkBox11;
        public Boolean checkBox12;
        public string name;
        public string surname;
        public string dateOfBirth;
        public string addressOwner;
        public long phoneNumber;
        public string email;
        public string pathImage;

        public Property(int size, int floor, int age, string address, int rooms, int bathrooms, int price, Boolean checkBox1,
            Boolean checkBox2, Boolean checkBox3, Boolean checkBox4, Boolean checkBox5, Boolean checkBox6, Boolean checkBox7,
            Boolean checkBox8, Boolean checkBox9, Boolean checkBox10, Boolean checkBox11, Boolean checkBox12, string name,
            string surname, string dateOfBirth, string addressOwner, long phoneNumber, string email, string pathImage)
        {
            this.size = size;
            this.floor = floor;
            this.age = age;
            this.address = address;
            this.rooms = rooms;
            this.bathrooms = bathrooms;
            this.price = price;
            this.checkBox1 = checkBox1;
            this.checkBox2 = checkBox2;
            this.checkBox3 = checkBox3;
            this.checkBox4 = checkBox4;
            this.checkBox5 = checkBox5;
            this.checkBox6 = checkBox6;
            this.checkBox7 = checkBox7;
            this.checkBox8 = checkBox8;
            this.checkBox9 = checkBox9;
            this.checkBox10 = checkBox10;
            this.checkBox11 = checkBox11;
            this.checkBox12 = checkBox12;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.addressOwner = addressOwner;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.pathImage = pathImage;
        }
    }
}
