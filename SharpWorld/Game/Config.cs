using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game
{
    public static class Config
    {
        public static int ExpRate = 4;//Experience per damage done.
        public static int BaseXpRequirement = 40;//The base experience needed at level 1.
        public static float XpRequirementRatio = 1.2F;//Additional experience needed per level
        public static int CombatTickRate = 5;//The speed of combat (higher = slower)
        public static int ItemUseCooldown = 1000;//Cooldown between using items.
        public static bool DisableDamageLog = false;

        //inventory
        public static int MaxInventorySize = 28;
    }
}
