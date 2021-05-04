using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPoland_Project_5
{
    public partial class Form3 : Form
    {
        public int numberOfData;
        int currentData = 1;
        int currentDataFromList = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {
            currentData++;
            currentDataFromList++;
            currentContactLabel.Text = currentData + "";
            if (currentData < numberOfData && currentData > 1)
            {
                nextRecordButton.Enabled = true;
                previouseRecordButton.Enabled = true;
            }
            else if (currentData == numberOfData)
            {
                nextRecordButton.Enabled = false;
                previouseRecordButton.Enabled = true;
            }

            numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
            sizeLabel.Text = ListProperties.properties[currentDataFromList].size + "";
            floorLabel.Text = ListProperties.properties[currentDataFromList].floor + "";
            ageLabel.Text = ListProperties.properties[currentDataFromList].age + "";
            addressLabel.Text = ListProperties.properties[currentDataFromList].address;
            roomsLabel.Text = ListProperties.properties[currentDataFromList].rooms + "";
            bathroomsLabel.Text = ListProperties.properties[currentDataFromList].bathrooms + "";
            priceLabel.Text = ListProperties.properties[currentDataFromList].price + "";
            checkBox1.Checked = ListProperties.properties[currentDataFromList].checkBox1;
            checkBox2.Checked = ListProperties.properties[currentDataFromList].checkBox2;
            checkBox3.Checked = ListProperties.properties[currentDataFromList].checkBox3;
            checkBox4.Checked = ListProperties.properties[currentDataFromList].checkBox4;
            checkBox5.Checked = ListProperties.properties[currentDataFromList].checkBox5;
            checkBox6.Checked = ListProperties.properties[currentDataFromList].checkBox6;
            checkBox7.Checked = ListProperties.properties[currentDataFromList].checkBox7;
            checkBox8.Checked = ListProperties.properties[currentDataFromList].checkBox8;
            checkBox9.Checked = ListProperties.properties[currentDataFromList].checkBox9;
            checkBox10.Checked = ListProperties.properties[currentDataFromList].checkBox10;
            checkBox11.Checked = ListProperties.properties[currentDataFromList].checkBox11;
            checkBox12.Checked = ListProperties.properties[currentDataFromList].checkBox12;
            nameLabel.Text = ListProperties.properties[currentDataFromList].name;
            surnameLabel.Text = ListProperties.properties[currentDataFromList].surname;
            dateOfBirthLabel.Text = ListProperties.properties[currentDataFromList].dateOfBirth + "";
            addressOwnerLabel.Text = ListProperties.properties[currentDataFromList].addressOwner;
            phoneNumberLabel.Text = ListProperties.properties[currentDataFromList].phoneNumber + "";
            emailLabel.Text = ListProperties.properties[currentDataFromList].email;       
            Bitmap image = new Bitmap(ListProperties.properties[currentDataFromList].pathImage);
            pictureBox1.Image = image;
        }

        private void previouseRecordButton_Click(object sender, EventArgs e)
        {
            currentData--;
            currentDataFromList--;
            currentContactLabel.Text = currentData + "";
            if (currentData < numberOfData && currentData > 1)
            {
                nextRecordButton.Enabled = true;
                previouseRecordButton.Enabled = true;
            }
            else if (currentData == 1)
            {
                previouseRecordButton.Enabled = false;
                nextRecordButton.Enabled = true;
            }

            numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
            sizeLabel.Text = ListProperties.properties[currentDataFromList].size + "";
            floorLabel.Text = ListProperties.properties[currentDataFromList].floor + "";
            ageLabel.Text = ListProperties.properties[currentDataFromList].age + "";
            addressLabel.Text = ListProperties.properties[currentDataFromList].address;
            roomsLabel.Text = ListProperties.properties[currentDataFromList].rooms + "";
            bathroomsLabel.Text = ListProperties.properties[currentDataFromList].bathrooms + "";
            priceLabel.Text = ListProperties.properties[currentDataFromList].price + "";
            checkBox1.Checked = ListProperties.properties[currentDataFromList].checkBox1;
            checkBox2.Checked = ListProperties.properties[currentDataFromList].checkBox2;
            checkBox3.Checked = ListProperties.properties[currentDataFromList].checkBox3;
            checkBox4.Checked = ListProperties.properties[currentDataFromList].checkBox4;
            checkBox5.Checked = ListProperties.properties[currentDataFromList].checkBox5;
            checkBox6.Checked = ListProperties.properties[currentDataFromList].checkBox6;
            checkBox7.Checked = ListProperties.properties[currentDataFromList].checkBox7;
            checkBox8.Checked = ListProperties.properties[currentDataFromList].checkBox8;
            checkBox9.Checked = ListProperties.properties[currentDataFromList].checkBox9;
            checkBox10.Checked = ListProperties.properties[currentDataFromList].checkBox10;
            checkBox11.Checked = ListProperties.properties[currentDataFromList].checkBox11;
            checkBox12.Checked = ListProperties.properties[currentDataFromList].checkBox12;
            nameLabel.Text = ListProperties.properties[currentDataFromList].name;
            surnameLabel.Text = ListProperties.properties[currentDataFromList].surname;
            dateOfBirthLabel.Text = ListProperties.properties[currentDataFromList].dateOfBirth + "";
            addressOwnerLabel.Text = ListProperties.properties[currentDataFromList].addressOwner;
            phoneNumberLabel.Text = ListProperties.properties[currentDataFromList].phoneNumber + "";
            emailLabel.Text = ListProperties.properties[currentDataFromList].email;
            Bitmap image = new Bitmap(ListProperties.properties[currentDataFromList].pathImage);
            pictureBox1.Image = image;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
        }
    }
}
