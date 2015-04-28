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
            this.label_Topic = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Forward = new System.Windows.Forms.Button();
            this.listView_ActivityList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
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
            // label_Topic
            // 
            this.label_Topic.AutoSize = true;
            this.label_Topic.Font = new System.Drawing.Font("Segoe UI Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Topic.Location = new System.Drawing.Point(77, 25);
            this.label_Topic.Name = "label_Topic";
            this.label_Topic.Size = new System.Drawing.Size(183, 45);
            this.label_Topic.TabIndex = 1;
            this.label_Topic.Text = "Aktivitaeten";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 27);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(60, 40);
            this.button_Back.TabIndex = 3;
            this.button_Back.Text = "<--";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Forward
            // 
            this.button_Forward.Location = new System.Drawing.Point(626, 30);
            this.button_Forward.Name = "button_Forward";
            this.button_Forward.Size = new System.Drawing.Size(60, 40);
            this.button_Forward.TabIndex = 4;
            this.button_Forward.Text = "-->";
            this.button_Forward.UseVisualStyleBackColor = true;
            this.button_Forward.Click += new System.EventHandler(this.button_Forward_Click);
            // 
            // listView_ActivityList
            // 
            this.listView_ActivityList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ActivityList.FormattingEnabled = true;
            this.listView_ActivityList.ItemHeight = 21;
            this.listView_ActivityList.Location = new System.Drawing.Point(12, 74);
            this.listView_ActivityList.Name = "listView_ActivityList";
            this.listView_ActivityList.Size = new System.Drawing.Size(674, 277);
            this.listView_ActivityList.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.listView_ActivityList);
            this.Controls.Add(this.button_Forward);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_Topic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.Label label_Topic;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Forward;
        private System.Windows.Forms.ListBox listView_ActivityList;
    }
}