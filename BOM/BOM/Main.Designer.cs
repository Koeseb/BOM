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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.ActivityPage = new System.Windows.Forms.TabPage();
            this.Label_Activities = new System.Windows.Forms.Label();
            this.ListBox_ActivityList = new System.Windows.Forms.ListBox();
            this.BuchungsPage = new System.Windows.Forms.TabPage();
            this.comboBox_USt = new System.Windows.Forms.ComboBox();
            this.button_Book = new System.Windows.Forms.Button();
            this.input_Beschreibung = new System.Windows.Forms.TextBox();
            this.label_USt = new System.Windows.Forms.Label();
            this.input_Betriebsanteil = new System.Windows.Forms.TextBox();
            this.label_Betriebsanteil = new System.Windows.Forms.Label();
            this.dateTime_Buchungsdatum = new System.Windows.Forms.DateTimePicker();
            this.label_Buchungsdatum = new System.Windows.Forms.Label();
            this.label_Rechnungsdatum = new System.Windows.Forms.Label();
            this.dateTime_Rechnungsdatum = new System.Windows.Forms.DateTimePicker();
            this.FahrtenPage = new System.Windows.Forms.TabPage();
            this.Label_Endkilometerstand = new System.Windows.Forms.Label();
            this.TextBox_Endkilometerstand = new System.Windows.Forms.TextBox();
            this.TextBox_Anfangskilometerstand = new System.Windows.Forms.TextBox();
            this.Label_Anfangskilometerstand = new System.Windows.Forms.Label();
            this.Label_DatumAbfahrt = new System.Windows.Forms.Label();
            this.DateTime_Abfahrt = new System.Windows.Forms.DateTimePicker();
            this.dbDataSet = new BOM.dbDataSet();
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter = new BOM.dbDataSetTableAdapters.LogTableAdapter();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.ActivityPage.SuspendLayout();
            this.BuchungsPage.SuspendLayout();
            this.FahrtenPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
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
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ActivityPage);
            this.mainTabControl.Controls.Add(this.BuchungsPage);
            this.mainTabControl.Controls.Add(this.FahrtenPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(698, 336);
            this.mainTabControl.TabIndex = 6;
            // 
            // ActivityPage
            // 
            this.ActivityPage.Controls.Add(this.button_Refresh);
            this.ActivityPage.Controls.Add(this.Label_Activities);
            this.ActivityPage.Controls.Add(this.ListBox_ActivityList);
            this.ActivityPage.Location = new System.Drawing.Point(4, 22);
            this.ActivityPage.Name = "ActivityPage";
            this.ActivityPage.Size = new System.Drawing.Size(690, 310);
            this.ActivityPage.TabIndex = 0;
            this.ActivityPage.Text = "Aktivitaeten";
            this.ActivityPage.UseVisualStyleBackColor = true;
            // 
            // Label_Activities
            // 
            this.Label_Activities.AutoSize = true;
            this.Label_Activities.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Activities.Location = new System.Drawing.Point(8, 9);
            this.Label_Activities.Name = "Label_Activities";
            this.Label_Activities.Size = new System.Drawing.Size(149, 37);
            this.Label_Activities.TabIndex = 1;
            this.Label_Activities.Text = "Aktivitaeten";
            // 
            // ListBox_ActivityList
            // 
            this.ListBox_ActivityList.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.ListBox_ActivityList.FormattingEnabled = true;
            this.ListBox_ActivityList.ItemHeight = 21;
            this.ListBox_ActivityList.Location = new System.Drawing.Point(3, 58);
            this.ListBox_ActivityList.Name = "ListBox_ActivityList";
            this.ListBox_ActivityList.Size = new System.Drawing.Size(684, 235);
            this.ListBox_ActivityList.TabIndex = 0;
            // 
            // BuchungsPage
            // 
            this.BuchungsPage.Controls.Add(this.comboBox_USt);
            this.BuchungsPage.Controls.Add(this.button_Book);
            this.BuchungsPage.Controls.Add(this.input_Beschreibung);
            this.BuchungsPage.Controls.Add(this.label_USt);
            this.BuchungsPage.Controls.Add(this.input_Betriebsanteil);
            this.BuchungsPage.Controls.Add(this.label_Betriebsanteil);
            this.BuchungsPage.Controls.Add(this.dateTime_Buchungsdatum);
            this.BuchungsPage.Controls.Add(this.label_Buchungsdatum);
            this.BuchungsPage.Controls.Add(this.label_Rechnungsdatum);
            this.BuchungsPage.Controls.Add(this.dateTime_Rechnungsdatum);
            this.BuchungsPage.Location = new System.Drawing.Point(4, 22);
            this.BuchungsPage.Name = "BuchungsPage";
            this.BuchungsPage.Size = new System.Drawing.Size(690, 310);
            this.BuchungsPage.TabIndex = 1;
            this.BuchungsPage.Text = "Buchungen";
            this.BuchungsPage.UseVisualStyleBackColor = true;
            // 
            // comboBox_USt
            // 
            this.comboBox_USt.FormattingEnabled = true;
            this.comboBox_USt.Location = new System.Drawing.Point(17, 207);
            this.comboBox_USt.Name = "comboBox_USt";
            this.comboBox_USt.Size = new System.Drawing.Size(200, 21);
            this.comboBox_USt.TabIndex = 10;
            // 
            // button_Book
            // 
            this.button_Book.Location = new System.Drawing.Point(585, 206);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(75, 23);
            this.button_Book.TabIndex = 9;
            this.button_Book.Text = "Buchen";
            this.button_Book.UseVisualStyleBackColor = true;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // input_Beschreibung
            // 
            this.input_Beschreibung.Location = new System.Drawing.Point(308, 41);
            this.input_Beschreibung.Multiline = true;
            this.input_Beschreibung.Name = "input_Beschreibung";
            this.input_Beschreibung.Size = new System.Drawing.Size(352, 131);
            this.input_Beschreibung.TabIndex = 8;
            // 
            // label_USt
            // 
            this.label_USt.AutoSize = true;
            this.label_USt.Location = new System.Drawing.Point(14, 190);
            this.label_USt.Name = "label_USt";
            this.label_USt.Size = new System.Drawing.Size(25, 13);
            this.label_USt.TabIndex = 6;
            this.label_USt.Text = "USt";
            // 
            // input_Betriebsanteil
            // 
            this.input_Betriebsanteil.Location = new System.Drawing.Point(17, 152);
            this.input_Betriebsanteil.Name = "input_Betriebsanteil";
            this.input_Betriebsanteil.Size = new System.Drawing.Size(200, 20);
            this.input_Betriebsanteil.TabIndex = 5;
            // 
            // label_Betriebsanteil
            // 
            this.label_Betriebsanteil.AutoSize = true;
            this.label_Betriebsanteil.Location = new System.Drawing.Point(14, 136);
            this.label_Betriebsanteil.Name = "label_Betriebsanteil";
            this.label_Betriebsanteil.Size = new System.Drawing.Size(70, 13);
            this.label_Betriebsanteil.TabIndex = 4;
            this.label_Betriebsanteil.Text = "Betriebsanteil";
            // 
            // dateTime_Buchungsdatum
            // 
            this.dateTime_Buchungsdatum.Location = new System.Drawing.Point(17, 97);
            this.dateTime_Buchungsdatum.Name = "dateTime_Buchungsdatum";
            this.dateTime_Buchungsdatum.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Buchungsdatum.TabIndex = 3;
            // 
            // label_Buchungsdatum
            // 
            this.label_Buchungsdatum.AutoSize = true;
            this.label_Buchungsdatum.Location = new System.Drawing.Point(14, 81);
            this.label_Buchungsdatum.Name = "label_Buchungsdatum";
            this.label_Buchungsdatum.Size = new System.Drawing.Size(84, 13);
            this.label_Buchungsdatum.TabIndex = 2;
            this.label_Buchungsdatum.Text = "Buchungsdatum";
            // 
            // label_Rechnungsdatum
            // 
            this.label_Rechnungsdatum.AutoSize = true;
            this.label_Rechnungsdatum.Location = new System.Drawing.Point(14, 25);
            this.label_Rechnungsdatum.Name = "label_Rechnungsdatum";
            this.label_Rechnungsdatum.Size = new System.Drawing.Size(91, 13);
            this.label_Rechnungsdatum.TabIndex = 1;
            this.label_Rechnungsdatum.Text = "Rechnungsdatum";
            // 
            // dateTime_Rechnungsdatum
            // 
            this.dateTime_Rechnungsdatum.Location = new System.Drawing.Point(17, 41);
            this.dateTime_Rechnungsdatum.Name = "dateTime_Rechnungsdatum";
            this.dateTime_Rechnungsdatum.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Rechnungsdatum.TabIndex = 0;
            // 
            // FahrtenPage
            // 
            this.FahrtenPage.Controls.Add(this.Label_Endkilometerstand);
            this.FahrtenPage.Controls.Add(this.TextBox_Endkilometerstand);
            this.FahrtenPage.Controls.Add(this.TextBox_Anfangskilometerstand);
            this.FahrtenPage.Controls.Add(this.Label_Anfangskilometerstand);
            this.FahrtenPage.Controls.Add(this.Label_DatumAbfahrt);
            this.FahrtenPage.Controls.Add(this.DateTime_Abfahrt);
            this.FahrtenPage.Location = new System.Drawing.Point(4, 22);
            this.FahrtenPage.Name = "FahrtenPage";
            this.FahrtenPage.Size = new System.Drawing.Size(690, 310);
            this.FahrtenPage.TabIndex = 2;
            this.FahrtenPage.Text = "Fahrten";
            this.FahrtenPage.UseVisualStyleBackColor = true;
            // 
            // Label_Endkilometerstand
            // 
            this.Label_Endkilometerstand.AutoSize = true;
            this.Label_Endkilometerstand.Location = new System.Drawing.Point(21, 146);
            this.Label_Endkilometerstand.Name = "Label_Endkilometerstand";
            this.Label_Endkilometerstand.Size = new System.Drawing.Size(94, 13);
            this.Label_Endkilometerstand.TabIndex = 5;
            this.Label_Endkilometerstand.Text = "Endkilometerstand";
            // 
            // TextBox_Endkilometerstand
            // 
            this.TextBox_Endkilometerstand.Location = new System.Drawing.Point(24, 162);
            this.TextBox_Endkilometerstand.Name = "TextBox_Endkilometerstand";
            this.TextBox_Endkilometerstand.Size = new System.Drawing.Size(200, 20);
            this.TextBox_Endkilometerstand.TabIndex = 4;
            // 
            // TextBox_Anfangskilometerstand
            // 
            this.TextBox_Anfangskilometerstand.Location = new System.Drawing.Point(24, 103);
            this.TextBox_Anfangskilometerstand.Name = "TextBox_Anfangskilometerstand";
            this.TextBox_Anfangskilometerstand.Size = new System.Drawing.Size(200, 20);
            this.TextBox_Anfangskilometerstand.TabIndex = 3;
            // 
            // Label_Anfangskilometerstand
            // 
            this.Label_Anfangskilometerstand.AutoSize = true;
            this.Label_Anfangskilometerstand.Location = new System.Drawing.Point(21, 87);
            this.Label_Anfangskilometerstand.Name = "Label_Anfangskilometerstand";
            this.Label_Anfangskilometerstand.Size = new System.Drawing.Size(114, 13);
            this.Label_Anfangskilometerstand.TabIndex = 2;
            this.Label_Anfangskilometerstand.Text = "Anfangskilometerstand";
            // 
            // Label_DatumAbfahrt
            // 
            this.Label_DatumAbfahrt.AutoSize = true;
            this.Label_DatumAbfahrt.Location = new System.Drawing.Point(21, 29);
            this.Label_DatumAbfahrt.Name = "Label_DatumAbfahrt";
            this.Label_DatumAbfahrt.Size = new System.Drawing.Size(93, 13);
            this.Label_DatumAbfahrt.TabIndex = 1;
            this.Label_DatumAbfahrt.Text = "Datum der Abfahrt";
            // 
            // DateTime_Abfahrt
            // 
            this.DateTime_Abfahrt.Location = new System.Drawing.Point(24, 45);
            this.DateTime_Abfahrt.Name = "DateTime_Abfahrt";
            this.DateTime_Abfahrt.Size = new System.Drawing.Size(200, 20);
            this.DateTime_Abfahrt.TabIndex = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDataSetBindingSource
            // 
            this.dbDataSetBindingSource.DataSource = this.dbDataSet;
            this.dbDataSetBindingSource.Position = 0;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            this.logBindingSource.DataSource = this.dbDataSetBindingSource;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(628, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(54, 37);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ActivityPage.ResumeLayout(false);
            this.ActivityPage.PerformLayout();
            this.BuchungsPage.ResumeLayout(false);
            this.BuchungsPage.PerformLayout();
            this.FahrtenPage.ResumeLayout(false);
            this.FahrtenPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage ActivityPage;
        private System.Windows.Forms.TabPage BuchungsPage;
        private System.Windows.Forms.TabPage FahrtenPage;
        private System.Windows.Forms.ListBox ListBox_ActivityList;
        private System.Windows.Forms.Label Label_Activities;
        private System.Windows.Forms.Label label_USt;
        private System.Windows.Forms.TextBox input_Betriebsanteil;
        private System.Windows.Forms.Label label_Betriebsanteil;
        private System.Windows.Forms.DateTimePicker dateTime_Buchungsdatum;
        private System.Windows.Forms.Label label_Buchungsdatum;
        private System.Windows.Forms.Label label_Rechnungsdatum;
        private System.Windows.Forms.DateTimePicker dateTime_Rechnungsdatum;
        private System.Windows.Forms.Label Label_DatumAbfahrt;
        private System.Windows.Forms.DateTimePicker DateTime_Abfahrt;
        private System.Windows.Forms.Label Label_Endkilometerstand;
        private System.Windows.Forms.TextBox TextBox_Endkilometerstand;
        private System.Windows.Forms.TextBox TextBox_Anfangskilometerstand;
        private System.Windows.Forms.Label Label_Anfangskilometerstand;
        private System.Windows.Forms.TextBox input_Beschreibung;
        private System.Windows.Forms.Button button_Book;
        private System.Windows.Forms.ComboBox comboBox_USt;
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource logBindingSource;
        private dbDataSetTableAdapters.LogTableAdapter logTableAdapter;
        private System.Windows.Forms.Button button_Refresh;
    }
}