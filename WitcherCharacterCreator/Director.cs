using System;
using WitcherCharacterCreator.Races;
using WitcherCharacterCreator.Regions;

namespace WitcherCharacterCreator
{
    public abstract class Director
    {
        private Character character;
        private CharacterBuilder characterBuilder;
        private RandomCharacterBuilder randomCharacterBuilder;

        public Director()
        {
            character = new Character();
            characterBuilder = new CharacterBuilder(character);
            randomCharacterBuilder = new RandomCharacterBuilder(character);
        }

        public void createCharacter()
        {
        }

        private Race pickRace()
        {
            bool random = decideRandom("Выбрать рассу случайно y/n");

            Race race = random
                ? randomCharacterBuilder.pickRace()
                : characterBuilder.pickRace();
            Console.WriteLine($"Выбранна расса {race.name}");
            return race;
        }

        private Region pickHomeland()
        {
            Region region;

            if (character.race.raceEnum == RaceEnum.Dwarve && character.race.raceEnum == RaceEnum.Elve)
            {
                region = new Elderlands();

                if (character.race.raceEnum == RaceEnum.Dwarve)
                    region.origin = region.origins[(int) Elderlands.OriginsEnum.Mahakam];
                else
                    region.origin = region.origins[(int) Elderlands.OriginsEnum.DolBlathanna];

                Console.WriteLine($"Выбран регион {region.name}, государство {region.origin.text()}");
                return region;
            }

            bool random = decideRandom("Выбрать регион случайно y/n");
            region = random
                ? randomCharacterBuilder.pickRegion()
                : characterBuilder.pickRegion();
            Console.WriteLine($"Выбран регион {region.name}, государство {region.origin.text()}");
            return region;
        }

        private Proffesion pickProffesion()
        {
            Proffesion proffesion;
            if (character.race.raceEnum == RaceEnum.Witcher)
            {
                proffesion = new Witcher();
                Console.WriteLine($"Выбранна профессия {proffesion.name}");
                return proffesion;
            }

            bool random = decideRandom("Выбрать рассу случайно y/n");
            proffesion = random
                ? randomCharacterBuilder.pickProffesion()
                : characterBuilder.pickProffesion();
            Console.WriteLine($"Выбранна профессия {proffesion.name}");
            return proffesion;
        }


        /// <summary>
        ///	Принимает сообщение и опционально символы означающие положительны или отрицательный ответ(по умолчанию Y/N)
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Возвращает true при варианте ответа positive</returns>
        public bool decideRandom(string message, char positive = 'y', char negative = 'n')
        {
            Console.WriteLine(message);
            char answer;
            while (true)
            {
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == positive || answer == negative) return answer == positive;

                Console.WriteLine("Такой ответ не предусмотрен");
            }
        }

        public Character getCharacter()
        {
            return character;
        }
    }
}