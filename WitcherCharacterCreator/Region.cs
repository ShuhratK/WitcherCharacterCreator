using System;
using WitcherCharacterCreator.Regions;
using WitcherCharacterCreator.Statistics;

namespace WitcherCharacterCreator
{
    public abstract class Region : IInfo
    {
        public RegionEnum regionEnum { get; protected set; }
        public string name { get; protected set; }

        public Origin origin;

        public Origin[] origins { get; protected set; }


        public string text()
        {
            return name;
        }

        public class Origin : IInfo
        {
            private StatisticEnum statstic;
            private int skill;
            private string name;

            public Origin(string name, StatisticEnum statstic, int skill)
            {
                this.name = name;
                this.statstic = statstic;
                this.skill = skill;
            }

            public void applyPerks(Character character)
            {
                character.statistics[(int) statstic].skills[skill].value++;
            }


            public string text()
            {
                return name;
            }
        }
    }

    namespace Regions
    {
        public enum RegionEnum
        {
            NorthernKingdoms,
            Nilfgard,
            Elderlands
        }

        public class Nilfgaard : Region
        {
            public new RegionEnum regionEnum { get; protected set; } = RegionEnum.Nilfgard;
            public new string name { get; protected set; } = "Nilfgaard";

            public Nilfgaard()
            {
                origins = new Origin[]
                {
                    new Origin("The Heart of Nilfgaard", StatisticEnum.Empathy, (int) EmpathyEnum.Deceit),
                    new Origin("Vicovaro", StatisticEnum.Intelligence, (int) IntelligenceEnum.Education),
                    new Origin("Angren", StatisticEnum.Intelligence, (int) IntelligenceEnum.WildernessSurvival),
                    new Origin("Nazair", StatisticEnum.Reflex, (int) ReflexEnum.Brawling),
                    new Origin("Mettina", StatisticEnum.Reflex, (int) ReflexEnum.Riding),
                    new Origin("Mag Turga", StatisticEnum.Body, (int) BodyEnum.Endurance),
                    new Origin("Gheso", StatisticEnum.Dexterity, (int) DexterityEnum.Stealth),
                    new Origin("Ebbing", StatisticEnum.Intelligence, (int) IntelligenceEnum.Deduction),
                    new Origin("Maecht", StatisticEnum.Empathy, (int) EmpathyEnum.Charisma),
                    new Origin("Gemmeria", StatisticEnum.Will, (int) WillEnum.Intimidation),
                    new Origin("Etolia", StatisticEnum.Will, (int) WillEnum.Courage)
                };
            }

            public enum OriginsEnum
            {
                TheHeartofNilfgaard,
                Vicovaro,
                Angren,
                Nazair,
                Mettina,
                MagTurga,
                Gheso,
                Ebbing,
                Maecht,
                Gemmeria,
                Etolia
            }
        }


        public class NorthernKingdoms : Region
        {
            public new RegionEnum regionEnum { get; protected set; } = RegionEnum.NorthernKingdoms;
            public new string name { get; protected set; } = "NorthernKingdoms";

            public NorthernKingdoms()
            {
                origins = new Origin[]
                {
                    new Origin("Redania", StatisticEnum.Intelligence, (int) IntelligenceEnum.Education),
                    new Origin("Kaedwen", StatisticEnum.Body, (int) BodyEnum.Endurance),
                    new Origin("Temeria", StatisticEnum.Empathy, (int) EmpathyEnum.Charisma),
                    new Origin("Aedirn", StatisticEnum.Craft, (int) CraftEnum.Crafting),
                    new Origin("Lyria & Rivia", StatisticEnum.Will, (int) WillEnum.ResistCoercion),
                    new Origin("Kovir & Poviss", StatisticEnum.Intelligence, (int) IntelligenceEnum.Business),
                    new Origin("Skellige", StatisticEnum.Will, (int) WillEnum.Courage),
                    new Origin("Cidaris", StatisticEnum.Reflex, (int) ReflexEnum.Sailing),
                    new Origin("Verden", StatisticEnum.Intelligence, (int) IntelligenceEnum.WildernessSurvival),
                    new Origin("Cintra", StatisticEnum.Empathy, (int) EmpathyEnum.HumanPerception)
                };
            }

            public enum OriginsEnum
            {
                Redania,
                Kaedwen,
                Temeria,
                Aedirn,
                LyriaAndRivia,
                KovirAndPoviss,
                Skellige,
                Cidaris,
                Verden,
                Cintra
            }
        }


        public class Elderlands : Region
        {
            public new RegionEnum regionEnum { get; protected set; } = RegionEnum.Elderlands;
            public new string name { get; protected set; } = "Elderlands";

            public Elderlands()
            {
                origins = new Origin[]
                {
                    new Origin("Dol Blathanna", StatisticEnum.Intelligence,
                        (int) IntelligenceEnum.SocialEtiquette),
                    new Origin("Mahakam", StatisticEnum.Craft, (int) CraftEnum.Crafting)
                };
            }

            public enum OriginsEnum
            {
                DolBlathanna,
                Mahakam
            }
        }
    }
}