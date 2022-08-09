
namespace RPG_game
{
    partial class RPG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IbHitPoints = new System.Windows.Forms.Label();
            this.IblGold = new System.Windows.Forms.Label();
            this.IblExperience = new System.Windows.Forms.Label();
            this.IblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBOWeapons = new System.Windows.Forms.ComboBox();
            this.CBOPotions = new System.Windows.Forms.ComboBox();
            this.useweapon = new System.Windows.Forms.Button();
            this.usepotion = new System.Windows.Forms.Button();
            this.north = new System.Windows.Forms.Button();
            this.south = new System.Windows.Forms.Button();
            this.east = new System.Windows.Forms.Button();
            this.west = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.RichTextBox();
            this.messages = new System.Windows.Forms.RichTextBox();
            this.inventory = new System.Windows.Forms.DataGridView();
            this.quests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit points : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level : ";
            // 
            // IbHitPoints
            // 
            this.IbHitPoints.AutoSize = true;
            this.IbHitPoints.Location = new System.Drawing.Point(110, 19);
            this.IbHitPoints.Name = "IbHitPoints";
            this.IbHitPoints.Size = new System.Drawing.Size(46, 17);
            this.IbHitPoints.TabIndex = 4;
            this.IbHitPoints.Text = "label5";
            // 
            // IblGold
            // 
            this.IblGold.AutoSize = true;
            this.IblGold.Location = new System.Drawing.Point(110, 45);
            this.IblGold.Name = "IblGold";
            this.IblGold.Size = new System.Drawing.Size(46, 17);
            this.IblGold.TabIndex = 5;
            this.IblGold.Text = "label5";
            // 
            // IblExperience
            // 
            this.IblExperience.AutoSize = true;
            this.IblExperience.Location = new System.Drawing.Point(110, 73);
            this.IblExperience.Name = "IblExperience";
            this.IblExperience.Size = new System.Drawing.Size(46, 17);
            this.IblExperience.TabIndex = 6;
            this.IblExperience.Text = "label5";
            // 
            // IblLevel
            // 
            this.IblLevel.AutoSize = true;
            this.IblLevel.Location = new System.Drawing.Point(110, 99);
            this.IblLevel.Name = "IblLevel";
            this.IblLevel.Size = new System.Drawing.Size(46, 17);
            this.IblLevel.TabIndex = 7;
            this.IblLevel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select action";
            // 
            // CBOWeapons
            // 
            this.CBOWeapons.FormattingEnabled = true;
            this.CBOWeapons.Location = new System.Drawing.Point(369, 559);
            this.CBOWeapons.Name = "CBOWeapons";
            this.CBOWeapons.Size = new System.Drawing.Size(121, 24);
            this.CBOWeapons.TabIndex = 9;
            // 
            // CBOPotions
            // 
            this.CBOPotions.FormattingEnabled = true;
            this.CBOPotions.Location = new System.Drawing.Point(369, 593);
            this.CBOPotions.Name = "CBOPotions";
            this.CBOPotions.Size = new System.Drawing.Size(121, 24);
            this.CBOPotions.TabIndex = 10;
            // 
            // useweapon
            // 
            this.useweapon.Location = new System.Drawing.Point(620, 559);
            this.useweapon.Name = "useweapon";
            this.useweapon.Size = new System.Drawing.Size(75, 23);
            this.useweapon.TabIndex = 11;
            this.useweapon.Text = "button1";
            this.useweapon.UseVisualStyleBackColor = true;
            // 
            // usepotion
            // 
            this.usepotion.Location = new System.Drawing.Point(620, 593);
            this.usepotion.Name = "usepotion";
            this.usepotion.Size = new System.Drawing.Size(75, 23);
            this.usepotion.TabIndex = 12;
            this.usepotion.Text = "button2";
            this.usepotion.UseVisualStyleBackColor = true;
            // 
            // north
            // 
            this.north.Location = new System.Drawing.Point(493, 433);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(75, 23);
            this.north.TabIndex = 13;
            this.north.Text = "button3";
            this.north.UseVisualStyleBackColor = true;
            // 
            // south
            // 
            this.south.Location = new System.Drawing.Point(493, 487);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(75, 23);
            this.south.TabIndex = 14;
            this.south.Text = "button4";
            this.south.UseVisualStyleBackColor = true;
            // 
            // east
            // 
            this.east.Location = new System.Drawing.Point(573, 457);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(75, 23);
            this.east.TabIndex = 15;
            this.east.Text = "button5";
            this.east.UseVisualStyleBackColor = true;
            // 
            // west
            // 
            this.west.Location = new System.Drawing.Point(412, 457);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(75, 23);
            this.west.TabIndex = 16;
            this.west.Text = "button6";
            this.west.UseVisualStyleBackColor = true;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(347, 19);
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Size = new System.Drawing.Size(360, 105);
            this.location.TabIndex = 17;
            this.location.Text = "";
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(347, 130);
            this.messages.Name = "messages";
            this.messages.ReadOnly = true;
            this.messages.Size = new System.Drawing.Size(360, 286);
            this.messages.TabIndex = 18;
            this.messages.Text = "";
            // 
            // inventory
            // 
            this.inventory.AllowUserToAddRows = false;
            this.inventory.AllowUserToDeleteRows = false;
            this.inventory.AllowUserToResizeRows = false;
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventory.Enabled = false;
            this.inventory.Location = new System.Drawing.Point(16, 130);
            this.inventory.MultiSelect = false;
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            this.inventory.RowHeadersWidth = 51;
            this.inventory.RowTemplate.Height = 24;
            this.inventory.Size = new System.Drawing.Size(312, 309);
            this.inventory.TabIndex = 19;
            // 
            // quests
            // 
            this.quests.AllowUserToAddRows = false;
            this.quests.AllowUserToDeleteRows = false;
            this.quests.AllowUserToResizeRows = false;
            this.quests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.quests.Enabled = false;
            this.quests.Location = new System.Drawing.Point(16, 446);
            this.quests.MultiSelect = false;
            this.quests.Name = "quests";
            this.quests.ReadOnly = true;
            this.quests.RowHeadersWidth = 51;
            this.quests.RowTemplate.Height = 24;
            this.quests.Size = new System.Drawing.Size(312, 189);
            this.quests.TabIndex = 20;
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 643);
            this.Controls.Add(this.quests);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.location);
            this.Controls.Add(this.west);
            this.Controls.Add(this.east);
            this.Controls.Add(this.south);
            this.Controls.Add(this.north);
            this.Controls.Add(this.usepotion);
            this.Controls.Add(this.useweapon);
            this.Controls.Add(this.CBOPotions);
            this.Controls.Add(this.CBOWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IblLevel);
            this.Controls.Add(this.IblExperience);
            this.Controls.Add(this.IblGold);
            this.Controls.Add(this.IbHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RPG";
            this.Text = "MyGame";
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IbHitPoints;
        private System.Windows.Forms.Label IblGold;
        private System.Windows.Forms.Label IblExperience;
        private System.Windows.Forms.Label IblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBOWeapons;
        private System.Windows.Forms.ComboBox CBOPotions;
        private System.Windows.Forms.Button useweapon;
        private System.Windows.Forms.Button usepotion;
        private System.Windows.Forms.Button north;
        private System.Windows.Forms.Button south;
        private System.Windows.Forms.Button east;
        private System.Windows.Forms.Button west;
        private System.Windows.Forms.RichTextBox location;
        private System.Windows.Forms.RichTextBox messages;
        private System.Windows.Forms.DataGridView inventory;
        private System.Windows.Forms.DataGridView quests;
    }
}

