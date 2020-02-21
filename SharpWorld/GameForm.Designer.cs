namespace SharpWorld
{
    partial class GameForm
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
            this.GameLog = new System.Windows.Forms.RichTextBox();
            this.LootBox = new System.Windows.Forms.ListBox();
            this.LootLabel = new System.Windows.Forms.Label();
            this.GameLogLabel = new System.Windows.Forms.Label();
            this.LootButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MonsterList = new System.Windows.Forms.ListBox();
            this.MonsterLabel = new System.Windows.Forms.Label();
            this.FightButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.InventoryList = new System.Windows.Forms.ListBox();
            this.UseButton = new System.Windows.Forms.Button();
            this.PlayerHpPlaceholder = new System.Windows.Forms.ProgressBar();
            this.PlayerHpBarLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CharacterTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerLevelLabel = new System.Windows.Forms.Label();
            this.PlayerDefenseLabel = new System.Windows.Forms.Label();
            this.PlayerAttackLabel = new System.Windows.Forms.Label();
            this.PlayerMaxHpLabel = new System.Windows.Forms.Label();
            this.PlayerNameValue = new System.Windows.Forms.Label();
            this.PlayerLevelValue = new System.Windows.Forms.Label();
            this.PlayerMaxHpValue = new System.Windows.Forms.Label();
            this.PlayerAttackValue = new System.Windows.Forms.Label();
            this.PlayerDefenseValue = new System.Windows.Forms.Label();
            this.PlayerZoneLabel = new System.Windows.Forms.Label();
            this.PlayerZoneValue = new System.Windows.Forms.Label();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.DropButton = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandButton = new System.Windows.Forms.Button();
            this.EnemyHpPlaceholder = new System.Windows.Forms.ProgressBar();
            this.EnemyHpBarLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CharacterTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameLog
            // 
            this.GameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLog.Location = new System.Drawing.Point(12, 35);
            this.GameLog.Name = "GameLog";
            this.GameLog.ReadOnly = true;
            this.GameLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.GameLog.Size = new System.Drawing.Size(417, 282);
            this.GameLog.TabIndex = 0;
            this.GameLog.Text = "";
            // 
            // LootBox
            // 
            this.LootBox.FormattingEnabled = true;
            this.LootBox.Location = new System.Drawing.Point(435, 178);
            this.LootBox.Name = "LootBox";
            this.LootBox.Size = new System.Drawing.Size(163, 95);
            this.LootBox.TabIndex = 1;
            // 
            // LootLabel
            // 
            this.LootLabel.AutoSize = true;
            this.LootLabel.Location = new System.Drawing.Point(432, 162);
            this.LootLabel.Name = "LootLabel";
            this.LootLabel.Size = new System.Drawing.Size(28, 13);
            this.LootLabel.TabIndex = 2;
            this.LootLabel.Text = "Loot";
            // 
            // GameLogLabel
            // 
            this.GameLogLabel.AutoSize = true;
            this.GameLogLabel.Location = new System.Drawing.Point(13, 13);
            this.GameLogLabel.Name = "GameLogLabel";
            this.GameLogLabel.Size = new System.Drawing.Size(56, 13);
            this.GameLogLabel.TabIndex = 3;
            this.GameLogLabel.Text = "Game Log";
            // 
            // LootButton
            // 
            this.LootButton.Location = new System.Drawing.Point(435, 277);
            this.LootButton.Name = "LootButton";
            this.LootButton.Size = new System.Drawing.Size(163, 29);
            this.LootButton.TabIndex = 4;
            this.LootButton.Text = "Loot";
            this.LootButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MonsterList
            // 
            this.MonsterList.FormattingEnabled = true;
            this.MonsterList.Location = new System.Drawing.Point(439, 35);
            this.MonsterList.Name = "MonsterList";
            this.MonsterList.Size = new System.Drawing.Size(163, 95);
            this.MonsterList.TabIndex = 6;
            // 
            // MonsterLabel
            // 
            this.MonsterLabel.AutoSize = true;
            this.MonsterLabel.Location = new System.Drawing.Point(436, 13);
            this.MonsterLabel.Name = "MonsterLabel";
            this.MonsterLabel.Size = new System.Drawing.Size(50, 13);
            this.MonsterLabel.TabIndex = 7;
            this.MonsterLabel.Text = "Monsters";
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(435, 136);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(75, 23);
            this.FightButton.TabIndex = 8;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(516, 136);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(82, 23);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // InventoryList
            // 
            this.InventoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.Location = new System.Drawing.Point(0, 6);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(175, 210);
            this.InventoryList.TabIndex = 10;
            // 
            // UseButton
            // 
            this.UseButton.Location = new System.Drawing.Point(0, 222);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(88, 39);
            this.UseButton.TabIndex = 12;
            this.UseButton.Text = "Use";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // PlayerHpPlaceholder
            // 
            this.PlayerHpPlaceholder.Location = new System.Drawing.Point(617, 330);
            this.PlayerHpPlaceholder.Name = "PlayerHpPlaceholder";
            this.PlayerHpPlaceholder.Size = new System.Drawing.Size(175, 34);
            this.PlayerHpPlaceholder.TabIndex = 13;
            this.PlayerHpPlaceholder.Value = 100;
            // 
            // PlayerHpBarLabel
            // 
            this.PlayerHpBarLabel.AutoSize = true;
            this.PlayerHpBarLabel.Location = new System.Drawing.Point(614, 314);
            this.PlayerHpBarLabel.Name = "PlayerHpBarLabel";
            this.PlayerHpBarLabel.Size = new System.Drawing.Size(25, 13);
            this.PlayerHpBarLabel.TabIndex = 14;
            this.PlayerHpBarLabel.Text = "HP:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CharacterTab);
            this.tabControl1.Controls.Add(this.InventoryTab);
            this.tabControl1.Location = new System.Drawing.Point(613, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(186, 294);
            this.tabControl1.TabIndex = 15;
            // 
            // CharacterTab
            // 
            this.CharacterTab.Controls.Add(this.tableLayoutPanel1);
            this.CharacterTab.Location = new System.Drawing.Point(4, 22);
            this.CharacterTab.Name = "CharacterTab";
            this.CharacterTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterTab.Size = new System.Drawing.Size(178, 268);
            this.CharacterTab.TabIndex = 0;
            this.CharacterTab.Text = "Character";
            this.CharacterTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07101F));
            this.tableLayoutPanel1.Controls.Add(this.PlayerNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlayerLevelLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerDefenseLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlayerAttackLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayerMaxHpLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlayerNameValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlayerLevelValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerMaxHpValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlayerAttackValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayerDefenseValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlayerZoneLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PlayerZoneValue, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 202);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.Location = new System.Drawing.Point(3, 0);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(52, 18);
            this.PlayerNameLabel.TabIndex = 0;
            this.PlayerNameLabel.Text = "Name:";
            // 
            // PlayerLevelLabel
            // 
            this.PlayerLevelLabel.AutoSize = true;
            this.PlayerLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLevelLabel.Location = new System.Drawing.Point(3, 19);
            this.PlayerLevelLabel.Name = "PlayerLevelLabel";
            this.PlayerLevelLabel.Size = new System.Drawing.Size(46, 18);
            this.PlayerLevelLabel.TabIndex = 3;
            this.PlayerLevelLabel.Text = "Level:";
            // 
            // PlayerDefenseLabel
            // 
            this.PlayerDefenseLabel.AutoSize = true;
            this.PlayerDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDefenseLabel.Location = new System.Drawing.Point(3, 104);
            this.PlayerDefenseLabel.Name = "PlayerDefenseLabel";
            this.PlayerDefenseLabel.Size = new System.Drawing.Size(67, 18);
            this.PlayerDefenseLabel.TabIndex = 2;
            this.PlayerDefenseLabel.Text = "Defense:";
            // 
            // PlayerAttackLabel
            // 
            this.PlayerAttackLabel.AutoSize = true;
            this.PlayerAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAttackLabel.Location = new System.Drawing.Point(3, 81);
            this.PlayerAttackLabel.Name = "PlayerAttackLabel";
            this.PlayerAttackLabel.Size = new System.Drawing.Size(53, 18);
            this.PlayerAttackLabel.TabIndex = 1;
            this.PlayerAttackLabel.Text = "Attack:";
            // 
            // PlayerMaxHpLabel
            // 
            this.PlayerMaxHpLabel.AutoSize = true;
            this.PlayerMaxHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMaxHpLabel.Location = new System.Drawing.Point(3, 46);
            this.PlayerMaxHpLabel.Name = "PlayerMaxHpLabel";
            this.PlayerMaxHpLabel.Size = new System.Drawing.Size(63, 18);
            this.PlayerMaxHpLabel.TabIndex = 4;
            this.PlayerMaxHpLabel.Text = "Max Hp:";
            // 
            // PlayerNameValue
            // 
            this.PlayerNameValue.AutoSize = true;
            this.PlayerNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameValue.Location = new System.Drawing.Point(83, 0);
            this.PlayerNameValue.Name = "PlayerNameValue";
            this.PlayerNameValue.Size = new System.Drawing.Size(0, 18);
            this.PlayerNameValue.TabIndex = 5;
            // 
            // PlayerLevelValue
            // 
            this.PlayerLevelValue.AutoSize = true;
            this.PlayerLevelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLevelValue.Location = new System.Drawing.Point(83, 19);
            this.PlayerLevelValue.Name = "PlayerLevelValue";
            this.PlayerLevelValue.Size = new System.Drawing.Size(16, 18);
            this.PlayerLevelValue.TabIndex = 6;
            this.PlayerLevelValue.Text = "0";
            // 
            // PlayerMaxHpValue
            // 
            this.PlayerMaxHpValue.AutoSize = true;
            this.PlayerMaxHpValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMaxHpValue.Location = new System.Drawing.Point(83, 46);
            this.PlayerMaxHpValue.Name = "PlayerMaxHpValue";
            this.PlayerMaxHpValue.Size = new System.Drawing.Size(16, 18);
            this.PlayerMaxHpValue.TabIndex = 7;
            this.PlayerMaxHpValue.Text = "0";
            // 
            // PlayerAttackValue
            // 
            this.PlayerAttackValue.AutoSize = true;
            this.PlayerAttackValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAttackValue.Location = new System.Drawing.Point(83, 81);
            this.PlayerAttackValue.Name = "PlayerAttackValue";
            this.PlayerAttackValue.Size = new System.Drawing.Size(16, 18);
            this.PlayerAttackValue.TabIndex = 8;
            this.PlayerAttackValue.Text = "0";
            // 
            // PlayerDefenseValue
            // 
            this.PlayerDefenseValue.AutoSize = true;
            this.PlayerDefenseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDefenseValue.Location = new System.Drawing.Point(83, 104);
            this.PlayerDefenseValue.Name = "PlayerDefenseValue";
            this.PlayerDefenseValue.Size = new System.Drawing.Size(16, 18);
            this.PlayerDefenseValue.TabIndex = 9;
            this.PlayerDefenseValue.Text = "0";
            // 
            // PlayerZoneLabel
            // 
            this.PlayerZoneLabel.AutoSize = true;
            this.PlayerZoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerZoneLabel.Location = new System.Drawing.Point(3, 165);
            this.PlayerZoneLabel.Name = "PlayerZoneLabel";
            this.PlayerZoneLabel.Size = new System.Drawing.Size(46, 18);
            this.PlayerZoneLabel.TabIndex = 10;
            this.PlayerZoneLabel.Text = "Zone:";
            this.PlayerZoneLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayerZoneValue
            // 
            this.PlayerZoneValue.AutoSize = true;
            this.PlayerZoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerZoneValue.Location = new System.Drawing.Point(83, 165);
            this.PlayerZoneValue.Name = "PlayerZoneValue";
            this.PlayerZoneValue.Size = new System.Drawing.Size(20, 18);
            this.PlayerZoneValue.TabIndex = 11;
            this.PlayerZoneValue.Text = "...";
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.DropButton);
            this.InventoryTab.Controls.Add(this.InventoryList);
            this.InventoryTab.Controls.Add(this.UseButton);
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(178, 268);
            this.InventoryTab.TabIndex = 1;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(91, 222);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(84, 39);
            this.DropButton.TabIndex = 13;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(12, 336);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(318, 20);
            this.CommandTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Command";
            // 
            // CommandButton
            // 
            this.CommandButton.Location = new System.Drawing.Point(336, 332);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(93, 23);
            this.CommandButton.TabIndex = 18;
            this.CommandButton.Text = "Enter";
            this.CommandButton.UseVisualStyleBackColor = true;
            this.CommandButton.Click += new System.EventHandler(this.CommandButton_Click);
            // 
            // EnemyHpPlaceholder
            // 
            this.EnemyHpPlaceholder.Location = new System.Drawing.Point(439, 330);
            this.EnemyHpPlaceholder.Name = "EnemyHpPlaceholder";
            this.EnemyHpPlaceholder.Size = new System.Drawing.Size(169, 34);
            this.EnemyHpPlaceholder.TabIndex = 19;
            this.EnemyHpPlaceholder.Value = 100;
            // 
            // EnemyHpBarLabel
            // 
            this.EnemyHpBarLabel.AutoSize = true;
            this.EnemyHpBarLabel.Location = new System.Drawing.Point(436, 314);
            this.EnemyHpBarLabel.Name = "EnemyHpBarLabel";
            this.EnemyHpBarLabel.Size = new System.Drawing.Size(60, 13);
            this.EnemyHpBarLabel.TabIndex = 20;
            this.EnemyHpBarLabel.Text = "Enemy HP:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 369);
            this.Controls.Add(this.EnemyHpBarLabel);
            this.Controls.Add(this.EnemyHpPlaceholder);
            this.Controls.Add(this.CommandButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PlayerHpBarLabel);
            this.Controls.Add(this.PlayerHpPlaceholder);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.MonsterLabel);
            this.Controls.Add(this.MonsterList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LootButton);
            this.Controls.Add(this.GameLogLabel);
            this.Controls.Add(this.LootLabel);
            this.Controls.Add(this.LootBox);
            this.Controls.Add(this.GameLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Sharp World";
            this.tabControl1.ResumeLayout(false);
            this.CharacterTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InventoryTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LootBox;
        private System.Windows.Forms.Label LootLabel;
        private System.Windows.Forms.Label GameLogLabel;
        private System.Windows.Forms.Button LootButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox MonsterList;
        private System.Windows.Forms.Label MonsterLabel;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ListBox InventoryList;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.ProgressBar PlayerHpPlaceholder;
        private System.Windows.Forms.Label PlayerHpBarLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CharacterTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.ProgressBar EnemyHpPlaceholder;
        private System.Windows.Forms.Label EnemyHpBarLabel;
        public System.Windows.Forms.RichTextBox GameLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label PlayerLevelLabel;
        private System.Windows.Forms.Label PlayerAttackLabel;
        private System.Windows.Forms.Label PlayerDefenseLabel;
        private System.Windows.Forms.Label PlayerMaxHpLabel;
        private System.Windows.Forms.Label PlayerNameValue;
        private System.Windows.Forms.Label PlayerLevelValue;
        private System.Windows.Forms.Label PlayerMaxHpValue;
        private System.Windows.Forms.Label PlayerAttackValue;
        private System.Windows.Forms.Label PlayerDefenseValue;
        private System.Windows.Forms.Label PlayerZoneLabel;
        private System.Windows.Forms.Label PlayerZoneValue;
        private System.Windows.Forms.Button DropButton;
    }
}

