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
    public partial class Form4 : Form
    {
        int numberOfData;
        int currentData = 1;
        int currentDataFromList = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Go to form 1
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            unEnableCheckBoxes();
            unEnableGroupBoxes();
        }
        // method unenable groupBoxes
        private void unEnableGroupBoxes() {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }
        // method enable groupBoxes
        private void enableGroupBoxes()
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }
        private void unEnableCheckBoxes() {
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchProperty.searchProperties.Clear();
                // Checking the price radioButton
                if (priceButton.Checked)
                {
                 currentData = 1;
                 currentDataFromList = 0;
                if (price1.Text == "" && price2.Text == "")
                    {
                        MessageBox.Show("Please enter price information!");
                }
                else { 
                    for (int i = 0; i < ListProperties.properties.Count; i++)
                    {
                        int price = ListProperties.properties[i].price;
                        if (price >= Convert.ToInt32(price1.Text) && price <= Convert.ToInt32(price2.Text))
                        {
                            SearchProperty.searchProperties.Add(ListProperties.properties[i]);
                        }
                    }
                }
                enableGroupBoxes();
                numberOfData = SearchProperty.searchProperties.Count;
                numberOfDataLabel.Text = numberOfData + "";
                if (numberOfData == 1)
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = false;
                    currentDataLabel.Text = currentData + "";
                    sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
                    floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
                    ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
                    addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
                    roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
                    bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
                    priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
                    checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
                    checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
                    checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
                    checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
                    checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
                    checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
                    checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
                    checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
                    checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
                    checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
                    checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
                    checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
                    nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
                    surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
                    dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
                    addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
                    phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
                    emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
                    Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
                    pictureBox1.Image = image;
                }
                else if (numberOfData > 1)
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = true;
                    currentDataLabel.Text = currentData + "";
                    sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
                    floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
                    ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
                    addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
                    roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
                    bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
                    priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
                    checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
                    checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
                    checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
                    checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
                    checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
                    checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
                    checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
                    checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
                    checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
                    checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
                    checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
                    checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
                    nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
                    surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
                    dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
                    addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
                    phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
                    emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
                    Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
                    pictureBox1.Image = image;
                }
                else
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = false;
                    currentDataLabel.Text = 0 + "";
                    sizeLabel.Text = "";
                    floorLabel.Text = "";
                    ageLabel.Text = "";
                    addressLabel.Text = "";
                    roomsLabel.Text = "";
                    bathroomsLabel.Text = "";
                    priceLabel.Text = "";
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
                    nameLabel.Text = "";
                    surnameLabel.Text = "";
                    dateOfBirthLabel.Text = "";
                    addressOwnerLabel.Text = "";
                    phoneNumberLabel.Text = "";
                    emailLabel.Text = "";
                    pictureBox1.Image = Properties.Resources.imageNotAvailable;
                }

            }
            // Checking the rooms radioButton 
            if (roomsButton.Checked)
            {
                currentData = 1;
                currentDataFromList = 0;
                if (rooms.Text == "")
                {
                    MessageBox.Show("Please enter the rooms information!");
                }
                else
                {
                    for (int i = 0; i < ListProperties.properties.Count; i++)
                    {
                        int roomsNumber = ListProperties.properties[i].rooms;
                        if (roomsNumber == Convert.ToInt32(rooms.Text))
                        {
                            SearchProperty.searchProperties.Add(ListProperties.properties[i]);
                        }
                    }
                }
                enableGroupBoxes();
                numberOfData = SearchProperty.searchProperties.Count;
                numberOfDataLabel.Text = numberOfData + "";
                if (numberOfData == 1)
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = false;
                    currentDataLabel.Text = currentData + "";
                    sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
                    floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
                    ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
                    addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
                    roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
                    bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
                    priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
                    checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
                    checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
                    checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
                    checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
                    checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
                    checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
                    checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
                    checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
                    checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
                    checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
                    checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
                    checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
                    nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
                    surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
                    dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
                    addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
                    phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
                    emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
                    Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
                    pictureBox1.Image = image;
                }
                else if (numberOfData > 1)
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = true;
                    currentDataLabel.Text = currentData + "";
                    sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
                    floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
                    ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
                    addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
                    roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
                    bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
                    priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
                    checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
                    checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
                    checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
                    checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
                    checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
                    checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
                    checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
                    checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
                    checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
                    checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
                    checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
                    checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
                    nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
                    surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
                    dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
                    addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
                    phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
                    emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
                    Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
                    pictureBox1.Image = image;
                }
                else
                {
                    previouseRecordButton.Enabled = false;
                    nextRecordButton.Enabled = false;
                    currentDataLabel.Text = 0 + "";
                    sizeLabel.Text = "";
                    floorLabel.Text = "";
                    ageLabel.Text = "";
                    addressLabel.Text = "";
                    roomsLabel.Text = "";
                    bathroomsLabel.Text = "";
                    priceLabel.Text = "";
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
                    nameLabel.Text = "";
                    surnameLabel.Text = "";
                    dateOfBirthLabel.Text = "";
                    addressOwnerLabel.Text = "";
                    phoneNumberLabel.Text = "";
                    emailLabel.Text = "";
                    pictureBox1.Image = Properties.Resources.imageNotAvailable;
                }
            }
        }

        private void numberOfDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void previouseRecordButton_Click(object sender, EventArgs e)
        {
            currentData--;
            currentDataFromList--;
            currentDataLabel.Text = currentData + "";
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
            currentDataLabel.Text = currentData + "";
            sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
            floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
            ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
            addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
            roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
            bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
            priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
            checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
            checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
            checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
            checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
            checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
            checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
            checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
            checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
            checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
            checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
            checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
            checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
            nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
            surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
            dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
            addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
            phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
            emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
            Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
            pictureBox1.Image = image;
        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {
            currentData++;
            currentDataFromList++;
            currentDataLabel.Text = currentData + "";
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
            currentDataLabel.Text = currentData + "";
            sizeLabel.Text = SearchProperty.searchProperties[currentDataFromList].size + "";
            floorLabel.Text = SearchProperty.searchProperties[currentDataFromList].floor + "";
            ageLabel.Text = SearchProperty.searchProperties[currentDataFromList].age + "";
            addressLabel.Text = SearchProperty.searchProperties[currentDataFromList].address;
            roomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].rooms + "";
            bathroomsLabel.Text = SearchProperty.searchProperties[currentDataFromList].bathrooms + "";
            priceLabel.Text = SearchProperty.searchProperties[currentDataFromList].price + "";
            checkBox1.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox1;
            checkBox2.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox2;
            checkBox3.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox3;
            checkBox4.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox4;
            checkBox5.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox5;
            checkBox6.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox6;
            checkBox7.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox7;
            checkBox8.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox8;
            checkBox9.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox9;
            checkBox10.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox10;
            checkBox11.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox11;
            checkBox12.Checked = SearchProperty.searchProperties[currentDataFromList].checkBox12;
            nameLabel.Text = SearchProperty.searchProperties[currentDataFromList].name;
            surnameLabel.Text = SearchProperty.searchProperties[currentDataFromList].surname;
            dateOfBirthLabel.Text = SearchProperty.searchProperties[currentDataFromList].dateOfBirth;
            addressOwnerLabel.Text = SearchProperty.searchProperties[currentDataFromList].addressOwner;
            phoneNumberLabel.Text = SearchProperty.searchProperties[currentDataFromList].phoneNumber + "";
            emailLabel.Text = SearchProperty.searchProperties[currentDataFromList].email;
            Bitmap image = new Bitmap(SearchProperty.searchProperties[currentDataFromList].pathImage);
            pictureBox1.Image = image;
        }
    }
}
