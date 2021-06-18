using System;
using System.Collections.Generic;
using System.Text;

namespace WitcherCharacterCreator
{
    public abstract class Statistic
    {
        public int value { get; set; }

        public Skill[] skills;
    }

    public class Skill
    {
        public string name;
        public bool isHardSkill;
        public int value;


        public Skill(string name, bool isHardSkill = false)
        {
            this.name = name;
            this.isHardSkill = isHardSkill;
        }
    }
}

namespace WitcherCharacterCreator.Statistics
{
    public enum StatisticEnum
    {
        Intelligence,
        Reflex,
        Dexterity,
        Body,
        Empathy,
        Craft,
        Will
    }

    public class Intelligence : Statistic
    {
        public Intelligence()
        {
            value = 0;
            skills = new Skill[]
            {
                new Skill("Business"),
                new Skill("Awareness"),
                new Skill("Deduction"),
                new Skill("Education"),
                new Skill("Language", true),
                new Skill("Monster Lore", true),
                new Skill("Social Etiquette"),
                new Skill("Streetwise"),
                new Skill("Tactics", true),
                new Skill("Teaching"),
                new Skill("Wilderness Survival")
            };
        }
    }

    public enum IntelligenceEnum
    {
        Business,
        Awareness,
        Deduction,
        Education,
        Language,
        MonsterLore,
        SocialEtiquette,
        Streetwise,
        Tactics,
        Teaching,
        WildernessSurvival
    }

    public class Reflex : Statistic
    {
        public Reflex()
        {
            value = 0;
            skills = new Skill[]
            {
                new Skill("Brawling"),
                new Skill("Dodge/Escape"),
                new Skill("Melee"),
                new Skill("Riding"),
                new Skill("Sailing"),
                new Skill("Small Blades"),
                new Skill("Staff/Spear"),
                new Skill("Swordsmanship")
            };
        }
    }

    public enum ReflexEnum
    {
        Brawling,
        DodgeEscape,
        Melee,
        Riding,
        Sailing,
        SmallBlades,
        StaffSpear,
        Swordsmanship
    }

    public class Dexterity : Statistic
    {
        public Dexterity()
        {
            value = 0;

            skills = new Skill[]
            {
                new Skill("Archery"),
                new Skill("Athletics"),
                new Skill("Crossbow"),
                new Skill("Sleight of Hand"),
                new Skill("Stealth")
            };
        }
    }

    public enum DexterityEnum
    {
        Archery,
        Athletics,
        Crossbow,
        SleightofHand,
        Stealth
    }

    public class Body : Statistic
    {
        public Body()
        {
            value = 0;

            skills = new Skill[]
            {
                new Skill("Physique"),
                new Skill("Endurance")
            };
        }
    }

    public enum BodyEnum
    {
        Physique,
        Endurance
    }

    public class Empathy : Statistic
    {
        public Empathy()
        {
            value = 0;

            skills = new Skill[]
            {
                new Skill("Charisma"),
                new Skill("Deceit"),
                new Skill("Fine Arts"),
                new Skill("Gambling"),
                new Skill("Grooming and Style"),
                new Skill("Human Perception"),
                new Skill("Leadership"),
                new Skill("Persuasion"),
                new Skill("Performance"),
                new Skill("Seduction")
            };
        }
    }


    public enum EmpathyEnum
    {
        Charisma,
        Deceit,
        FineArts,
        Gambling,
        GroomingandStyle,
        HumanPerception,
        Leadership,
        Persuasion,
        Performance,
        Seduction
    }

    public class Craft : Statistic
    {
        public Craft()
        {
            value = 0;

            skills = new Skill[]
            {
                new Skill("Alchemy", true),
                new Skill("Crafting", true),
                new Skill("Disguise"),
                new Skill("First Aid"),
                new Skill("Forgery"),
                new Skill("Pick Lock"),
                new Skill("Trap Crafting", true)
            };
        }
    }

    public enum CraftEnum
    {
        Alchemy,
        Crafting,
        Disguise,
        FirstAid,
        Forgery,
        PickLock,
        TrapCrafting
    }

    public class Will : Statistic
    {
        public Will()
        {
            value = 0;

            skills = new Skill[]
            {
                new Skill("Courage"),
                new Skill("Hex Weaving", true),
                new Skill("Intimidation"),
                new Skill("Spell Casting", true),
                new Skill("Resist Magic", true),
                new Skill("Resist Coercion"),
                new Skill("Ritual Crafting", true)
            };
        }
    }

    public enum WillEnum
    {
        Courage,
        HexWeaving,
        Intimidation,
        SpellCasting,
        ResistMagic,
        ResistCoercion,
        RitualCrafting
    }
}