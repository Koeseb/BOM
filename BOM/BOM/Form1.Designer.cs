namespace BOM
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_nutzerName = new System.Windows.Forms.TextBox();
            this.label_nutzerName = new System.Windows.Forms.Label();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.button_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_nutzerName
            // 
            this.input_nutzerName.Location = new System.Drawing.Point(106, 34);
            this.input_nutzerName.Name = "input_nutzerName";
            this.input_nutzerName.Size = new System.Drawing.Size(180, 20);
            this.input_nutzerName.TabIndex = 0;
            // 
            // label_nutzerName
            // 
            this.label_nutzerName.AutoSize = true;
            this.label_nutzerName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nutzerName.Location = new System.Drawing.Point(3, 31);
            this.label_nutzerName.Name = "label_nutzerName";
            this.label_nutzerName.Size = new System.Drawing.Size(97, 21);
            this.label_nutzerName.TabIndex = 1;
            this.label_nutzerName.Text = "Nutzername:";
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(106, 83);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.Size = new System.Drawing.Size(180, 20);
            this.input_pwd.TabIndex = 2;
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.Location = new System.Drawing.Point(3, 82);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(73, 21);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "Passwort:";
            // 
            // button_Anmelden
            // 
            this.button_Anmelden.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Anmelden.Location = new System.Drawing.Point(123, 128);
            this.button_Anmelden.Name = "button_Anmelden";
            this.button_Anmelden.Size = new System.Drawing.Size(84, 37);
            this.button_Anmelden.TabIndex = 4;
            this.button_Anmelden.Text = "Anmelden";
            this.button_Anmelden.UseVisualStyleBackColor = true;
            this.button_Anmelden.Click += new System.EventHandler(this.button_Anmelden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 177);
            this.Controls.Add(this.button_Anmelden);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.input_pwd);
            this.Controls.Add(this.label_nutzerName);
            this.Controls.Add(this.input_nutzerName);
            this.Name = "Form1";
            this.Text = "BOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_nutzerName;
        private System.Windows.Forms.Label label_nutzerName;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button button_Anmelden;
    }
}

