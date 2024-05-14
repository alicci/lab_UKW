namespace bank
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWyplac = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKwota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBanknoty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWyplac
            // 
            this.buttonWyplac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyplac.Location = new System.Drawing.Point(156, 235);
            this.buttonWyplac.Name = "buttonWyplac";
            this.buttonWyplac.Size = new System.Drawing.Size(100, 52);
            this.buttonWyplac.TabIndex = 0;
            this.buttonWyplac.Text = "Wyplac";
            this.buttonWyplac.UseVisualStyleBackColor = true;
            this.buttonWyplac.Click += new System.EventHandler(this.buttonWyplac_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdmin.Location = new System.Drawing.Point(447, 235);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(100, 52);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(103, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BANKOMAT";
            // 
            // textBoxKwota
            // 
            this.textBoxKwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKwota.Location = new System.Drawing.Point(130, 159);
            this.textBoxKwota.Name = "textBoxKwota";
            this.textBoxKwota.Size = new System.Drawing.Size(152, 32);
            this.textBoxKwota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj kwote do wyplacenia:";
            // 
            // labelBanknoty
            // 
            this.labelBanknoty.AutoSize = true;
            this.labelBanknoty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBanknoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBanknoty.Location = new System.Drawing.Point(438, 40);
            this.labelBanknoty.Name = "labelBanknoty";
            this.labelBanknoty.Size = new System.Drawing.Size(48, 20);
            this.labelBanknoty.TabIndex = 5;
            this.labelBanknoty.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 368);
            this.Controls.Add(this.labelBanknoty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKwota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonWyplac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWyplac;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKwota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBanknoty;
    }
}

