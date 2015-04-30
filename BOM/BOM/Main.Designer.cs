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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.ActivityPage = new System.Windows.Forms.TabPage();
            this.BuchungsPage = new System.Windows.Forms.TabPage();
            this.FahrtenPage = new System.Windows.Forms.TabPage();
            this.ListBox_ActivityList = new System.Windows.Forms.ListBox();
            this.Label_Activities = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.ActivityPage.SuspendLayout();
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
            this.ActivityPage.Controls.Add(this.Label_Activities);
            this.ActivityPage.Controls.Add(this.ListBox_ActivityList);
            this.ActivityPage.Location = new System.Drawing.Point(4, 22);
            this.ActivityPage.Name = "ActivityPage";
            this.ActivityPage.Size = new System.Drawing.Size(690, 310);
            this.ActivityPage.TabIndex = 0;
            this.ActivityPage.Text = "Aktivitaeten";
            this.ActivityPage.UseVisualStyleBackColor = true;
            // 
            // BuchungsPage
            // 
            this.BuchungsPage.Location = new System.Drawing.Point(4, 22);
            this.BuchungsPage.Name = "BuchungsPage";
            this.BuchungsPage.Size = new System.Drawing.Size(690, 310);
            this.BuchungsPage.TabIndex = 1;
            this.BuchungsPage.Text = "Buchungen";
            this.BuchungsPage.UseVisualStyleBackColor = true;
            // 
            // FahrtenPage
            // 
            this.FahrtenPage.Location = new System.Drawing.Point(4, 22);
            this.FahrtenPage.Name = "FahrtenPage";
            this.FahrtenPage.Size = new System.Drawing.Size(690, 310);
            this.FahrtenPage.TabIndex = 2;
            this.FahrtenPage.Text = "Fahrten";
            this.FahrtenPage.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ActivityPage.ResumeLayout(false);
            this.ActivityPage.PerformLayout();
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
    }
}