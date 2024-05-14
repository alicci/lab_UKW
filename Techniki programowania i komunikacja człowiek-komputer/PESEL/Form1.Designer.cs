namespace PESEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.BackColor = System.Drawing.Color.Black;
            this.textBoxPESEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPESEL.Font = new System.Drawing.Font("Retro Computer", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPESEL.ForeColor = System.Drawing.Color.PaleGreen;
            this.textBoxPESEL.Location = new System.Drawing.Point(71, 230);
            this.textBoxPESEL.MaxLength = 11;
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(264, 27);
            this.textBoxPESEL.TabIndex = 1;
            this.textBoxPESEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Retro Computer", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(106, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wprowadz PESEL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Retro Computer", 11.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poprawnosc nr PESEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.BackColor = System.Drawing.Color.Black;
            this.buttonSprawdz.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonSprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSprawdz.Font = new System.Drawing.Font("Retro Computer", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSprawdz.ForeColor = System.Drawing.Color.PaleGreen;
            this.buttonSprawdz.Location = new System.Drawing.Point(110, 305);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(183, 39);
            this.buttonSprawdz.TabIndex = 5;
            this.buttonSprawdz.Text = "Sprawdz";
            this.buttonSprawdz.UseVisualStyleBackColor = false;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            this.buttonSprawdz.MouseLeave += new System.EventHandler(this.buttonSprawdz_MouseLeave);
            this.buttonSprawdz.MouseHover += new System.EventHandler(this.buttonSprawdz_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Retro Computer", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wprowadz date urodzenia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.PaleGreen;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.PaleGreen;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.PaleGreen;
            this.dateTimePicker1.Font = new System.Drawing.Font("Retro Computer", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 148);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxPESEL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSprawdz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 399);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(33, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 23);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Retro Computer", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(33, 149);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(327, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "data urodzenia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(417, 408);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "PESEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

