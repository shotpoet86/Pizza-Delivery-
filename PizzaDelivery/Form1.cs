//Programmer: Austin Parker
//Assignment: Chapter 10/ PE 10/ PizzaDelivery
//Description: Programs allows user to create pizza order
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Instructions and greeting to user
            MessageBox.Show("Hello and Welcome to Hot Pizza!\n" +
                "Our prices are based on the size pizza you order only, all toppings are free. Enjoy!");
        }
        double total;
        double pizzaPrice;
        string address, phone, email;
        string pizzaSize, pizzaTopping;
        int pizzaQuantity;
        string wings, chikenStrip, bread, garlicKnots, Soda;

        public object SelectedText { get; private set; }
        private void makeOrderButton_Click_1(object sender, EventArgs e)
        {
            {
                // check if address is not
                // specified by the user
                if (addressTextBox.Text == "")
                {
                    // display message to user to
                    // enter the address
                    MessageBox.Show("Please enter address");
                }
                // check if the phone is not entered.
                else if (phoneTextBox.Text == "")
                {
                    // display message to user about
                    // to enter the phone
                    MessageBox.Show("Please enter phone");
                }
                // check if the email is not entered.
                else if (emailTextBox.Text == "")
                {
                    // display message to user about
                    // to enter the email
                    MessageBox.Show("Please enter email");
                }
                // check if the user has selected
                // the pizza toppings or specialty pizza from pizzaListBox
                else if (pizzaListBox.SelectedItem == null)
                {
                    // display the message if user not
                    // select the pizza
                    MessageBox.Show("Please select Pizza");
                }
                // check if the user is not select
                // the size of pizza
                else if (pizzaSizeComboBox.SelectedItem == null)
                {
                    // display message to user if
                    // user not select the size of pizza
                    MessageBox.Show("Please select " +
                    "pizza size");
                }
                // check if the user not selected
                // the quantity of pizza.
                else if
                (pizzaQuantityComboBox.SelectedItem == null)
                {
                    // display message to user if
                    // user not select the quantity
                    // of pizza
                    MessageBox.Show("Please select " +
                    "pizza quantity");
                }
                else if (selectSauceComboBox.SelectedText == null)
                {
                    // display message to user if
                    // user not select the sauce
                    MessageBox.Show("Please select sauce");
                }
                else
                {
                    // display the message to user
                    // about order
                    MessageBox.Show("Contact Information ---" +
                        "\nE-mail : " + email
                    + " \nPhone number : " + phone
                    + " \nAddress : " + address
                    + "\n\nPizza Details ---\n" + pizzaTopping
                    + " \n\nTotal price for current order --- " +
                    "$ " + total);
                }
            }
        }
        private void breadQuantityTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (breadQuantityTextBox.Text == "")
                {
                    //runs when reset button is pressed
                }
                else
                {
                    //adds price of bread selection to total
                    bread = breadQuantityTextBox.Text;
                    bread = (Convert.ToInt32(bread) * 3.00).ToString();
                    total += Convert.ToInt32(bread);
                }
            }
        }
        private void garlicKnotsTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (garlicKnotsTextBox.Text == "")
                {
                    //adds price of garlic knots selection to total
                }
                else
                {
                    garlicKnots = garlicKnotsTextBox.Text;
                    garlicKnots = (Convert.ToInt32(garlicKnots) * 4.00).ToString();
                    total += Convert.ToInt32(garlicKnots);
                }
            }
        }
        private void SodaTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (sodaTextBox.Text == "")
                {
                    //runs when reset button is pressed
                }
                else
                {
                    //adds price of soda selection to total
                    Soda = sodaTextBox.Text;
                    Soda = (Convert.ToInt32(Soda) * 2.00).ToString();
                    total += Convert.ToInt32(Soda);
                }
            }
        }

        private void wingsQuantityTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (wingsQuantityTextBox.Text == "")
                {
                    //runs when reset button is pressed
                }
                //calculate total price
                else
                {
                    //adds price of wings selection to total
                    wings = wingsQuantityTextBox.Text;
                    wings = (Convert.ToInt32(wings) * 6.00).ToString();
                    total += Convert.ToInt32(wings);
                }
            }
        }
        private void chickenStripsTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (chickenStripsTextBox.Text == "")
                {
                    //runs when reset button is pressed
                }
                else
                {
                    //adds price of chicken tenders selection to total
                    chikenStrip = chickenStripsTextBox.Text;
                    chikenStrip = (Convert.ToInt32(chikenStrip) * 5.00).ToString();
                    total += Convert.ToInt32(chikenStrip);
                }
            }
        }

        private void pizzaSizeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            {
                //check if the selected item of pizzaSizeCombo is null
                if (pizzaSizeComboBox.SelectedItem == null)
                {

                }
                //else calculate pizza price based on pizza size
                else
                {
                    //get the pizza size
                    pizzaSize = pizzaSizeComboBox.SelectedIndex.ToString();
                    //check if small pizza
                    if (pizzaSize == "0")
                    {
                        //add $15.00 to pizza price
                        pizzaPrice += 15;
                    }
                    //check if medium
                    else if (pizzaSize == "1")
                    {
                        //add $20.00 to pizza price
                        pizzaPrice += 20;
                    }
                    //check if large
                    else if (pizzaSize == "2")
                    {
                        //add $25.00 to pizza price
                        pizzaPrice += 25;
                    }
                }
            }
        }

        private void selectSauceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
        private void pizzaQuantityComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                //check if quantity is null
                if (pizzaQuantityComboBox.SelectedIndex == null)
                {

                }
                //runs when reset button is pressed
                //else calculate pizza price based on quantity
                else
                {
                    pizzaQuantity = Convert.ToInt32(pizzaQuantityComboBox.SelectedItem);
                    pizzaPrice = pizzaQuantity * pizzaPrice;
                    total = pizzaPrice + total;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pizzaListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pizzaTopping = pizzaListBox.SelectedIndex.ToString();
        }

        private void garlicKnotsLabel_Click(object sender, EventArgs e)
        {

        }

        //if user clicks the reset button
        private void resetButton_Click_1(object sender, EventArgs e)
        {
            //Resets total to $0 and Utilities class resets all fields
            total = 0;
            Utilities.ResetAllControls(this);
        }
        private void phoneTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                //keeps the phone number
                phone = phoneTextBox.Text;
            }
        }

        private void pizzaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (string activity in pizzaListBox.SelectedItems)
            {
                pizzaTopping += activity + "";

            }
            this.pizzaListBox.Text = pizzaTopping;
        }

        private void emailTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                //keeps the address
                email = emailTextBox.Text;

            }
        }
        //when txt of address TextBox is changed
        private void addressTextBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                //keeps the address
                address = addressTextBox.Text;
            }
        }
    }
}






