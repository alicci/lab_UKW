namespace PESEL.Okienka
{
    partial class RetroMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetroMessageBox));
            this.labelKomunikat = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKomunikat
            // 
            this.labelKomunikat.Font = new System.Drawing.Font("Retro Computer", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKomunikat.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelKomunikat.Location = new System.Drawing.Point(42, 33);
            this.labelKomunikat.Name = "labelKomunikat";
            this.labelKomunikat.Size = new System.Drawing.Size(262, 159);
            this.labelKomunikat.TabIndex = 1;
            this.labelKomunikat.Text = "label1                                                                           " +
    "                             end";
            this.labelKomunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Black;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Retro Computer", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.PaleGreen;
            this.buttonOk.Location = new System.Drawing.Point(81, 235);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(198, 39);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.button_Click);
            this.buttonOk.MouseLeave += new System.EventHandler(this.buttonOk_MouseLeave);
            this.buttonOk.MouseHover += new System.EventHandler(this.buttonOk_MouseHover);
            // 
            // RetroMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 328);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelKomunikat);
            this.Name = "RetroMessageBox";
            this.Text = "RetroMessageBox";
            this.Load += new System.EventHandler(this.RetroMessageBox_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelKomunikat;
        private System.Windows.Forms.Button buttonOk;
    }
}