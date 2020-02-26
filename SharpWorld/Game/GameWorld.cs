using System;
using System.Collections.Generic;
using SharpWorld.Singleton;
using SharpWorld.Game.Units;
using SharpWorld.Game.Zones;
using SharpWorld.Game.Units.Bosses;

namespace SharpWorld.Game
{
    class GameWorld : Singleton<GameWorld>
    {
        private Player _player;

        private Dictionary<string, Zone> _zones;
        private GameForm _form;
        public GameForm GetForm() => _form;
        public void Start(GameForm form, string playerName)
        {
            _form = form;

            _player = new Player(playerName);
            _zones = new Dictionary<string, Zone>();

            LoadZones();
            _player.EnterZone(FindZone("Garden"));

            Log("Finished starting up the game!");
        }
        public void Log(string log)
        {
            _form.Log(log);
        }
        public Player GetPlayer()
        {
            return _player;
        }
        public Zone FindZone(string name)
        {
            return _zones[name];
        }
        public List<Monster> GetMonsters()
        {
            return _player.GetZone().Monsters;
        }
        public void LoadZones()
        {
            var gardenMonsters = new List<Monster>();
            gardenMonsters.Add(new Monster("Goblin", 2, 6, 2, 1));
            gardenMonsters.Add(new Monster("Rat", 1, 1, 1, 1));
            gardenMonsters.Add(new Monster("Crab", 2, 20, 1, 1));
            gardenMonsters.Add(new Monster("Test", 2, 10000, 0, 1));
            gardenMonsters.Add(new ToxicSerpent());
            Zone garden = new Zone("Garden", 1, gardenMonsters);
            _zones.Add(garden.Name, garden);
        }
    }
}
