
namespace BitBurnerSaveEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSep01 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabStats = new System.Windows.Forms.TabPage();
            this.TextMoney = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TextIntExp = new System.Windows.Forms.TextBox();
            this.TextInt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextChaExp = new System.Windows.Forms.TextBox();
            this.TextCha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TextAgiExp = new System.Windows.Forms.TextBox();
            this.TextAgi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextDexExp = new System.Windows.Forms.TextBox();
            this.TextDex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextDefExp = new System.Windows.Forms.TextBox();
            this.TextDef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextStrExp = new System.Windows.Forms.TextBox();
            this.TextStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextHackExp = new System.Windows.Forms.TextBox();
            this.TextHack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabFactions = new System.Windows.Forms.TabPage();
            this.DgvFactionsView = new System.Windows.Forms.DataGridView();
            this.ColumnFactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsMember = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnReputation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnBanned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabRawView = new System.Windows.Forms.TabPage();
            this.TextRaw = new System.Windows.Forms.TextBox();
            this.MenuStripMain.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.TabStats.SuspendLayout();
            this.TabFactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactionsView)).BeginInit();
            this.TabRawView.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(847, 24);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "MenuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen,
            this.MenuFileSave,
            this.MenuFileSaveAs,
            this.MenuFileClose,
            this.MenuFileSep01,
            this.MenuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuFileOpen.Size = new System.Drawing.Size(155, 22);
            this.MenuFileOpen.Text = "&Open...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuFileSave.Size = new System.Drawing.Size(155, 22);
            this.MenuFileSave.Text = "&Save";
            this.MenuFileSave.Click += new System.EventHandler(this.MenuFileSave_Click);
            // 
            // MenuFileSaveAs
            // 
            this.MenuFileSaveAs.Name = "MenuFileSaveAs";
            this.MenuFileSaveAs.Size = new System.Drawing.Size(155, 22);
            this.MenuFileSaveAs.Text = "Save As...";
            this.MenuFileSaveAs.Click += new System.EventHandler(this.MenuFileSaveAs_Click);
            // 
            // MenuFileClose
            // 
            this.MenuFileClose.Name = "MenuFileClose";
            this.MenuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.MenuFileClose.Size = new System.Drawing.Size(155, 22);
            this.MenuFileClose.Text = "&Close";
            this.MenuFileClose.Click += new System.EventHandler(this.MenuFileClose_Click);
            // 
            // MenuFileSep01
            // 
            this.MenuFileSep01.Name = "MenuFileSep01";
            this.MenuFileSep01.Size = new System.Drawing.Size(152, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuFileExit.Size = new System.Drawing.Size(155, 22);
            this.MenuFileExit.Text = "E&xit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabStats);
            this.TabControlMain.Controls.Add(this.TabFactions);
            this.TabControlMain.Controls.Add(this.TabRawView);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 24);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(847, 471);
            this.TabControlMain.TabIndex = 1;
            // 
            // TabStats
            // 
            this.TabStats.Controls.Add(this.TextMoney);
            this.TabStats.Controls.Add(this.label16);
            this.TabStats.Controls.Add(this.TextIntExp);
            this.TabStats.Controls.Add(this.TextInt);
            this.TabStats.Controls.Add(this.label13);
            this.TabStats.Controls.Add(this.label14);
            this.TabStats.Controls.Add(this.TextChaExp);
            this.TabStats.Controls.Add(this.TextCha);
            this.TabStats.Controls.Add(this.label11);
            this.TabStats.Controls.Add(this.label12);
            this.TabStats.Controls.Add(this.TextAgiExp);
            this.TabStats.Controls.Add(this.TextAgi);
            this.TabStats.Controls.Add(this.label9);
            this.TabStats.Controls.Add(this.label10);
            this.TabStats.Controls.Add(this.TextDexExp);
            this.TabStats.Controls.Add(this.TextDex);
            this.TabStats.Controls.Add(this.label7);
            this.TabStats.Controls.Add(this.label8);
            this.TabStats.Controls.Add(this.TextDefExp);
            this.TabStats.Controls.Add(this.TextDef);
            this.TabStats.Controls.Add(this.label5);
            this.TabStats.Controls.Add(this.label6);
            this.TabStats.Controls.Add(this.TextStrExp);
            this.TabStats.Controls.Add(this.TextStr);
            this.TabStats.Controls.Add(this.label3);
            this.TabStats.Controls.Add(this.label4);
            this.TabStats.Controls.Add(this.TextHackExp);
            this.TabStats.Controls.Add(this.TextHack);
            this.TabStats.Controls.Add(this.label2);
            this.TabStats.Controls.Add(this.label1);
            this.TabStats.Location = new System.Drawing.Point(4, 24);
            this.TabStats.Name = "TabStats";
            this.TabStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabStats.Size = new System.Drawing.Size(839, 443);
            this.TabStats.TabIndex = 0;
            this.TabStats.Text = "Stats";
            this.TabStats.UseVisualStyleBackColor = true;
            // 
            // TextMoney
            // 
            this.TextMoney.Location = new System.Drawing.Point(296, 35);
            this.TextMoney.Name = "TextMoney";
            this.TextMoney.Size = new System.Drawing.Size(100, 23);
            this.TextMoney.TabIndex = 30;
            this.TextMoney.Tag = "money";
            this.TextMoney.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(296, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "MONEY";
            // 
            // TextIntExp
            // 
            this.TextIntExp.Location = new System.Drawing.Point(417, 85);
            this.TextIntExp.Name = "TextIntExp";
            this.TextIntExp.Size = new System.Drawing.Size(100, 23);
            this.TextIntExp.TabIndex = 27;
            this.TextIntExp.Tag = "intelligence_exp";
            this.TextIntExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextInt
            // 
            this.TextInt.Location = new System.Drawing.Point(296, 85);
            this.TextInt.Name = "TextInt";
            this.TextInt.Size = new System.Drawing.Size(100, 23);
            this.TextInt.TabIndex = 26;
            this.TextInt.Tag = "intelligence";
            this.TextInt.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "INT EXP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(296, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "INT";
            // 
            // TextChaExp
            // 
            this.TextChaExp.Location = new System.Drawing.Point(140, 314);
            this.TextChaExp.Name = "TextChaExp";
            this.TextChaExp.Size = new System.Drawing.Size(100, 23);
            this.TextChaExp.TabIndex = 23;
            this.TextChaExp.Tag = "charisma_exp";
            this.TextChaExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextCha
            // 
            this.TextCha.Location = new System.Drawing.Point(19, 314);
            this.TextCha.Name = "TextCha";
            this.TextCha.Size = new System.Drawing.Size(100, 23);
            this.TextCha.TabIndex = 22;
            this.TextCha.Tag = "charisma";
            this.TextCha.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "CHA EXP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "CHA";
            // 
            // TextAgiExp
            // 
            this.TextAgiExp.Location = new System.Drawing.Point(140, 254);
            this.TextAgiExp.Name = "TextAgiExp";
            this.TextAgiExp.Size = new System.Drawing.Size(100, 23);
            this.TextAgiExp.TabIndex = 19;
            this.TextAgiExp.Tag = "agility_exp";
            this.TextAgiExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextAgi
            // 
            this.TextAgi.Location = new System.Drawing.Point(19, 254);
            this.TextAgi.Name = "TextAgi";
            this.TextAgi.Size = new System.Drawing.Size(100, 23);
            this.TextAgi.TabIndex = 18;
            this.TextAgi.Tag = "agility";
            this.TextAgi.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "AGI EXP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "AGI";
            // 
            // TextDexExp
            // 
            this.TextDexExp.Location = new System.Drawing.Point(140, 196);
            this.TextDexExp.Name = "TextDexExp";
            this.TextDexExp.Size = new System.Drawing.Size(100, 23);
            this.TextDexExp.TabIndex = 15;
            this.TextDexExp.Tag = "dexterity_exp";
            this.TextDexExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextDex
            // 
            this.TextDex.Location = new System.Drawing.Point(19, 196);
            this.TextDex.Name = "TextDex";
            this.TextDex.Size = new System.Drawing.Size(100, 23);
            this.TextDex.TabIndex = 14;
            this.TextDex.Tag = "dexterity";
            this.TextDex.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "DEX EXP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "DEX";
            // 
            // TextDefExp
            // 
            this.TextDefExp.Location = new System.Drawing.Point(140, 140);
            this.TextDefExp.Name = "TextDefExp";
            this.TextDefExp.Size = new System.Drawing.Size(100, 23);
            this.TextDefExp.TabIndex = 11;
            this.TextDefExp.Tag = "defense_exp";
            this.TextDefExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextDef
            // 
            this.TextDef.Location = new System.Drawing.Point(19, 140);
            this.TextDef.Name = "TextDef";
            this.TextDef.Size = new System.Drawing.Size(100, 23);
            this.TextDef.TabIndex = 10;
            this.TextDef.Tag = "defense";
            this.TextDef.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DEF EXP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "DEF";
            // 
            // TextStrExp
            // 
            this.TextStrExp.Location = new System.Drawing.Point(140, 85);
            this.TextStrExp.Name = "TextStrExp";
            this.TextStrExp.Size = new System.Drawing.Size(100, 23);
            this.TextStrExp.TabIndex = 7;
            this.TextStrExp.Tag = "strength_exp";
            this.TextStrExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextStr
            // 
            this.TextStr.Location = new System.Drawing.Point(19, 85);
            this.TextStr.Name = "TextStr";
            this.TextStr.Size = new System.Drawing.Size(100, 23);
            this.TextStr.TabIndex = 6;
            this.TextStr.Tag = "strength";
            this.TextStr.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "STR EXP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "STR";
            // 
            // TextHackExp
            // 
            this.TextHackExp.Location = new System.Drawing.Point(140, 35);
            this.TextHackExp.Name = "TextHackExp";
            this.TextHackExp.Size = new System.Drawing.Size(100, 23);
            this.TextHackExp.TabIndex = 3;
            this.TextHackExp.Tag = "hacking_exp";
            this.TextHackExp.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // TextHack
            // 
            this.TextHack.Location = new System.Drawing.Point(19, 35);
            this.TextHack.Name = "TextHack";
            this.TextHack.Size = new System.Drawing.Size(100, 23);
            this.TextHack.TabIndex = 2;
            this.TextHack.Tag = "hacking";
            this.TextHack.TextChanged += new System.EventHandler(this.Stats_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "HACK EXP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hack";
            // 
            // TabFactions
            // 
            this.TabFactions.Controls.Add(this.DgvFactionsView);
            this.TabFactions.Location = new System.Drawing.Point(4, 24);
            this.TabFactions.Name = "TabFactions";
            this.TabFactions.Padding = new System.Windows.Forms.Padding(3);
            this.TabFactions.Size = new System.Drawing.Size(839, 443);
            this.TabFactions.TabIndex = 1;
            this.TabFactions.Text = "Factions";
            this.TabFactions.UseVisualStyleBackColor = true;
            // 
            // DgvFactionsView
            // 
            this.DgvFactionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactionsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFactionName,
            this.ColumnIsMember,
            this.ColumnReputation,
            this.ColumnFavor,
            this.ColumnInvited,
            this.ColumnBanned});
            this.DgvFactionsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFactionsView.Location = new System.Drawing.Point(3, 3);
            this.DgvFactionsView.Name = "DgvFactionsView";
            this.DgvFactionsView.RowHeadersVisible = false;
            this.DgvFactionsView.RowTemplate.Height = 25;
            this.DgvFactionsView.Size = new System.Drawing.Size(833, 437);
            this.DgvFactionsView.TabIndex = 0;
            this.DgvFactionsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFactionsView_CellValueChanged);
            // 
            // ColumnFactionName
            // 
            this.ColumnFactionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFactionName.DataPropertyName = "Name";
            this.ColumnFactionName.HeaderText = "Faction";
            this.ColumnFactionName.MinimumWidth = 50;
            this.ColumnFactionName.Name = "ColumnFactionName";
            this.ColumnFactionName.ReadOnly = true;
            // 
            // ColumnIsMember
            // 
            this.ColumnIsMember.DataPropertyName = "IsMember";
            this.ColumnIsMember.FalseValue = "false";
            this.ColumnIsMember.HeaderText = "Is Member";
            this.ColumnIsMember.IndeterminateValue = "false";
            this.ColumnIsMember.Name = "ColumnIsMember";
            this.ColumnIsMember.TrueValue = "true";
            // 
            // ColumnReputation
            // 
            this.ColumnReputation.DataPropertyName = "Reputation";
            this.ColumnReputation.HeaderText = "Reputation";
            this.ColumnReputation.MinimumWidth = 50;
            this.ColumnReputation.Name = "ColumnReputation";
            this.ColumnReputation.Width = 200;
            // 
            // ColumnFavor
            // 
            this.ColumnFavor.DataPropertyName = "Favor";
            this.ColumnFavor.HeaderText = "Favor";
            this.ColumnFavor.Name = "ColumnFavor";
            // 
            // ColumnInvited
            // 
            this.ColumnInvited.DataPropertyName = "Invited";
            this.ColumnInvited.FalseValue = "false";
            this.ColumnInvited.HeaderText = "Invited";
            this.ColumnInvited.IndeterminateValue = "false";
            this.ColumnInvited.Name = "ColumnInvited";
            this.ColumnInvited.TrueValue = "true";
            // 
            // ColumnBanned
            // 
            this.ColumnBanned.DataPropertyName = "Banned";
            this.ColumnBanned.FalseValue = "false";
            this.ColumnBanned.HeaderText = "Banned";
            this.ColumnBanned.IndeterminateValue = "false";
            this.ColumnBanned.Name = "ColumnBanned";
            this.ColumnBanned.TrueValue = "true";
            // 
            // TabRawView
            // 
            this.TabRawView.Controls.Add(this.TextRaw);
            this.TabRawView.Location = new System.Drawing.Point(4, 24);
            this.TabRawView.Name = "TabRawView";
            this.TabRawView.Size = new System.Drawing.Size(839, 443);
            this.TabRawView.TabIndex = 2;
            this.TabRawView.Text = "Raw View";
            this.TabRawView.UseVisualStyleBackColor = true;
            // 
            // TextRaw
            // 
            this.TextRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRaw.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextRaw.Location = new System.Drawing.Point(0, 0);
            this.TextRaw.Multiline = true;
            this.TextRaw.Name = "TextRaw";
            this.TextRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextRaw.Size = new System.Drawing.Size(839, 443);
            this.TextRaw.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 495);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "MainForm";
            this.Text = "BitBurner Savegame Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.TabControlMain.ResumeLayout(false);
            this.TabStats.ResumeLayout(false);
            this.TabStats.PerformLayout();
            this.TabFactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactionsView)).EndInit();
            this.TabRawView.ResumeLayout(false);
            this.TabRawView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuFileClose;
        private System.Windows.Forms.ToolStripSeparator MenuFileSep01;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabStats;
        private System.Windows.Forms.TabPage TabFactions;
        private System.Windows.Forms.TabPage TabRawView;
        private System.Windows.Forms.TextBox TextHackExp;
        private System.Windows.Forms.TextBox TextHack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextRaw;
        private System.Windows.Forms.TextBox TextMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TextIntExp;
        private System.Windows.Forms.TextBox TextInt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextChaExp;
        private System.Windows.Forms.TextBox TextCha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextAgiExp;
        private System.Windows.Forms.TextBox TextAgi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextDexExp;
        private System.Windows.Forms.TextBox TextDex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextDefExp;
        private System.Windows.Forms.TextBox TextDef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextStrExp;
        private System.Windows.Forms.TextBox TextStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvFactionsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactionName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReputation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFavor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnInvited;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnBanned;
    }
}
