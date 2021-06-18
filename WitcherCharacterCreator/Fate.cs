using System;

namespace WitcherCharacterCreator
{
    public class Fate
    {
        public string FamilyFate;
        public string ParentalFate;
        public string MostInfluentialFriend;


        public enum Parents
        {
            Father,
            Mother,
            Both
        }

        public static string[][] familyFates = new string[][] 
        {
            new string[]
            {
                @"Your family was scattered to the
                winds by the wars and you have
                no idea where most of them
                are.",
                @"Your family was indentured for
                crimes against the Empire or
                on trumped-up charges. Only
                you escaped.",
                @"Your family were marked as
                human sympathizers and are
                not particularly loved in their
                homeland."
                
            },
            new string[]{
                @"
                Your family was imprisoned
                for crimes or on trumped-up
                charges. You were the only one
                to escape. You may want to free
                them...or maybe not.",
                @"
                Your family was exiled to the
                Korath Desert and you likely
                spent most of your early life
                struggling to survive in the
                deadly wasteland.",
                @"
                Your family was ostracized
                for dissenting opinions and
                now people won’t socialize with
                you or your family at all."},
            new string[]{
                @"
                Your family house was cursed
                and now either crops won’t
                grow or specters roam the halls.
                It became too dangerous for
                you to stay in this home.",
                @"
                Your family was killed by a
                rogue mage who either had a
                vendetta against your family, or
                just wanted blood. Either way,
                you are alone.",
                @"
                Your family died in the
                Northern Wars. They may have
                actually fought in the war, or
                were casualties of war who just
                happened to get in the way."},
                new string[]{
                @"
                With so many wars your family’s
                livelihood was destroyed.
                Your family turned to crime to
                survive.",
                @"
                Your family disappeared and
                you have no idea where they
                went. One day they just up and
                left .",
                @"
                Your family has been caught in
                a feud for centuries. You may
                not remember why this feud
                started, but it is dire."},
                new string[]{
                @"
                Your family accumulated a
                huge debt through gambling or
                favors from others. You need
                money desperately.",
                @"
                Your family was executed for
                treason against the Empire. You
                were the only one to escape this
                fate.",
                @"
                Your family was stripped of its
                title for some reason. You were
                evicted from your home and
                left scrambling to survive."},
                new string[]{
                @"
                Your family has fallen into a
                feud with another family. You
                may not even remember why
                this feud started in the first
                place.",
                @"
                Your family was stripped of
                its title for some reason. You
                were evicted from your home
                and left scrambling to survive
                among the un-washed masses.",
                @"
                Your family turned to raiding
                human settlements early in
                your life to get food and perhaps
                strike back at the humans."},
                new string[]{
                @"
                Due to some action or inaction
                your family has become hated
                in your home town and now
                no one there wants to have anything
                to do with them.",
                @"
                Your family name was
                tarnished by a magic relative
                who flaunted their magical gift
                disgracefully like a Northern
                mage.",
                @"
                Your family house is haunted.
                Most likely this is because your
                home was the site of many,
                many deaths during the war
                against humans."},
                new string[]{
                @"
                One day everything you had
                was ripped away by a bandit
                mob. Your family was massacred,
                leaving you entirely alone.",
                @"
                You disgraced your family in
                the eyes of the Empire. Something
                you did or failed to do has
                ruined your personal name and
                harmed your family.",
                @"
                Your family has been split by a
                human in-law who was brought
                into your family by a sibling or
                relative. Some of your family
                like them and some hate them."},
                new string[]{
                @"
                Your family has a deep, dark
                secret that if discovered would
                ruin you all completely. You
                can decide what this secret is,
                or the Game Master can decide.",
                @"
                Your family has a deep, dark
                secret that if discovered would
                destroy them and their name
                forever. You must protect this
                secret with your life.",
                @"
                Your family was killed by humans
                who thought they were
                Scoia’tael. They may have been
                slaughtered or hung with no
                court proceedings or trials."},
                new string[]{
                @"
                Your family has come to despise
                each other. No one you grew up
                with will talk with each other
                any more and you’re lucky to
                get a passing hello from your
                siblings.",
                @"
                Your family was assassinated.
                They may have been in the way
                of someone’s plan or they may
                have been used to get at someone
                more powerful. Either way,
                your family is gone now.",
                @"
                Your family is descended from
                an infamous traitor. It taints
                your family’s interactions with
                others of the elder races and
                has made living in the elderland
                difficult." 
                }
        };

        public static string[][] parentalFates = new string[][] 
        {
            new string[]
            {   @"
                One or more of your parents
                were killed in the Northern
                Wars. Most likely your father, but
                it is also possible that your mother
                fought or was a casualty.",
                @"
                Your father died in one of the
                Northern Wars. He may have already
                been in the military or he
                may have been conscripted into
                service during that war.",
            
                @"
                One or more of your parents
                were accused of being
                Scoia’tael. The people around
                you give your parents sidelong
                glances.",
            },
            
            new string[]
            {
                @"
                One or more of your parents
                left you in the wilderness to
                fend for yourself. Maybe they
                couldn’t afford to keep you;
                maybe you were an accident.",
                @"
                One or more of your parents
                were poisoned. This may have
                been the work of a professional
                rival, or it may have been to get
                your parents out of the way.",
                @"
                One or more of your parents
                turned on your own people and
                sold out the elder races to the
                humans. Your parents are unwelcome
                in your homeland.",
            },
            new string[]
            {
                @"  
                One or more of your parents
                were cursed by a mage or due
                to the intense hatred of someone
                they encountered. The
                curse took their life.",
                @"
                The secret police took your
                parent or parents for ‘questioning.’
                The next week their bodies
                were found hung in the streets
                of the city.",
                @"
                One or more of your parents
                killed themselves out of despair.
                With no hope of regaining the
                glory of the past, they gave up
                and ended it."
                
            },
            new string[]
            {
                @"
                One or more of your parents
                sold you for coin, or perhaps
                traded you for some goods or
                service. Your parents needed
                the money more than you.",
                @"
                One or more of your parents
                were killed by a rogue mage.
                Most likely they tried to turn
                the mage in question in to the
                Empire and paid the price.",
                @"
                While traveling, one or more of
                your parents fell prey to human
                racism. They died in a pogrom
                and their bodies were displayed
                on pikes."
            },
            new string[]
            {
                @"
                One or more of your parents
                joined a gang. You saw this
                gang oft en and were sometimes
                forced to work with them.",
                @"
                One or more of your parents
                were imprisoned for unlawful
                magic. Maybe they actually
                commited the crime or maybe
                it was a setup.",
                @"
                One or more of your parents
                have become obssessed with
                regaining the former glory
                of their race. They sacrifice
                everything for this cause."
            },
            new string[]
            {
                @"
                One or more of your parents
                were killed by monsters. It is
                your decision as to what they
                may have fallen prey to.",
                @"
                One or more of your parents
                were exiled to the Korath Desert.
                Likely they committed a
                major crime but killing them
                would cause trouble.",
                @"
                One or more of your parents
                were exiled from your
                homeland. There are many possible
                reasons, from crime to
                dissenting opinons."
            },
            
            new string[]{
                @"
                One or more of your parents
                were falsely executed. They may
                have been a scapegoat for something
                or just in the wrong place.",
                @"
                One or more of your parents
                were cursed by a mage. The
                mage likely had a vendetta
                against them.", 
                @" 
                One or more of your parents
                were cursed. You can decide
                what this curse is or, the Game
                Master can decide."
            },
            
            new string[]{
                @"
                One or more of your parents
                died of a plague. There was
                nothing that could be done but
                try to ease their passing.",   
                @"
                Your parents simply left you
                one day. You may not even
                know why they did it. One day
                your parents just disappeared.",
                @"
                Your parents gave you to another
                family so that you could
                survive, because they couldn’t
                care for you."
            },
            
            new string[]{
                @"One or more of your parents
                defected to Nilfgaard. They
                may have been given a deal for
                information or they may just
                have jumped the border.",
                @"
                One or more of your parents
                were enslaved. They either
                commited a crime against the
                Empire or were set up by a rival.",
                @"
                One or more of your parents
                joined the Scoia’tael in an attempt
                to get revenge on the humans
                who they see as ruining
                their lives."
            },
            new string[]{
                @"One or more of your parents
                were kidnapped by nobles.
                Likely it was your mother, who
                attracted the attention of a local
                lord or his son.",
                @"
                One or more of your parents
                were sent to the North as double
                agents. You likely don’t even
                know where they are now, but
                they’re serving the Emperor.
                ",
                @"
                One or more of your parents
                died in an ‘accident’. Most likely
                they made a powerful enemy
                that finally found a way to get
                rid of them."
            }
        };

        public FamilyStatus[][] familyStatuses = new FamilyStatus[][]
        {
            //TODO:Заполнить список после реализации системы инвентаря
            new FamilyStatus[]
            {
                
            }
        };

        public class FamilyStatus
        {
            string text;
            private string name;

            public delegate void Action(Character character);
            Action action;

            public FamilyStatus(string name,string text,Action action )
            {
                this.name = name;
                this.text = text;
                this.action = action;
            }
        }
    }
}