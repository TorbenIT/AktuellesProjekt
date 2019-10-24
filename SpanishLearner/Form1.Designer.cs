namespace SpanishLearner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allgemeinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDirection = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschSpanischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanischDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschPortugiesischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugiesischDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anleitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelVokabel = new System.Windows.Forms.Label();
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.listBoxVoices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSaveAudio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allgemeinToolStripMenuItem,
            this.MenuDirection,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allgemeinToolStripMenuItem
            // 
            this.allgemeinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testBeendenToolStripMenuItem,
            this.programmBeendenToolStripMenuItem});
            this.allgemeinToolStripMenuItem.Name = "allgemeinToolStripMenuItem";
            this.allgemeinToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.allgemeinToolStripMenuItem.Text = "Allgemein";
            // 
            // testBeendenToolStripMenuItem
            // 
            this.testBeendenToolStripMenuItem.Name = "testBeendenToolStripMenuItem";
            this.testBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testBeendenToolStripMenuItem.Text = "Test beenden";
            this.testBeendenToolStripMenuItem.Click += new System.EventHandler(this.testBeendenToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmBeendenToolStripMenuItem.Text = "Programm beenden";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // MenuDirection
            // 
            this.MenuDirection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschSpanischToolStripMenuItem,
            this.spanischDeutschToolStripMenuItem,
            this.deutschPortugiesischToolStripMenuItem,
            this.portugiesischDeutschToolStripMenuItem,
            this.deutschEnglishToolStripMenuItem,
            this.englishDeutschToolStripMenuItem});
            this.MenuDirection.Name = "MenuDirection";
            this.MenuDirection.Size = new System.Drawing.Size(67, 20);
            this.MenuDirection.Text = "Richtung";
            // 
            // deutschSpanischToolStripMenuItem
            // 
            this.deutschSpanischToolStripMenuItem.Name = "deutschSpanischToolStripMenuItem";
            this.deutschSpanischToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.deutschSpanischToolStripMenuItem.Text = "Deutsch - Spanisch";
            this.deutschSpanischToolStripMenuItem.Click += new System.EventHandler(this.deutschSpanischToolStripMenuItem_Click);
            // 
            // spanischDeutschToolStripMenuItem
            // 
            this.spanischDeutschToolStripMenuItem.Name = "spanischDeutschToolStripMenuItem";
            this.spanischDeutschToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.spanischDeutschToolStripMenuItem.Text = "Spanisch - Deutsch (Voreinstellung)";
            this.spanischDeutschToolStripMenuItem.Click += new System.EventHandler(this.spanischDeutschToolStripMenuItem_Click);
            // 
            // deutschPortugiesischToolStripMenuItem
            // 
            this.deutschPortugiesischToolStripMenuItem.Name = "deutschPortugiesischToolStripMenuItem";
            this.deutschPortugiesischToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.deutschPortugiesischToolStripMenuItem.Text = "Deutsch - Portugiesisch";
            this.deutschPortugiesischToolStripMenuItem.Click += new System.EventHandler(this.deutschPortugiesischToolStripMenuItem_Click_1);
            // 
            // portugiesischDeutschToolStripMenuItem
            // 
            this.portugiesischDeutschToolStripMenuItem.Name = "portugiesischDeutschToolStripMenuItem";
            this.portugiesischDeutschToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.portugiesischDeutschToolStripMenuItem.Text = "Portugiesisch - Deutsch";
            this.portugiesischDeutschToolStripMenuItem.Click += new System.EventHandler(this.portugiesischDeutschToolStripMenuItem_Click_1);
            // 
            // deutschEnglishToolStripMenuItem
            // 
            this.deutschEnglishToolStripMenuItem.Name = "deutschEnglishToolStripMenuItem";
            this.deutschEnglishToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.deutschEnglishToolStripMenuItem.Text = "Deutsch - English";
            this.deutschEnglishToolStripMenuItem.Click += new System.EventHandler(this.deutschEnglishToolStripMenuItem_Click);
            // 
            // englishDeutschToolStripMenuItem
            // 
            this.englishDeutschToolStripMenuItem.Name = "englishDeutschToolStripMenuItem";
            this.englishDeutschToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.englishDeutschToolStripMenuItem.Text = "English - Deutsch";
            this.englishDeutschToolStripMenuItem.Click += new System.EventHandler(this.englishDeutschToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anleitungToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // anleitungToolStripMenuItem
            // 
            this.anleitungToolStripMenuItem.Name = "anleitungToolStripMenuItem";
            this.anleitungToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.anleitungToolStripMenuItem.Text = "Anleitung";
            this.anleitungToolStripMenuItem.Click += new System.EventHandler(this.anleitungToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(31, 330);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Test starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(31, 368);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(104, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Prüfen / Nächster";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelVokabel
            // 
            this.labelVokabel.AutoSize = true;
            this.labelVokabel.Location = new System.Drawing.Point(182, 335);
            this.labelVokabel.Name = "labelVokabel";
            this.labelVokabel.Size = new System.Drawing.Size(0, 13);
            this.labelVokabel.TabIndex = 3;
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Enabled = false;
            this.textBoxEingabe.Location = new System.Drawing.Point(171, 370);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(100, 20);
            this.textBoxEingabe.TabIndex = 4;
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(28, 296);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(101, 13);
            this.labelAnzeige.TabIndex = 5;
            this.labelAnzeige.Text = "spanisch / deutsch ";
            // 
            // listBoxVoices
            // 
            this.listBoxVoices.FormattingEnabled = true;
            this.listBoxVoices.Location = new System.Drawing.Point(656, 77);
            this.listBoxVoices.Name = "listBoxVoices";
            this.listBoxVoices.Size = new System.Drawing.Size(120, 95);
            this.listBoxVoices.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Installierte Stimmen für die Sprachausgabe:";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(505, 314);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(105, 23);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Sprachaufnahme";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(505, 353);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Sprachausgabe";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnSaveAudio
            // 
            this.btnSaveAudio.Location = new System.Drawing.Point(646, 303);
            this.btnSaveAudio.Name = "btnSaveAudio";
            this.btnSaveAudio.Size = new System.Drawing.Size(116, 34);
            this.btnSaveAudio.TabIndex = 10;
            this.btnSaveAudio.Text = "Aufnahme speichern";
            this.btnSaveAudio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveAudio);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVoices);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.textBoxEingabe);
            this.Controls.Add(this.labelVokabel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VokabelTrainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allgemeinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDirection;
        private System.Windows.Forms.ToolStripMenuItem deutschSpanischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanischDeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschPortugiesischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugiesischDeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anleitungToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelVokabel;
        private System.Windows.Forms.TextBox textBoxEingabe;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.ToolStripMenuItem deutschEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishDeutschToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxVoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSaveAudio;
    }
}

