using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WitcherCharacterCreator.Races;

namespace WitcherCharacterCreator
{
    public abstract class Race : IInfo
    {
        public string name;

        public RaceEnum raceEnum;

        public abstract void applyPerks(Character character);
        //TODO: Функция будет привязывать определённые скилы персонажа к действиям при которых они должны(могут) быть применены

        public string text()
        {
            return name;
        }
    }


    namespace Races
    {
        public enum RaceEnum
        {
            Witcher,
            Elve,
            Dwarve,
            Human
        }


        public class Witcher : Race
        {
            public Witcher()
            {
                name = "Ведьмак";
                raceEnum = RaceEnum.Witcher;
            }

            public override void applyPerks(Character character)
            {
                throw new NotImplementedException();
            }
        }

        public class Elve : Race
        {
            public Elve()
            {
                name = "Эльф";
                raceEnum = RaceEnum.Elve;
            }

            public override void applyPerks(Character character)
            {
                throw new NotImplementedException();
            }
        }


        public class Dwarve : Race
        {
            public Dwarve()
            {
                name = "Дворф";
                raceEnum = RaceEnum.Dwarve;
            }

            public override void applyPerks(Character character)
            {
                throw new NotImplementedException();
            }
        }

        public class Human : Race
        {
            public Human()
            {
                name = "Человек";
                raceEnum = RaceEnum.Human;
            }

            public override void applyPerks(Character character)
            {
                throw new NotImplementedException();
            }
        }
    }
}