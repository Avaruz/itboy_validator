using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validator
{
    public partial class RegisterForm : Form
    {

        public string Information
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    builder.AppendLine(string.Format("Name: {0}", this.txtName.Text));
                }
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    builder.AppendLine(string.Format("Password: {0}", this.txtPassword.Text));
                }
                if (!string.IsNullOrEmpty(txtBirth.Text))
                {
                    builder.AppendLine(string.Format("Birth: {0}", this.txtBirth.Text));
                }
                if (!string.IsNullOrEmpty(txtIncome.Text))
                {
                    builder.AppendLine(string.Format("Income: {0}", this.txtIncome.Text));
                }
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    builder.AppendLine(string.Format("Email: {0}", this.txtEmail.Text));
                }

                return builder.ToString();
            }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1000, 9999);
            lblCode.Text = value.ToString();
        }

        private void validator1_CustomValidation(object sender, Itboy.Components.ValidationEventArgs e)
        {
            if (e.Control == txtCode)
            {
                if (txtCode.Text == lblCode.Text)
                {
                    e.Valid = true;
                }
                else
                {
                    e.Valid = false;
                }
            }
        }
    }
}