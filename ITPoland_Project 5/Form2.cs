using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITPoland_Project_5
{
    public partial class Form2 : Form
    {
        Bitmap image;
        public static string path = Path.GetFileName("imageNotAvailable.jpg");
        int size;
        int floor;
        int age;
        string address;
        int rooms;
        int bathrooms;
        int price;
        Boolean optionCheckBox1;
        Boolean optionCheckBox2;
        Boolean optionCheckBox3;
        Boolean optionCheckBox4;
        Boolean optionCheckBox5;
        Boolean optionCheckBox6;
        Boolean optionCheckBox7;
        Boolean optionCheckBox8;
        Boolean optionCheckBox9;
        Boolean optionCheckBox10;
        Boolean optionCheckBox11;
        Boolean optionCheckBox12;
        string name;
        string surname;
        int dateOfBirth;
        string addressOwner;
        long phoneNumber;
        string email;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Unable to open the selected file",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" &&
                textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "") 
            {
                if (path != "imageNotAvailable.jpg")
                {
                    File.Copy(path, Path.Combine(Path.GetFileName(path)), true);
                    path = Path.GetFileName(path);
                }
                if (textBox1.Text != "")
                {
                    size = Convert.ToInt32(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    floor = Convert.ToInt32(textBox2.Text);
                }
                if (textBox3.Text != "")
                {
                    age = Convert.ToInt32(textBox3.Text);
                }
                if (textBox4.Text != "")
                {
                    address = textBox4.Text;
                }
                if (textBox5.Text != "")
                {
                    rooms = Convert.ToInt32(textBox5.Text);
                }
                if (textBox6.Text != "")
                {
                    bathrooms = Convert.ToInt32(textBox6.Text);
                }
                if (textBox7.Text != "")
                {
                    price = Convert.ToInt32(textBox7.Text);
                }
                optionCheckBox1 = checkBox1.Checked;
                optionCheckBox2 = checkBox2.Checked;
                optionCheckBox3 = checkBox3.Checked;
                optionCheckBox4 = checkBox4.Checked;
                optionCheckBox5 = checkBox5.Checked;
                optionCheckBox6 = checkBox6.Checked;
                optionCheckBox7 = checkBox7.Checked;
                optionCheckBox8 = checkBox8.Checked;
                optionCheckBox9 = checkBox9.Checked;
                optionCheckBox10 = checkBox10.Checked;
                optionCheckBox11 = checkBox11.Checked;
                optionCheckBox12 = checkBox12.Checked;
                if (textBox8.Text != "")
                {
                    name = textBox8.Text;
                }
                if (textBox9.Text != "")
                {
                    surname = textBox9.Text;
                }
                if (textBox10.Text != "")
                {
                    dateOfBirth = Convert.ToInt32(textBox10.Text);
                }
                if (textBox11.Text != "")
                {
                    addressOwner = textBox11.Text;
                }
                if (textBox12.Text != "")
                {
                    phoneNumber = Convert.ToInt64(textBox12.Text);
                }
                if (textBox13.Text != "")
                {
                    email = textBox13.Text;
                }
                ListProperties.properties.Add(new Property(size, floor, age, address, rooms, bathrooms, price, optionCheckBox1, optionCheckBox2,
                    optionCheckBox3, optionCheckBox4, optionCheckBox5, optionCheckBox6, optionCheckBox7, optionCheckBox8, optionCheckBox9,
                    optionCheckBox10, optionCheckBox11, optionCheckBox12, name, surname, dateOfBirth, addressOwner, phoneNumber, email, path));

                FileStream fs = new FileStream("data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("+++++++++++++");
                sw.WriteLine(size);
                sw.WriteLine(floor);
                sw.WriteLine(age);
                sw.WriteLine(address);
                sw.WriteLine(rooms);
                sw.WriteLine(bathrooms);
                sw.WriteLine(price);
                sw.WriteLine(optionCheckBox1);
                sw.WriteLine(optionCheckBox2);
                sw.WriteLine(optionCheckBox3);
                sw.WriteLine(optionCheckBox4);
                sw.WriteLine(optionCheckBox5);
                sw.WriteLine(optionCheckBox6);
                sw.WriteLine(optionCheckBox7);
                sw.WriteLine(optionCheckBox8);
                sw.WriteLine(optionCheckBox9);
                sw.WriteLine(optionCheckBox10);
                sw.WriteLine(optionCheckBox11);
                sw.WriteLine(optionCheckBox12);
                sw.WriteLine(name);
                sw.WriteLine(surname);
                sw.WriteLine(dateOfBirth);
                sw.WriteLine(addressOwner);
                sw.WriteLine(phoneNumber);
                sw.WriteLine(email);
                sw.WriteLine(path);
                sw.Close();
                fs.Close();

                MessageBox.Show("Data successfully added!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                pictureBox1.Image = Properties.Resources.imageNotAvailable;
            }
            else
            {
                MessageBox.Show("Please enter the properties!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
