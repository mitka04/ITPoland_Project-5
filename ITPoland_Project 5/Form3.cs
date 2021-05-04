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
        int currentContact = 1;
        int currentContactFromList = 0;
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
            currentContact++;
            currentContactFromList++;
            currentContactLabel.Text = currentContact + "";
            if (currentContact < numberOfData && currentContact > 1)
            {
                nextRecordButton.Enabled = true;
                previouseRecordButton.Enabled = true;
            }
            else if (currentContact == numberOfData)
            {
                nextRecordButton.Enabled = false;
                previouseRecordButton.Enabled = true;
            }

            numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
            currentContactLabel.Text = 1 + "";
            sizeLabel.Text = ListProperties.properties[currentContactFromList].size + "";
            floorLabel.Text = ListProperties.properties[currentContactFromList].floor + "";
            ageLabel.Text = ListProperties.properties[currentContactFromList].age + "";
            addressLabel.Text = ListProperties.properties[currentContactFromList].address;
            roomsLabel.Text = ListProperties.properties[currentContactFromList].rooms + "";
            bathroomsLabel.Text = ListProperties.properties[currentContactFromList].bathrooms + "";
            priceLabel.Text = ListProperties.properties[currentContactFromList].price + "";
            checkBox1.Checked = ListProperties.properties[currentContactFromList].checkBox1;
            checkBox2.Checked = ListProperties.properties[currentContactFromList].checkBox2;
            checkBox3.Checked = ListProperties.properties[currentContactFromList].checkBox3;
            checkBox4.Checked = ListProperties.properties[currentContactFromList].checkBox4;
            checkBox5.Checked = ListProperties.properties[currentContactFromList].checkBox5;
            checkBox6.Checked = ListProperties.properties[currentContactFromList].checkBox6;
            checkBox7.Checked = ListProperties.properties[currentContactFromList].checkBox7;
            checkBox8.Checked = ListProperties.properties[currentContactFromList].checkBox8;
            checkBox9.Checked = ListProperties.properties[currentContactFromList].checkBox9;
            checkBox10.Checked = ListProperties.properties[currentContactFromList].checkBox10;
            checkBox11.Checked = ListProperties.properties[currentContactFromList].checkBox11;
            checkBox12.Checked = ListProperties.properties[currentContactFromList].checkBox12;
            nameLabel.Text = ListProperties.properties[currentContactFromList].name;
            surnameLabel.Text = ListProperties.properties[currentContactFromList].surname;
            dateOfBirthLabel.Text = ListProperties.properties[currentContactFromList].dateOfBirth + "";
            addressOwnerLabel.Text = ListProperties.properties[currentContactFromList].addressOwner;
            phoneNumberLabel.Text = ListProperties.properties[currentContactFromList].phoneNumber + "";
            emailLabel.Text = ListProperties.properties[currentContactFromList].email;       
            Bitmap image = new Bitmap(ListProperties.properties[currentContactFromList].pathImage);
            pictureBox1.Image = image;
        }

        private void previouseRecordButton_Click(object sender, EventArgs e)
        {
            currentContact--;
            currentContactFromList--;
            currentContactLabel.Text = currentContact + "";
            if (currentContact < numberOfData && currentContact > 1)
            {
                nextRecordButton.Enabled = true;
                previouseRecordButton.Enabled = true;
            }
            else if (currentContact == 1)
            {
                previouseRecordButton.Enabled = false;
                nextRecordButton.Enabled = true;
            }

            numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
            currentContactLabel.Text = 1 + "";
            sizeLabel.Text = ListProperties.properties[currentContactFromList].size + "";
            floorLabel.Text = ListProperties.properties[currentContactFromList].floor + "";
            ageLabel.Text = ListProperties.properties[currentContactFromList].age + "";
            addressLabel.Text = ListProperties.properties[currentContactFromList].address;
            roomsLabel.Text = ListProperties.properties[currentContactFromList].rooms + "";
            bathroomsLabel.Text = ListProperties.properties[currentContactFromList].bathrooms + "";
            priceLabel.Text = ListProperties.properties[currentContactFromList].price + "";
            checkBox1.Checked = ListProperties.properties[currentContactFromList].checkBox1;
            checkBox2.Checked = ListProperties.properties[currentContactFromList].checkBox2;
            checkBox3.Checked = ListProperties.properties[currentContactFromList].checkBox3;
            checkBox4.Checked = ListProperties.properties[currentContactFromList].checkBox4;
            checkBox5.Checked = ListProperties.properties[currentContactFromList].checkBox5;
            checkBox6.Checked = ListProperties.properties[currentContactFromList].checkBox6;
            checkBox7.Checked = ListProperties.properties[currentContactFromList].checkBox7;
            checkBox8.Checked = ListProperties.properties[currentContactFromList].checkBox8;
            checkBox9.Checked = ListProperties.properties[currentContactFromList].checkBox9;
            checkBox10.Checked = ListProperties.properties[currentContactFromList].checkBox10;
            checkBox11.Checked = ListProperties.properties[currentContactFromList].checkBox11;
            checkBox12.Checked = ListProperties.properties[currentContactFromList].checkBox12;
            nameLabel.Text = ListProperties.properties[currentContactFromList].name;
            surnameLabel.Text = ListProperties.properties[currentContactFromList].surname;
            dateOfBirthLabel.Text = ListProperties.properties[currentContactFromList].dateOfBirth + "";
            addressOwnerLabel.Text = ListProperties.properties[currentContactFromList].addressOwner;
            phoneNumberLabel.Text = ListProperties.properties[currentContactFromList].phoneNumber + "";
            emailLabel.Text = ListProperties.properties[currentContactFromList].email;
            Bitmap image = new Bitmap(ListProperties.properties[currentContactFromList].pathImage);
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
