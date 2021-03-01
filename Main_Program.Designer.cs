namespace DND_Manage
{
    partial class Main_Program
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
            this.Fighters = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monstersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Current_server = new System.Windows.Forms.TextBox();
            this.actions = new System.Windows.Forms.RichTextBox();
            this.traits = new System.Windows.Forms.RichTextBox();
            this.skills = new System.Windows.Forms.RichTextBox();
            this.CHA = new System.Windows.Forms.TextBox();
            this.WIS = new System.Windows.Forms.TextBox();
            this.INT = new System.Windows.Forms.TextBox();
            this.CON = new System.Windows.Forms.TextBox();
            this.DEX = new System.Windows.Forms.TextBox();
            this.STR = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.armorclass = new System.Windows.Forms.TextBox();
            this.monstername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HitpointRoller = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HitpointRoller)).BeginInit();
            this.SuspendLayout();
            // 
            // Fighters
            // 
            this.Fighters.FormattingEnabled = true;
            this.Fighters.Location = new System.Drawing.Point(12, 27);
            this.Fighters.Name = "Fighters";
            this.Fighters.Size = new System.Drawing.Size(120, 511);
            this.Fighters.TabIndex = 0;
            this.Fighters.SelectedIndexChanged += new System.EventHandler(this.Fighters_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.runToolStripMenuItem,
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monstersToolStripMenuItem,
            this.encountersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // monstersToolStripMenuItem
            // 
            this.monstersToolStripMenuItem.Name = "monstersToolStripMenuItem";
            this.monstersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.monstersToolStripMenuItem.Text = "Monsters";
            this.monstersToolStripMenuItem.Click += new System.EventHandler(this.monstersToolStripMenuItem_Click);
            // 
            // encountersToolStripMenuItem
            // 
            this.encountersToolStripMenuItem.Name = "encountersToolStripMenuItem";
            this.encountersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.encountersToolStripMenuItem.Text = "Encounters";
            this.encountersToolStripMenuItem.Click += new System.EventHandler(this.encountersToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConnectionToolStripMenuItem,
            this.newConnectionToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // openConnectionToolStripMenuItem
            // 
            this.openConnectionToolStripMenuItem.Name = "openConnectionToolStripMenuItem";
            this.openConnectionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openConnectionToolStripMenuItem.Text = "Open Connection";
            this.openConnectionToolStripMenuItem.Click += new System.EventHandler(this.openConnectionToolStripMenuItem_Click);
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newConnectionToolStripMenuItem.Text = "New Connection";
            this.newConnectionToolStripMenuItem.Click += new System.EventHandler(this.newConnectionToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Current_server
            // 
            this.Current_server.Location = new System.Drawing.Point(12, 544);
            this.Current_server.Name = "Current_server";
            this.Current_server.ReadOnly = true;
            this.Current_server.Size = new System.Drawing.Size(326, 20);
            this.Current_server.TabIndex = 2;
            this.Current_server.Text = "Null";
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.SystemColors.Window;
            this.actions.Location = new System.Drawing.Point(138, 393);
            this.actions.Name = "actions";
            this.actions.ReadOnly = true;
            this.actions.Size = new System.Drawing.Size(199, 145);
            this.actions.TabIndex = 84;
            this.actions.Text = "";
            // 
            // traits
            // 
            this.traits.BackColor = System.Drawing.SystemColors.Window;
            this.traits.Location = new System.Drawing.Point(138, 262);
            this.traits.Name = "traits";
            this.traits.ReadOnly = true;
            this.traits.Size = new System.Drawing.Size(199, 112);
            this.traits.TabIndex = 83;
            this.traits.Text = "";
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.SystemColors.Window;
            this.skills.Location = new System.Drawing.Point(138, 184);
            this.skills.Name = "skills";
            this.skills.ReadOnly = true;
            this.skills.Size = new System.Drawing.Size(199, 59);
            this.skills.TabIndex = 82;
            this.skills.Text = "";
            // 
            // CHA
            // 
            this.CHA.BackColor = System.Drawing.SystemColors.Window;
            this.CHA.Location = new System.Drawing.Point(311, 133);
            this.CHA.MaxLength = 3;
            this.CHA.Name = "CHA";
            this.CHA.ReadOnly = true;
            this.CHA.Size = new System.Drawing.Size(26, 20);
            this.CHA.TabIndex = 81;
            // 
            // WIS
            // 
            this.WIS.BackColor = System.Drawing.SystemColors.Window;
            this.WIS.Location = new System.Drawing.Point(277, 133);
            this.WIS.MaxLength = 3;
            this.WIS.Name = "WIS";
            this.WIS.ReadOnly = true;
            this.WIS.Size = new System.Drawing.Size(26, 20);
            this.WIS.TabIndex = 80;
            // 
            // INT
            // 
            this.INT.BackColor = System.Drawing.SystemColors.Window;
            this.INT.Location = new System.Drawing.Point(245, 133);
            this.INT.MaxLength = 3;
            this.INT.Name = "INT";
            this.INT.ReadOnly = true;
            this.INT.Size = new System.Drawing.Size(26, 20);
            this.INT.TabIndex = 79;
            // 
            // CON
            // 
            this.CON.BackColor = System.Drawing.SystemColors.Window;
            this.CON.Location = new System.Drawing.Point(208, 133);
            this.CON.MaxLength = 3;
            this.CON.Name = "CON";
            this.CON.ReadOnly = true;
            this.CON.Size = new System.Drawing.Size(26, 20);
            this.CON.TabIndex = 78;
            // 
            // DEX
            // 
            this.DEX.BackColor = System.Drawing.SystemColors.Window;
            this.DEX.Location = new System.Drawing.Point(176, 133);
            this.DEX.MaxLength = 3;
            this.DEX.Name = "DEX";
            this.DEX.ReadOnly = true;
            this.DEX.Size = new System.Drawing.Size(26, 20);
            this.DEX.TabIndex = 77;
            // 
            // STR
            // 
            this.STR.BackColor = System.Drawing.SystemColors.Window;
            this.STR.Location = new System.Drawing.Point(138, 133);
            this.STR.MaxLength = 3;
            this.STR.Name = "STR";
            this.STR.ReadOnly = true;
            this.STR.Size = new System.Drawing.Size(29, 20);
            this.STR.TabIndex = 76;
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.SystemColors.Window;
            this.speed.Location = new System.Drawing.Point(220, 93);
            this.speed.MaxLength = 255;
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Size = new System.Drawing.Size(117, 20);
            this.speed.TabIndex = 75;
            // 
            // armorclass
            // 
            this.armorclass.BackColor = System.Drawing.SystemColors.Window;
            this.armorclass.Location = new System.Drawing.Point(220, 49);
            this.armorclass.MaxLength = 255;
            this.armorclass.Name = "armorclass";
            this.armorclass.ReadOnly = true;
            this.armorclass.Size = new System.Drawing.Size(117, 20);
            this.armorclass.TabIndex = 73;
            // 
            // monstername
            // 
            this.monstername.BackColor = System.Drawing.SystemColors.Window;
            this.monstername.Location = new System.Drawing.Point(220, 27);
            this.monstername.MaxLength = 255;
            this.monstername.Name = "monstername";
            this.monstername.ReadOnly = true;
            this.monstername.Size = new System.Drawing.Size(117, 20);
            this.monstername.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Actions";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Traits";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Skills";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "CHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "WIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "INT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "CON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "DEX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "STR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Hitpoints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Armor Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Monster Name";
            // 
            // HitpointRoller
            // 
            this.HitpointRoller.BackColor = System.Drawing.SystemColors.Info;
            this.HitpointRoller.Enabled = false;
            this.HitpointRoller.Location = new System.Drawing.Point(220, 72);
            this.HitpointRoller.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.HitpointRoller.Name = "HitpointRoller";
            this.HitpointRoller.Size = new System.Drawing.Size(118, 20);
            this.HitpointRoller.TabIndex = 85;
            this.HitpointRoller.ValueChanged += new System.EventHandler(this.HitpointRoller_ValueChanged);
            // 
            // Main_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 566);
            this.Controls.Add(this.HitpointRoller);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.traits);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.CHA);
            this.Controls.Add(this.WIS);
            this.Controls.Add(this.INT);
            this.Controls.Add(this.CON);
            this.Controls.Add(this.DEX);
            this.Controls.Add(this.STR);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.armorclass);
            this.Controls.Add(this.monstername);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Current_server);
            this.Controls.Add(this.Fighters);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Program";
            this.Text = "DND Managment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HitpointRoller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Fighters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox Current_server;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox actions;
        private System.Windows.Forms.RichTextBox traits;
        private System.Windows.Forms.RichTextBox skills;
        private System.Windows.Forms.TextBox CHA;
        private System.Windows.Forms.TextBox WIS;
        private System.Windows.Forms.TextBox INT;
        private System.Windows.Forms.TextBox CON;
        private System.Windows.Forms.TextBox DEX;
        private System.Windows.Forms.TextBox STR;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox armorclass;
        private System.Windows.Forms.TextBox monstername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HitpointRoller;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monstersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}

