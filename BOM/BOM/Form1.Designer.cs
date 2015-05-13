namespace BOM
{
    partial class Form1
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
            this.input_nutzerName = new System.Windows.Forms.TextBox();
            this.label_nutzerName = new System.Windows.Forms.Label();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.button_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_nutzerName
            // 
            this.input_nutzerName.Location = new System.Drawing.Point(112, 33);
            this.input_nutzerName.Name = "input_nutzerName";
            this.input_nutzerName.Size = new System.Drawing.Size(169, 20);
            this.input_nutzerName.TabIndex = 0;
            // 
            // label_nutzerName
            // 
            this.label_nutzerName.AutoSize = true;
            this.label_nutzerName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nutzerName.Location = new System.Drawing.Point(9, 30);
            this.label_nutzerName.Name = "label_nutzerName";
            this.label_nutzerName.Size = new System.Drawing.Size(97, 21);
            this.label_nutzerName.TabIndex = 1;
            this.label_nutzerName.Text = "Nutzername:";
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(112, 77);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '*';
            this.input_pwd.Size = new System.Drawing.Size(169, 20);
            this.input_pwd.TabIndex = 2;
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.Location = new System.Drawing.Point(12, 74);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(77, 21);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "Password:";
            // 
            // button_Anmelden
            // 
            this.button_Anmelden.Location = new System.Drawing.Point(94, 125);
            this.button_Anmelden.Name = "button_Anmelden";
            this.button_Anmelden.Size = new System.Drawing.Size(116, 32);
            this.button_Anmelden.TabIndex = 4;
            this.button_Anmelden.Text = "Anmelden";
            this.button_Anmelden.UseVisualStyleBackColor = true;
            this.button_Anmelden.Click += new System.EventHandler(this.button_Anmelden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 180);
            this.Controls.Add(this.button_Anmelden);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.input_pwd);
            this.Controls.Add(this.label_nutzerName);
            this.Controls.Add(this.input_nutzerName);
            this.Name = "Form1";
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.Form1_Load);
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

