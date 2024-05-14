namespace bank
{
    partial class AdminForm
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
            this.comboBoxNominal = new System.Windows.Forms.ComboBox();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.buttonUzupelnij = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.labelBanknoty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNominal
            // 
            this.comboBoxNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNominal.FormattingEnabled = true;
            this.comboBoxNominal.Location = new System.Drawing.Point(192, 164);
            this.comboBoxNominal.Name = "comboBoxNominal";
            this.comboBoxNominal.Size = new System.Drawing.Size(106, 30);
            this.comboBoxNominal.TabIndex = 0;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIlosc.Location = new System.Drawing.Point(37, 164);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(100, 28);
            this.textBoxIlosc.TabIndex = 1;
            // 
            // buttonUzupelnij
            // 
            this.buttonUzupelnij.Location = new System.Drawing.Point(119, 247);
            this.buttonUzupelnij.Name = "buttonUzupelnij";
            this.buttonUzupelnij.Size = new System.Drawing.Size(97, 30);
            this.buttonUzupelnij.TabIndex = 2;
            this.buttonUzupelnij.Text = "Uzupelnij";
            this.buttonUzupelnij.UseVisualStyleBackColor = true;
            this.buttonUzupelnij.Click += new System.EventHandler(this.buttonUzupelnij_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(119, 283);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(97, 28);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // labelBanknoty
            // 
            this.labelBanknoty.AutoSize = true;
            this.labelBanknoty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBanknoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBanknoty.Location = new System.Drawing.Point(430, 89);
            this.labelBanknoty.Name = "labelBanknoty";
            this.labelBanknoty.Size = new System.Drawing.Size(72, 20);
            this.labelBanknoty.TabIndex = 4;
            this.labelBanknoty.Text = "Banknoty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ilosc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "nominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ZŁ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modyfikuj zasoby bankomatu";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBanknoty);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonUzupelnij);
            this.Controls.Add(this.textBoxIlosc);
            this.Controls.Add(this.comboBoxNominal);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNominal;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Button buttonUzupelnij;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Label labelBanknoty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}