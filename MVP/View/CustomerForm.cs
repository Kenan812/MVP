using MVP.Model;
using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVP.View
{
    public partial class CustomerForm : Form, ICustomerView
    {
        public CustomerForm()
        {
            InitializeComponent();
        }


        public IList<string> CustomerList
        {
            get { return (IList<string>)this.listBox1.DataSource; }
            set { this.listBox1.DataSource = value; }
        }


        public string Address
        {
            get { return addressTextBox.Text; }
            set { addressTextBox.Text = value; }
        }

        public string FullName
        {
            get { return fullNameTextBox.Text; }
            set { fullNameTextBox.Text = value; }
        }

        public string Email
        {
            get { return emailTextBox.Text; }
            set { emailTextBox.Text = value; }
        }
        
        public string Nationality
        {
            get { return nationalityTextBox.Text; }
            set { nationalityTextBox.Text = value; }
        }


        public CustomerPresenter customerPresenter { get; set; }

        public int SelectedCustomer { get => listBox1.SelectedIndex; set => listBox1.SelectedIndex = value; }





        private void saveButton_Click(object sender, System.EventArgs e)
        {
            customerPresenter.AddCustomer();
        }




        private void editButton_Click(object sender, System.EventArgs e)
        {
            // Check for valid data

            customerPresenter.SaveCustomer();
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            customerPresenter.UpdateCustomerView(listBox1.SelectedIndex);
        }
    }
}
