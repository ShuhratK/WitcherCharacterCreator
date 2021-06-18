using System;

namespace WitcherCharacterCreator
{
    public class Character
    {
        public Race race;
        public Proffesion proffesion;
        public Region region;
        public int Age;
        public int Reputauion;
        public Inventory inventory;
        public Statistic[] statistics { get; set; } = new Statistic[]
        {
            new Statistics.Intelligence(),
            new Statistics.Reflex(),
            new Statistics.Dexterity(),
            new Statistics.Body(),
            new Statistics.Empathy(),
            new Statistics.Craft(),
            new Statistics.Will()
        };
    }
}