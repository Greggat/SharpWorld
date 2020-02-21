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
            float currentHp = player.GetHp();
            float maxHp = player.GetMaxHp();
            PlayerHpPlaceholder.Value = Convert.ToInt32((currentHp / maxHp) * 100.0F);
            PlayerHpBarLabel.Text = $"HP: {currentHp}/{maxHp}";

            float monsterCurrentHp = player.GetTarget().GetHp();
            float monsterMaxHp = player.GetTarget().GetMaxHp();
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

        public void UpdateCharacterUI()
        {
            Player player = GameWorld.Instance.GetPlayer();

            PlayerNameValue.Text = player.GetName();
            PlayerLevelValue.Text = player.GetLevel().ToString();
            PlayerMaxHpValue.Text = player.GetMaxHp().ToString();
            PlayerAttackValue.Text = player.GetAttack().ToString();
            PlayerDefenseValue.Text = player.GetDefense().ToString();
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
            Log(CommandTextBox.Text+"\n");
            GameLog.SelectionStart = GameLog.Text.Length;
            GameLog.ScrollToCaret();
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
    }
}
