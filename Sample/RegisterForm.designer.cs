namespace Validator
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepassword = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.validator1 = new Itboy.Components.Validator(this.components);
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(0, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRepassword
            // 
            this.lblRepassword.Location = new System.Drawing.Point(0, 91);
            this.lblRepassword.Name = "lblRepassword";
            this.lblRepassword.Size = new System.Drawing.Size(100, 13);
            this.lblRepassword.TabIndex = 4;
            this.lblRepassword.Text = "RePassword:";
            this.lblRepassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBirth
            // 
            this.lblBirth.Location = new System.Drawing.Point(0, 129);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(100, 13);
            this.lblBirth.TabIndex = 6;
            this.lblBirth.Text = "Birth:";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Income(year):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVerify
            // 
            this.lblVerify.Location = new System.Drawing.Point(0, 243);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(100, 13);
            this.lblVerify.TabIndex = 13;
            this.lblVerify.Text = "Verify code:";
            this.lblVerify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCode.Location = new System.Drawing.Point(187, 243);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(33, 12);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "0000";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(43, 277);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Submit";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(154, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.validator1.SetCustomMessage(this.txtCode, "Please enter the verify code on the right.");
            this.txtCode.Location = new System.Drawing.Point(105, 238);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(68, 20);
            this.txtCode.TabIndex = 7;
            this.validator1.SetType(this.txtCode, ((Itboy.Components.ValidationType)((Itboy.Components.ValidationType.Required | Itboy.Components.ValidationType.Custom))));
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 200);
            this.txtEmail.Name = "txtEmail";
            this.validator1.SetRegularExpression(this.txtEmail, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9}" +
                    ")$");
            this.validator1.SetRegularExpressionMessage(this.txtEmail, "Email invalid!");
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 6;
            this.validator1.SetType(this.txtEmail, ((Itboy.Components.ValidationType)((Itboy.Components.ValidationType.Required | Itboy.Components.ValidationType.RegularExpression))));
            // 
            // txtIncome
            // 
            this.validator1.SetDataType(this.txtIncome, Itboy.Components.ValidationDataType.Currency);
            this.txtIncome.Location = new System.Drawing.Point(105, 163);
            this.txtIncome.Name = "txtIncome";
            this.validator1.SetRangeMessage(this.txtIncome, "You salary must between {$lower}-{$upper}");
            this.validator1.SetRangeOfLowerBound(this.txtIncome, "0");
            this.validator1.SetRangeOfUpperBound(this.txtIncome, "999999");
            this.txtIncome.Size = new System.Drawing.Size(146, 20);
            this.txtIncome.TabIndex = 5;
            this.validator1.SetType(this.txtIncome, Itboy.Components.ValidationType.Range);
            // 
            // txtBirth
            // 
            this.validator1.SetCompareMessage(this.txtBirth, "This field is not a valid {$datatype}.");
            this.validator1.SetDataType(this.txtBirth, Itboy.Components.ValidationDataType.Date);
            this.txtBirth.Location = new System.Drawing.Point(105, 125);
            this.txtBirth.Name = "txtBirth";
            this.validator1.SetRequiredMessage(this.txtBirth, "");
            this.txtBirth.Size = new System.Drawing.Size(146, 20);
            this.txtBirth.TabIndex = 4;
            this.validator1.SetType(this.txtBirth, Itboy.Components.ValidationType.Compare);
            // 
            // txtRepassword
            // 
            this.validator1.SetComparedControl(this.txtRepassword, this.txtPassword);
            this.validator1.SetCompareMessage(this.txtRepassword, "Re-password must equal to password.");
            this.validator1.SetCompareOperator(this.txtRepassword, Itboy.Components.ValidationCompareOperator.Equal);
            this.txtRepassword.Location = new System.Drawing.Point(105, 87);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(146, 20);
            this.txtRepassword.TabIndex = 3;
            this.validator1.SetType(this.txtRepassword, ((Itboy.Components.ValidationType)((Itboy.Components.ValidationType.Required | Itboy.Components.ValidationType.Compare))));
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.validator1.SetRegularExpression(this.txtPassword, "^[a-zA-Z][a-zA-z0-9]{2,7}$");
            this.validator1.SetRegularExpressionMessage(this.txtPassword, "Password must 3-8 letters, and begin with alpha.");
            this.validator1.SetRequiredMessage(this.txtPassword, "Password is required.");
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 2;
            this.validator1.SetType(this.txtPassword, ((Itboy.Components.ValidationType)((Itboy.Components.ValidationType.Required | Itboy.Components.ValidationType.RegularExpression))));
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 11);
            this.txtName.Name = "txtName";
            this.validator1.SetRequiredMessage(this.txtName, "Name is required!");
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 1;
            this.validator1.SetType(this.txtName, Itboy.Components.ValidationType.Required);
            // 
            // validator1
            // 
            this.validator1.Form = this;
            this.validator1.CustomValidation += new System.EventHandler<Itboy.Components.ValidationEventArgs>(this.validator1_CustomValidation);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 315);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.lblRepassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRepassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private Itboy.Components.Validator validator1;
    }
}