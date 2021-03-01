namespace DND_Manage
{
    partial class Monster_Editor
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
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.monstername = new System.Windows.Forms.TextBox();
            this.armorclass = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.STR = new System.Windows.Forms.TextBox();
            this.DEX = new System.Windows.Forms.TextBox();
            this.CON = new System.Windows.Forms.TextBox();
            this.CHA = new System.Windows.Forms.TextBox();
            this.WIS = new System.Windows.Forms.TextBox();
            this.INT = new System.Windows.Forms.TextBox();
            this.skills = new System.Windows.Forms.RichTextBox();
            this.traits = new System.Windows.Forms.RichTextBox();
            this.actions = new System.Windows.Forms.RichTextBox();
            this.hitpoints = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hitpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(140, 661);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(71, 23);
            this.OK.TabIndex = 30;
            this.OK.Text = "z";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Monster Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Armor Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hitpoints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "STR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "DEX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "INT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "CON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "WIS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "CHA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Skills";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Traits";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Actions";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(137, 517);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 44;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(56, 517);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 45;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // monstername
            // 
            this.monstername.Location = new System.Drawing.Point(94, 6);
            this.monstername.MaxLength = 255;
            this.monstername.Name = "monstername";
            this.monstername.Size = new System.Drawing.Size(117, 20);
            this.monstername.TabIndex = 46;
            // 
            // armorclass
            // 
            this.armorclass.Location = new System.Drawing.Point(94, 28);
            this.armorclass.MaxLength = 255;
            this.armorclass.Name = "armorclass";
            this.armorclass.Size = new System.Drawing.Size(117, 20);
            this.armorclass.TabIndex = 47;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(94, 72);
            this.speed.MaxLength = 255;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(117, 20);
            this.speed.TabIndex = 49;
            // 
            // STR
            // 
            this.STR.Location = new System.Drawing.Point(12, 112);
            this.STR.MaxLength = 3;
            this.STR.Name = "STR";
            this.STR.Size = new System.Drawing.Size(29, 20);
            this.STR.TabIndex = 50;
            // 
            // DEX
            // 
            this.DEX.Location = new System.Drawing.Point(50, 112);
            this.DEX.MaxLength = 3;
            this.DEX.Name = "DEX";
            this.DEX.Size = new System.Drawing.Size(26, 20);
            this.DEX.TabIndex = 51;
            // 
            // CON
            // 
            this.CON.Location = new System.Drawing.Point(82, 112);
            this.CON.MaxLength = 3;
            this.CON.Name = "CON";
            this.CON.Size = new System.Drawing.Size(26, 20);
            this.CON.TabIndex = 52;
            // 
            // CHA
            // 
            this.CHA.Location = new System.Drawing.Point(185, 112);
            this.CHA.MaxLength = 3;
            this.CHA.Name = "CHA";
            this.CHA.Size = new System.Drawing.Size(26, 20);
            this.CHA.TabIndex = 55;
            // 
            // WIS
            // 
            this.WIS.Location = new System.Drawing.Point(151, 112);
            this.WIS.MaxLength = 3;
            this.WIS.Name = "WIS";
            this.WIS.Size = new System.Drawing.Size(26, 20);
            this.WIS.TabIndex = 54;
            // 
            // INT
            // 
            this.INT.Location = new System.Drawing.Point(119, 112);
            this.INT.MaxLength = 3;
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(26, 20);
            this.INT.TabIndex = 53;
            // 
            // skills
            // 
            this.skills.Location = new System.Drawing.Point(12, 163);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(199, 59);
            this.skills.TabIndex = 56;
            this.skills.Text = "";
            // 
            // traits
            // 
            this.traits.Location = new System.Drawing.Point(12, 241);
            this.traits.Name = "traits";
            this.traits.Size = new System.Drawing.Size(199, 112);
            this.traits.TabIndex = 57;
            this.traits.Text = "";
            // 
            // actions
            // 
            this.actions.Location = new System.Drawing.Point(12, 372);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(199, 139);
            this.actions.TabIndex = 58;
            this.actions.Text = "";
            // 
            // hitpoints
            // 
            this.hitpoints.Location = new System.Drawing.Point(94, 51);
            this.hitpoints.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hitpoints.Name = "hitpoints";
            this.hitpoints.Size = new System.Drawing.Size(117, 20);
            this.hitpoints.TabIndex = 48;
            // 
            // Monster_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 552);
            this.Controls.Add(this.hitpoints);
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
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.okbutton);
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
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Monster_Editor";
            this.Text = "Monster Editor";
            this.Load += new System.EventHandler(this.Monster_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hitpoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TextBox monstername;
        private System.Windows.Forms.TextBox armorclass;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox STR;
        private System.Windows.Forms.TextBox DEX;
        private System.Windows.Forms.TextBox CON;
        private System.Windows.Forms.TextBox CHA;
        private System.Windows.Forms.TextBox WIS;
        private System.Windows.Forms.TextBox INT;
        private System.Windows.Forms.RichTextBox skills;
        private System.Windows.Forms.RichTextBox traits;
        private System.Windows.Forms.RichTextBox actions;
        private System.Windows.Forms.NumericUpDown hitpoints;
    }
}