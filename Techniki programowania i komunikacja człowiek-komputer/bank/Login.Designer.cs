namespace bank
{
    partial class Login
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
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(113, 257);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(75, 28);
            this.buttonZaloguj.TabIndex = 0;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(81, 134);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 22);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(81, 190);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(132, 22);
            this.textBoxHaslo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaloguj się";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonZaloguj);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label label1;
    }
}