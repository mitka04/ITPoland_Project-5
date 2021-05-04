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
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            int numberOfData = ListProperties.properties.Count();

            if (numberOfData < 1)
            {
                MessageBox.Show("Contacts list is empty!");
            }
            else if (numberOfData > 1)
            {
                this.Hide();
                form3.numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
                form3.currentContactLabel.Text = 1 + "";
                form3.sizeLabel.Text = ListProperties.properties[0].size + "";
                form3.floorLabel.Text = ListProperties.properties[0].floor + "";
                form3.ageLabel.Text = ListProperties.properties[0].age + "";
                form3.addressLabel.Text = ListProperties.properties[0].address;
                form3.roomsLabel.Text = ListProperties.properties[0].rooms + "";
                form3.bathroomsLabel.Text = ListProperties.properties[0].bathrooms + "";
                form3.priceLabel.Text = ListProperties.properties[0].price + "";
                form3.checkBox1.Checked = ListProperties.properties[0].checkBox1;
                form3.checkBox2.Checked = ListProperties.properties[0].checkBox2;
                form3.checkBox3.Checked = ListProperties.properties[0].checkBox3;
                form3.checkBox4.Checked = ListProperties.properties[0].checkBox4;
                form3.checkBox5.Checked = ListProperties.properties[0].checkBox5;
                form3.checkBox6.Checked = ListProperties.properties[0].checkBox6;
                form3.checkBox7.Checked = ListProperties.properties[0].checkBox7;
                form3.checkBox8.Checked = ListProperties.properties[0].checkBox8;
                form3.checkBox9.Checked = ListProperties.properties[0].checkBox9;
                form3.checkBox10.Checked = ListProperties.properties[0].checkBox10;
                form3.checkBox11.Checked = ListProperties.properties[0].checkBox11;
                form3.checkBox12.Checked = ListProperties.properties[0].checkBox12;
                form3.nameLabel.Text = ListProperties.properties[0].name;
                form3.surnameLabel.Text = ListProperties.properties[0].surname;
                form3.dateOfBirthLabel.Text = ListProperties.properties[0].dateOfBirth + "";
                form3.addressOwnerLabel.Text = ListProperties.properties[0].addressOwner;
                form3.phoneNumberLabel.Text = ListProperties.properties[0].phoneNumber + "";
                form3.emailLabel.Text = ListProperties.properties[0].email;
                form3.numberOfData = numberOfData;
                form3.previouseRecordButton.Enabled = false;
                image = new Bitmap(ListProperties.properties[0].pathImage);
                form3.pictureBox1.Image = image;
                form3.ShowDialog();
            }
            else if (numberOfData == 1)
            {
                this.Hide();
                form3.numberOfContactsLabel.Text = ListProperties.properties.Count() + "";
                form3.currentContactLabel.Text = 1 + "";
                form3.sizeLabel.Text = ListProperties.properties[0].size + "";
                form3.floorLabel.Text = ListProperties.properties[0].floor + "";
                form3.ageLabel.Text = ListProperties.properties[0].age + "";
                form3.addressLabel.Text = ListProperties.properties[0].address;
                form3.roomsLabel.Text = ListProperties.properties[0].rooms + "";
                form3.bathroomsLabel.Text = ListProperties.properties[0].bathrooms + "";
                form3.priceLabel.Text = ListProperties.properties[0].price + "";
                form3.checkBox1.Checked = ListProperties.properties[0].checkBox1;
                form3.checkBox2.Checked = ListProperties.properties[0].checkBox2;
                form3.checkBox3.Checked = ListProperties.properties[0].checkBox3;
                form3.checkBox4.Checked = ListProperties.properties[0].checkBox4;
                form3.checkBox5.Checked = ListProperties.properties[0].checkBox5;
                form3.checkBox6.Checked = ListProperties.properties[0].checkBox6;
                form3.checkBox7.Checked = ListProperties.properties[0].checkBox7;
                form3.checkBox8.Checked = ListProperties.properties[0].checkBox8;
                form3.checkBox9.Checked = ListProperties.properties[0].checkBox9;
                form3.checkBox10.Checked = ListProperties.properties[0].checkBox10;
                form3.checkBox11.Checked = ListProperties.properties[0].checkBox11;
                form3.checkBox12.Checked = ListProperties.properties[0].checkBox12;
                form3.nameLabel.Text = ListProperties.properties[0].name;
                form3.surnameLabel.Text = ListProperties.properties[0].surname;
                form3.dateOfBirthLabel.Text = ListProperties.properties[0].dateOfBirth + "";
                form3.addressOwnerLabel.Text = ListProperties.properties[0].addressOwner;
                form3.phoneNumberLabel.Text = ListProperties.properties[0].phoneNumber + "";
                form3.emailLabel.Text = ListProperties.properties[0].email;
                form3.previouseRecordButton.Enabled = false;
                form3.nextRecordButton.Enabled = false;
                form3.numberOfData= numberOfData;
                image = new Bitmap(ListProperties.properties[0].pathImage);
                form3.pictureBox1.Image = image;
                form3.ShowDialog();
            }
        }
    }
}
