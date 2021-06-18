using System;
using System.Collections.Generic;
using System.Text;

namespace WitcherCharacterCreator
{
    public abstract class Proffesion : IInfo
    {
        public string name { get; protected set; }

        public string text()
        {
            return name;
        }

        protected SkillTree skillTree;
    }

    public class Bard : Proffesion
    {
        public Bard()
        {
            name = "Bard";
            skillTree = new BardTree();
        }
    }

    public class Craftsman : Proffesion
    {
        public Craftsman()
        {
            name = "Craftsman";
            skillTree = new CraftsmanTree();
        }
    }

    public class Criminal : Proffesion
    {
        public Criminal()
        {
            name = "Criminal";
            skillTree = new CriminalTree();
        }
    }

    public class Doctor : Proffesion
    {
        public Doctor()
        {
            name = "Doctor";
            skillTree = new DoctorTree();
        }
    }

    public class Mage : Proffesion
    {
        public Mage()
        {
            name = "Mage";
            skillTree = new MageTree();
        }
    }

    public class ManAtArms : Proffesion
    {
        public ManAtArms()
        {
            name = "ManAtArms";
            skillTree = new ManAtArmsTree();
        }
    }

    public class Merchant : Proffesion
    {
        public Merchant()
        {
            name = "Merchant";
            skillTree = new MerchantTree();
        }
    }

    public class Priest : Proffesion
    {
        public Priest()
        {
            name = "Priest";
            skillTree = new PriestTree();
        }
    }

    public class Witcher : Proffesion
    {
        public Witcher()
        {
            name = "Witcher";
            skillTree = new WitcherTree();
        }
    }
}