using System;
using System.Collections.Generic;
using System.Text;

namespace WitcherCharacterCreator
{
    public abstract class SkillTree
    {
        public ProffesionSkill[] PSkills { get; private set; }

        public DefiningSkill definingSkill { get; private set; }

        public SkillTree()
        {
            PSkills = new ProffesionSkill[]
            {
                new ProffesionSkill(null, PSkills[3], "A1"),
                new ProffesionSkill(null, PSkills[4], "B1"),
                new ProffesionSkill(null, PSkills[5], "C1"),

                new ProffesionSkill(PSkills[0], PSkills[6], "A2"),
                new ProffesionSkill(PSkills[1], PSkills[7], "B2"),
                new ProffesionSkill(PSkills[2], PSkills[8], "C2"),

                new ProffesionSkill(PSkills[3], null, "A3"),
                new ProffesionSkill(PSkills[4], null, "B3"),
                new ProffesionSkill(PSkills[5], null, "C3")
            };
        }
    }

    public class DefiningSkill
    {
    }

    public class ProffesionSkill //ProfessionSkill
    {
        private ProffesionSkill parent;
        private ProffesionSkill child;
        private string description;

        public ProffesionSkill(ProffesionSkill parent, ProffesionSkill child, string description)
        {
            this.parent = parent;
            this.child = child;
            this.description = description;
        }
    }


    public class BardTree : SkillTree
    {
        public BardTree() : base()
        {
        }
    }

    public class CraftsmanTree : SkillTree
    {
        public CraftsmanTree() : base()
        {
        }
    }

    public class CriminalTree : SkillTree
    {
        public CriminalTree() : base()
        {
        }
    }

    public class DoctorTree : SkillTree
    {
        public DoctorTree() : base()
        {
        }
    }

    public class MageTree : SkillTree
    {
        public MageTree() : base()
        {
        }
    }

    public class ManAtArmsTree : SkillTree
    {
        public ManAtArmsTree() : base()
        {
        }
    }

    public class MerchantTree : SkillTree
    {
        public MerchantTree() : base()
        {
        }
    }

    public class PriestTree : SkillTree
    {
        public PriestTree() : base()
        {
        }
    }

    public class WitcherTree : SkillTree
    {
        public WitcherTree() : base()
        {
            
        }
    }
}