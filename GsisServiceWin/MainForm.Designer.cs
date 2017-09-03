using GsisServicesLib.Greek;

namespace GsisServiceWin
{
    partial class MainForm
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.CallServiceViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authorizedVatNumerTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.authorizedVatNumerLabel = new System.Windows.Forms.Label();
            this.getEntityVatInfoButton = new System.Windows.Forms.Button();
            this.getEntityVatInfoLabel = new System.Windows.Forms.Label();
            this.getEntityVatTextBox = new System.Windows.Forms.TextBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CallServiceViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CallServiceViewModelBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(148, 31);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // CallServiceViewModelBindingSource
            // 
            this.CallServiceViewModelBindingSource.DataSource = typeof(GsisServicesLib.Greek.CallServiceViewModel);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CallServiceViewModelBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(148, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(191, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // authorizedVatNumerTextBox
            // 
            this.authorizedVatNumerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CallServiceViewModelBindingSource, "AuthVatNumber", true));
            this.authorizedVatNumerTextBox.Location = new System.Drawing.Point(148, 81);
            this.authorizedVatNumerTextBox.Name = "authorizedVatNumerTextBox";
            this.authorizedVatNumerTextBox.Size = new System.Drawing.Size(191, 20);
            this.authorizedVatNumerTextBox.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(85, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(57, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "UserName";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(85, 58);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // authorizedVatNumerLabel
            // 
            this.authorizedVatNumerLabel.AutoSize = true;
            this.authorizedVatNumerLabel.Location = new System.Drawing.Point(29, 84);
            this.authorizedVatNumerLabel.Name = "authorizedVatNumerLabel";
            this.authorizedVatNumerLabel.Size = new System.Drawing.Size(113, 13);
            this.authorizedVatNumerLabel.TabIndex = 5;
            this.authorizedVatNumerLabel.Text = "Authorized VatNumber";
            // 
            // getEntityVatInfoButton
            // 
            this.getEntityVatInfoButton.Location = new System.Drawing.Point(719, 29);
            this.getEntityVatInfoButton.Name = "getEntityVatInfoButton";
            this.getEntityVatInfoButton.Size = new System.Drawing.Size(109, 22);
            this.getEntityVatInfoButton.TabIndex = 6;
            this.getEntityVatInfoButton.Text = "Get Vat Entity Info";
            this.getEntityVatInfoButton.UseVisualStyleBackColor = true;
            this.getEntityVatInfoButton.Click += new System.EventHandler(this.GetEntityVatInfoButton_Click);
            // 
            // getEntityVatInfoLabel
            // 
            this.getEntityVatInfoLabel.AutoSize = true;
            this.getEntityVatInfoLabel.Location = new System.Drawing.Point(496, 34);
            this.getEntityVatInfoLabel.Name = "getEntityVatInfoLabel";
            this.getEntityVatInfoLabel.Size = new System.Drawing.Size(111, 13);
            this.getEntityVatInfoLabel.TabIndex = 8;
            this.getEntityVatInfoLabel.Text = "Search by VatNumber";
            // 
            // getEntityVatTextBox
            // 
            this.getEntityVatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CallServiceViewModelBindingSource, "SearchForVatNumber", true));
            this.getEntityVatTextBox.Location = new System.Drawing.Point(613, 31);
            this.getEntityVatTextBox.Name = "getEntityVatTextBox";
            this.getEntityVatTextBox.Size = new System.Drawing.Size(100, 20);
            this.getEntityVatTextBox.TabIndex = 7;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 127);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(816, 370);
            this.ResultsTextBox.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(744, 99);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 22);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.CallServiceViewModelBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 509);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.getEntityVatInfoLabel);
            this.Controls.Add(this.getEntityVatTextBox);
            this.Controls.Add(this.getEntityVatInfoButton);
            this.Controls.Add(this.authorizedVatNumerLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.authorizedVatNumerTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "MainForm";
            this.Text = "Greek GGSIS VatNumber Service";
            ((System.ComponentModel.ISupportInitialize)(this.CallServiceViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox authorizedVatNumerTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label authorizedVatNumerLabel;
        private System.Windows.Forms.Button getEntityVatInfoButton;
        private System.Windows.Forms.Label getEntityVatInfoLabel;
        private System.Windows.Forms.TextBox getEntityVatTextBox;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource CallServiceViewModelBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

