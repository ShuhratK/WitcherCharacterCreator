using System;

namespace WitcherCharacterCreator
{
    public class Dice
    {
        private readonly Random random;

        public Dice()
        {
            random = new Random();
        }

        public int throwDice(int edges)
        {
            return random.Next(edges);
        }

        public int throwDiceRepeatedly(int edges, int repeats)
        {
            var value = 0;

            for (var i = 0; i < repeats; i++) value += throwDice(edges);

            return value;
        }


        public int throwD6(int repeats = 1)
        {
            var value = 0;

            for (var i = 0; i < repeats; i++) value += throwDice(6);
            return value;
        }

        public int throwD10(int repeats = 1)
        {
            var value = 0;

            for (var i = 0; i < repeats; i++) value += throwDice(10);
            return value;
        }

        public int throwD12(int repeats = 1)
        {
            var value = 0;

            for (var i = 0; i < repeats; i++) value += throwDice(12);
            return value;
        }

        public bool Coin()
        {
            return random.Next() / 2 == 0;
        }

        public object selectRandom(object[] list)
        {
            return list[random.Next(list.Length)];
        }

        public class ListWithRatios
        {
            public Field[] fields;

            public ListWithRatios(Field[] list)
            {
                double ratiosSum = 0; //сумма всех коэффицентов
                for (int i = 0; i < list.Length; i++)
                {
                    ratiosSum += list[i].ratio;
                }

                if (ratiosSum > 1.0 || ratiosSum < 0.0) 
                    throw new Exception("Ratios sum is more than 1.0 or less than 0.0");

                int zeroesCount = 0; //количество пустых коэффицентов
                for (int i = 0; i < list.Length; i++)
                {
                    zeroesCount += list[i].ratio == 0 ? 1 : 0;
                }

                this.fields = list;

                if (zeroesCount > 0)
                {
                    double emptyRatio = (1.0 - ratiosSum) / zeroesCount; //коффицент который будет подставляться
                    //вместо пустого значения
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i].ratio == 0) list[i].ratio = emptyRatio;
                    }
                }
            }

            public class Field
            {
                public object entity;
                public double ratio;

                public Field(object entity ,double ratio)
                {
                    this.entity = entity;
                    this.ratio = ratio;
                }
                public Field(object entity)
                {
                    this.entity = entity;
                    this.ratio = 0.0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Случайный объект из списка с учётом коэффицентов</returns>
        public object selectRandomWithRatio(ListWithRatios list)
        {
            double number = random.NextDouble();
            double increment = 0.0;
            object output = new object();
            for (int i = 0; i < list.fields.Length; i++)
            {
                increment += list.fields[i].ratio;
                if (number <= increment) output = list.fields[i].entity;
            }
            return output;
        }
    }
}