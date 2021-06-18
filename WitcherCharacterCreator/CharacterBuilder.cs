using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http;
using WitcherCharacterCreator.Races;
using WitcherCharacterCreator.Regions;
using WitcherCharacterCreator.Statistics;

namespace WitcherCharacterCreator
{
    public class CharacterBuilder
    {
        protected Character character;
        protected Dice dice;


        public CharacterBuilder(Character character)
        {
            this.character = character;
            dice = new Dice();
        }

        public Race pickRace()
        {
            var races = new Race[] {new Races.Witcher(), new Elve(), new Dwarve(), new Human()};
            return (Race) pickFromArray(races);
        }

        public Proffesion pickProffesion()
        {
            return (Proffesion) pickFromArray(new IInfo[]
            {
                new Bard(), new Craftsman(), new Criminal(), new Doctor(), new Mage(), new ManAtArms(), new Merchant(),
                new Priest()
            });
        }

        public Region pickRegion()
        {
            Region region;

            if (character.race.raceEnum == RaceEnum.Dwarve && character.race.raceEnum == RaceEnum.Elve)
            {
                region = new Elderlands();

                if (character.race.raceEnum == RaceEnum.Dwarve)
                    region.origin = region.origins[(int) Elderlands.OriginsEnum.Mahakam];
                else
                    region.origin = region.origins[(int) Elderlands.OriginsEnum.DolBlathanna];
            }

            else
            {
                region = (Region) pickFromArray(new IInfo[] {new Nilfgaard(), new NorthernKingdoms()});
                region.origin = (Region.Origin) pickFromArray(character.region.origins);
            }

            return region;
        }

        protected IInfo pickFromArray(IInfo[] array, string message = "")
        {
            if (message != null) Console.WriteLine(message);

            for (var i = 0; i < array.Length; i++) Console.WriteLine($"{i + 1} - {array[i].text()}");

            var select = Convert.ToInt32(Console.ReadLine());
            return array[select];
        }
        
        
    }

    public class RandomCharacterBuilder : CharacterBuilder
    {
        public RandomCharacterBuilder(Character character) : base(character)
        {
        }

        public new Race pickRace()
        {
            var races = new Race[] {new Races.Witcher(), new Elve(), new Dwarve(), new Human()};
            return (Race) dice.selectRandom(races);
        }

        public new Proffesion pickProffesion()
        {
            return (Proffesion) dice.selectRandom(new object[]
            {
                new Bard(), new Craftsman(), new Criminal(), new Doctor(), new Mage(), new ManAtArms(), new Merchant(),
                new Priest()
            });
        }

        public new Region pickRegion()
        {
            Region region;

            region = (Region) dice.selectRandom(new object[] {new Nilfgaard(), new NorthernKingdoms()});

            if (region.regionEnum == RegionEnum.Nilfgard)
                region.origin = (Region.Origin) dice.selectRandom(new object[]
                    {
                        Nilfgaard.OriginsEnum.TheHeartofNilfgaard,
                        Nilfgaard.OriginsEnum.TheHeartofNilfgaard,
                        Nilfgaard.OriginsEnum.TheHeartofNilfgaard,
                        Nilfgaard.OriginsEnum.TheHeartofNilfgaard,
                        Nilfgaard.OriginsEnum.Vicovaro,
                        Nilfgaard.OriginsEnum.Angren,
                        Nilfgaard.OriginsEnum.Nazair,
                        Nilfgaard.OriginsEnum.Mettina,
                        Nilfgaard.OriginsEnum.MagTurga,
                        Nilfgaard.OriginsEnum.Gheso,
                        Nilfgaard.OriginsEnum.Ebbing,
                        Nilfgaard.OriginsEnum.Maecht,
                        Nilfgaard.OriginsEnum.Gemmeria,
                        Nilfgaard.OriginsEnum.Etolia
                    }
                );
            else
                region.origin = (Region.Origin) dice.selectRandom((object[]) region.origins);

            return region;
        }
        
    }
}