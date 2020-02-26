using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpWorld.FormComponents;
using SharpWorld.Game.Units;
using SharpWorld.Game.Items;
using SharpWorld.Game;

namespace SharpWorld
{
    public partial class GameForm : Form
    {
        private void RecolorHpBars()
        {
            var oldPlayerBar = this.PlayerHpPlaceholder;
            var oldEnemyBar = this.EnemyHpPlaceholder;

            Controls.Remove(oldPlayerBar);
            Controls.Remove(oldEnemyBar);

            this.PlayerHpPlaceholder = new HealthBar(Brushes.Green);

            this.PlayerHpPlaceholder.Location = oldPlayerBar.Location;
            this.PlayerHpPlaceholder.Name = oldPlayerBar.Name;
            this.PlayerHpPlaceholder.Size = oldPlayerBar.Size;
            this.PlayerHpPlaceholder.TabIndex = oldPlayerBar.TabIndex;
            this.PlayerHpPlaceholder.Value = oldPlayerBar.Value;

            this.Controls.Add(this.PlayerHpPlaceholder);

            this.EnemyHpPlaceholder = new HealthBar(Brushes.Red);

            this.EnemyHpPlaceholder.Location = oldEnemyBar.Location;
            this.EnemyHpPlaceholder.Name = oldEnemyBar.Name;
            this.EnemyHpPlaceholder.Size = oldEnemyBar.Size;
            this.EnemyHpPlaceholder.TabIndex = oldEnemyBar.TabIndex;
            this.EnemyHpPlaceholder.Value = oldEnemyBar.Value;

            this.Controls.Add(this.PlayerHpPlaceholder);
            this.Controls.Add(this.EnemyHpPlaceholder);
        }
        public GameForm()
        {
            InitializeComponent();
            RecolorHpBars();

            GameWorld.Instance.Start(this, "Bob");
            UpdateMonstersUI();
            UpdateCharacterUI();
            UpdateInventoryUI();
        }

        public void Log(string text)
        {
            GameLog.AppendText($"{text}\n");
            GameLog.SelectionStart = GameLog.Text.Length;
            GameLog.ScrollToCaret();
        }

        public void UpdateHealthBars()
        {
            Player player = GameWorld.Instance.GetPlayer();
            float currentHp = player.Hp;
            float maxHp = player.MaxHp;
            PlayerHpPlaceholder.Value = Convert.ToInt32((currentHp / maxHp) * 100.0F);
            PlayerHpBarLabel.Text = $"HP: {currentHp}/{maxHp}";

            float monsterCurrentHp = player?.GetTarget().Hp ?? 1;
            float monsterMaxHp = player?.GetTarget().MaxHp ?? 1;
            EnemyHpPlaceholder.Value = Convert.ToInt32((monsterCurrentHp / monsterMaxHp) * 100.0F);
            EnemyHpBarLabel.Text = $"Enemy HP: {monsterCurrentHp}/{monsterMaxHp}";
        }

        public void UpdateMonstersUI()
        {
            List<Monster> monsters = GameWorld.Instance.GetMonsters();

            MonsterList.Items.Clear();
            foreach(var monster in monsters)
            {
                MonsterList.Items.Add(monster);
            }
        }

        public void UpdateInventoryUI()
        {
            InventoryList.Items.Clear();
            foreach(var item in GameWorld.Instance.GetPlayer().GetInventory())
            {
                InventoryList.Items.Add(item);
            }
        }

        public void UpdateCharacterUI()
        {
            Player player = GameWorld.Instance.GetPlayer();

            PlayerNameValue.Text = player.Name;
            PlayerLevelValue.Text = player.Level.ToString();
            PlayerMaxHpValue.Text = player.MaxHp.ToString();
            PlayerAttackValue.Text = player.Attack.ToString();
            PlayerDefenseValue.Text = player.Defense.ToString();
            PlayerZoneValue.Text = player.GetZone().Name;

        }

        private async void FightButton_Click(object sender, EventArgs e)
        {
            FightButton.Enabled = false;
            if (MonsterList.SelectedItem != null)
            {
                Task test = GameWorld.Instance.GetPlayer().Fight((Monster)MonsterList.SelectedItem);
                await test;
            }
            else
            {
                Log("You must select a monster to fight.");
            }
            FightButton.Enabled = true;
        }

        private void CommandButton_Click(object sender, EventArgs e)
        {
            //Needs to be implemented...
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (GameWorld.Instance.GetPlayer().InCombat())
                GameWorld.Instance.GetPlayer().Run();
            else
                Log("You aren't in combat right now.");
        }

        private async void UseButton_Click(object sender, EventArgs e)
        {
            UseButton.Enabled = false;
            if (InventoryList.SelectedItem != null)
            {
                ((Item)InventoryList.SelectedItem).Use(GameWorld.Instance.GetPlayer());
                //Might be better to get this from player inventory to avoid dupes..
                await Task.Delay(Config.ItemUseCooldown);
            }
            else
            {
                Log("You must select an item to use.");
            }
            UseButton.Enabled = true;
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            //Remove the item from players inventory.
        }
    }
}
