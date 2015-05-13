namespace BOM
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActivityPage = new System.Windows.Forms.TabPage();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.listBox_ActivityList = new System.Windows.Forms.ListBox();
            this.label_Activities = new System.Windows.Forms.Label();
            this.BuchungsPage = new System.Windows.Forms.TabPage();
            this.comboBox_USt = new System.Windows.Forms.ComboBox();
            this.button_Book = new System.Windows.Forms.Button();
            this.radioButton_Eingangsrechnung = new System.Windows.Forms.RadioButton();
            this.radioButton_Ausgangsrechnung = new System.Windows.Forms.RadioButton();
            this.comboBox_GruppenWahl = new System.Windows.Forms.ComboBox();
            this.label_GruppenWahl = new System.Windows.Forms.Label();
            this.label_Beschreibung = new System.Windows.Forms.Label();
            this.label_Betrag = new System.Windows.Forms.Label();
            this.input_Betrag = new System.Windows.Forms.TextBox();
            this.label_USt = new System.Windows.Forms.Label();
            this.label_Betriebsanteil = new System.Windows.Forms.Label();
            this.input_Betriebsanteil = new System.Windows.Forms.TextBox();
            this.label_Buchungsdatum = new System.Windows.Forms.Label();
            this.dateTime_Buchungsdatum = new System.Windows.Forms.DateTimePicker();
            this.label_Rechnungsdatum = new System.Windows.Forms.Label();
            this.dateTime_Rechnungsdatum = new System.Windows.Forms.DateTimePicker();
            this.FahrtenPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Beschreibung = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.ActivityPage.SuspendLayout();
            this.BuchungsPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActivityPage);
            this.tabControl1.Controls.Add(this.BuchungsPage);
            this.tabControl1.Controls.Add(this.FahrtenPage);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // ActivityPage
            // 
            this.ActivityPage.Controls.Add(this.button_Refresh);
            this.ActivityPage.Controls.Add(this.listBox_ActivityList);
            this.ActivityPage.Controls.Add(this.label_Activities);
            this.ActivityPage.Location = new System.Drawing.Point(4, 22);
            this.ActivityPage.Name = "ActivityPage";
            this.ActivityPage.Size = new System.Drawing.Size(630, 332);
            this.ActivityPage.TabIndex = 0;
            this.ActivityPage.Text = "Aktivitäten";
            this.ActivityPage.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(544, 23);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // listBox_ActivityList
            // 
            this.listBox_ActivityList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_ActivityList.FormattingEnabled = true;
            this.listBox_ActivityList.ItemHeight = 21;
            this.listBox_ActivityList.Location = new System.Drawing.Point(3, 52);
            this.listBox_ActivityList.Name = "listBox_ActivityList";
            this.listBox_ActivityList.Size = new System.Drawing.Size(624, 277);
            this.listBox_ActivityList.TabIndex = 1;
            // 
            // label_Activities
            // 
            this.label_Activities.AutoSize = true;
            this.label_Activities.Font = new System.Drawing.Font("Segoe UI Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Activities.Location = new System.Drawing.Point(6, 11);
            this.label_Activities.Name = "label_Activities";
            this.label_Activities.Size = new System.Drawing.Size(166, 45);
            this.label_Activities.TabIndex = 0;
            this.label_Activities.Text = "Aktivitäten";
            // 
            // BuchungsPage
            // 
            this.BuchungsPage.Controls.Add(this.comboBox_Beschreibung);
            this.BuchungsPage.Controls.Add(this.comboBox_USt);
            this.BuchungsPage.Controls.Add(this.button_Book);
            this.BuchungsPage.Controls.Add(this.radioButton_Eingangsrechnung);
            this.BuchungsPage.Controls.Add(this.radioButton_Ausgangsrechnung);
            this.BuchungsPage.Controls.Add(this.comboBox_GruppenWahl);
            this.BuchungsPage.Controls.Add(this.label_GruppenWahl);
            this.BuchungsPage.Controls.Add(this.label_Beschreibung);
            this.BuchungsPage.Controls.Add(this.label_Betrag);
            this.BuchungsPage.Controls.Add(this.input_Betrag);
            this.BuchungsPage.Controls.Add(this.label_USt);
            this.BuchungsPage.Controls.Add(this.label_Betriebsanteil);
            this.BuchungsPage.Controls.Add(this.input_Betriebsanteil);
            this.BuchungsPage.Controls.Add(this.label_Buchungsdatum);
            this.BuchungsPage.Controls.Add(this.dateTime_Buchungsdatum);
            this.BuchungsPage.Controls.Add(this.label_Rechnungsdatum);
            this.BuchungsPage.Controls.Add(this.dateTime_Rechnungsdatum);
            this.BuchungsPage.Location = new System.Drawing.Point(4, 22);
            this.BuchungsPage.Name = "BuchungsPage";
            this.BuchungsPage.Size = new System.Drawing.Size(630, 332);
            this.BuchungsPage.TabIndex = 1;
            this.BuchungsPage.Text = "Buchungen";
            this.BuchungsPage.UseVisualStyleBackColor = true;
            // 
            // comboBox_USt
            // 
            this.comboBox_USt.FormattingEnabled = true;
            this.comboBox_USt.Location = new System.Drawing.Point(19, 224);
            this.comboBox_USt.Name = "comboBox_USt";
            this.comboBox_USt.Size = new System.Drawing.Size(173, 21);
            this.comboBox_USt.TabIndex = 17;
            // 
            // button_Book
            // 
            this.button_Book.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Book.Location = new System.Drawing.Point(448, 271);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(162, 43);
            this.button_Book.TabIndex = 16;
            this.button_Book.Text = "Buchen";
            this.button_Book.UseVisualStyleBackColor = true;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // radioButton_Eingangsrechnung
            // 
            this.radioButton_Eingangsrechnung.AutoSize = true;
            this.radioButton_Eingangsrechnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Eingangsrechnung.Location = new System.Drawing.Point(219, 271);
            this.radioButton_Eingangsrechnung.Name = "radioButton_Eingangsrechnung";
            this.radioButton_Eingangsrechnung.Size = new System.Drawing.Size(126, 19);
            this.radioButton_Eingangsrechnung.TabIndex = 15;
            this.radioButton_Eingangsrechnung.TabStop = true;
            this.radioButton_Eingangsrechnung.Text = "Eingangsrechnung";
            this.radioButton_Eingangsrechnung.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ausgangsrechnung
            // 
            this.radioButton_Ausgangsrechnung.AutoSize = true;
            this.radioButton_Ausgangsrechnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Ausgangsrechnung.Location = new System.Drawing.Point(219, 295);
            this.radioButton_Ausgangsrechnung.Name = "radioButton_Ausgangsrechnung";
            this.radioButton_Ausgangsrechnung.Size = new System.Drawing.Size(130, 19);
            this.radioButton_Ausgangsrechnung.TabIndex = 14;
            this.radioButton_Ausgangsrechnung.TabStop = true;
            this.radioButton_Ausgangsrechnung.Text = "Ausgangsrechnung";
            this.radioButton_Ausgangsrechnung.UseVisualStyleBackColor = true;
            // 
            // comboBox_GruppenWahl
            // 
            this.comboBox_GruppenWahl.FormattingEnabled = true;
            this.comboBox_GruppenWahl.Location = new System.Drawing.Point(386, 166);
            this.comboBox_GruppenWahl.Name = "comboBox_GruppenWahl";
            this.comboBox_GruppenWahl.Size = new System.Drawing.Size(224, 21);
            this.comboBox_GruppenWahl.TabIndex = 13;
            // 
            // label_GruppenWahl
            // 
            this.label_GruppenWahl.AutoSize = true;
            this.label_GruppenWahl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GruppenWahl.Location = new System.Drawing.Point(383, 146);
            this.label_GruppenWahl.Name = "label_GruppenWahl";
            this.label_GruppenWahl.Size = new System.Drawing.Size(53, 17);
            this.label_GruppenWahl.TabIndex = 12;
            this.label_GruppenWahl.Text = "Gruppe";
            // 
            // label_Beschreibung
            // 
            this.label_Beschreibung.AutoSize = true;
            this.label_Beschreibung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Beschreibung.Location = new System.Drawing.Point(258, 27);
            this.label_Beschreibung.Name = "label_Beschreibung";
            this.label_Beschreibung.Size = new System.Drawing.Size(91, 17);
            this.label_Beschreibung.TabIndex = 11;
            this.label_Beschreibung.Text = "Beschreibung";
            // 
            // label_Betrag
            // 
            this.label_Betrag.AutoSize = true;
            this.label_Betrag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Betrag.Location = new System.Drawing.Point(16, 265);
            this.label_Betrag.Name = "label_Betrag";
            this.label_Betrag.Size = new System.Drawing.Size(48, 17);
            this.label_Betrag.TabIndex = 9;
            this.label_Betrag.Text = "Betrag";
            // 
            // input_Betrag
            // 
            this.input_Betrag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Betrag.Location = new System.Drawing.Point(19, 285);
            this.input_Betrag.Name = "input_Betrag";
            this.input_Betrag.Size = new System.Drawing.Size(173, 23);
            this.input_Betrag.TabIndex = 8;
            // 
            // label_USt
            // 
            this.label_USt.AutoSize = true;
            this.label_USt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_USt.Location = new System.Drawing.Point(16, 204);
            this.label_USt.Name = "label_USt";
            this.label_USt.Size = new System.Drawing.Size(29, 17);
            this.label_USt.TabIndex = 7;
            this.label_USt.Text = "USt";
            // 
            // label_Betriebsanteil
            // 
            this.label_Betriebsanteil.AutoSize = true;
            this.label_Betriebsanteil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Betriebsanteil.Location = new System.Drawing.Point(16, 146);
            this.label_Betriebsanteil.Name = "label_Betriebsanteil";
            this.label_Betriebsanteil.Size = new System.Drawing.Size(93, 17);
            this.label_Betriebsanteil.TabIndex = 5;
            this.label_Betriebsanteil.Text = "Betriebsanteil";
            // 
            // input_Betriebsanteil
            // 
            this.input_Betriebsanteil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Betriebsanteil.Location = new System.Drawing.Point(19, 166);
            this.input_Betriebsanteil.Name = "input_Betriebsanteil";
            this.input_Betriebsanteil.Size = new System.Drawing.Size(173, 23);
            this.input_Betriebsanteil.TabIndex = 4;
            // 
            // label_Buchungsdatum
            // 
            this.label_Buchungsdatum.AutoSize = true;
            this.label_Buchungsdatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buchungsdatum.Location = new System.Drawing.Point(16, 90);
            this.label_Buchungsdatum.Name = "label_Buchungsdatum";
            this.label_Buchungsdatum.Size = new System.Drawing.Size(108, 17);
            this.label_Buchungsdatum.TabIndex = 3;
            this.label_Buchungsdatum.Text = "Buchungsdatum";
            // 
            // dateTime_Buchungsdatum
            // 
            this.dateTime_Buchungsdatum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Buchungsdatum.Location = new System.Drawing.Point(19, 110);
            this.dateTime_Buchungsdatum.Name = "dateTime_Buchungsdatum";
            this.dateTime_Buchungsdatum.Size = new System.Drawing.Size(173, 23);
            this.dateTime_Buchungsdatum.TabIndex = 2;
            // 
            // label_Rechnungsdatum
            // 
            this.label_Rechnungsdatum.AutoSize = true;
            this.label_Rechnungsdatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rechnungsdatum.Location = new System.Drawing.Point(16, 27);
            this.label_Rechnungsdatum.Name = "label_Rechnungsdatum";
            this.label_Rechnungsdatum.Size = new System.Drawing.Size(115, 17);
            this.label_Rechnungsdatum.TabIndex = 1;
            this.label_Rechnungsdatum.Text = "Rechnungsdatum";
            // 
            // dateTime_Rechnungsdatum
            // 
            this.dateTime_Rechnungsdatum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Rechnungsdatum.Location = new System.Drawing.Point(19, 47);
            this.dateTime_Rechnungsdatum.Name = "dateTime_Rechnungsdatum";
            this.dateTime_Rechnungsdatum.Size = new System.Drawing.Size(173, 23);
            this.dateTime_Rechnungsdatum.TabIndex = 0;
            // 
            // FahrtenPage
            // 
            this.FahrtenPage.Location = new System.Drawing.Point(4, 22);
            this.FahrtenPage.Name = "FahrtenPage";
            this.FahrtenPage.Size = new System.Drawing.Size(630, 332);
            this.FahrtenPage.TabIndex = 2;
            this.FahrtenPage.Text = "Fahrten";
            this.FahrtenPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // comboBox_Beschreibung
            // 
            this.comboBox_Beschreibung.FormattingEnabled = true;
            this.comboBox_Beschreibung.Location = new System.Drawing.Point(261, 47);
            this.comboBox_Beschreibung.Name = "comboBox_Beschreibung";
            this.comboBox_Beschreibung.Size = new System.Drawing.Size(349, 21);
            this.comboBox_Beschreibung.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.ActivityPage.ResumeLayout(false);
            this.ActivityPage.PerformLayout();
            this.BuchungsPage.ResumeLayout(false);
            this.BuchungsPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage ActivityPage;
        private System.Windows.Forms.ListBox listBox_ActivityList;
        private System.Windows.Forms.Label label_Activities;
        private System.Windows.Forms.TabPage BuchungsPage;
        private System.Windows.Forms.Label label_Rechnungsdatum;
        private System.Windows.Forms.DateTimePicker dateTime_Rechnungsdatum;
        private System.Windows.Forms.TabPage FahrtenPage;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.Label label_Buchungsdatum;
        private System.Windows.Forms.DateTimePicker dateTime_Buchungsdatum;
        private System.Windows.Forms.Label label_Betriebsanteil;
        private System.Windows.Forms.TextBox input_Betriebsanteil;
        private System.Windows.Forms.Label label_USt;
        private System.Windows.Forms.Label label_Betrag;
        private System.Windows.Forms.TextBox input_Betrag;
        private System.Windows.Forms.Label label_Beschreibung;
        private System.Windows.Forms.ComboBox comboBox_GruppenWahl;
        private System.Windows.Forms.Label label_GruppenWahl;
        private System.Windows.Forms.RadioButton radioButton_Eingangsrechnung;
        private System.Windows.Forms.RadioButton radioButton_Ausgangsrechnung;
        private System.Windows.Forms.Button button_Book;
        private System.Windows.Forms.ComboBox comboBox_USt;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_Beschreibung;
    }
}