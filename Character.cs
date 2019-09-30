using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE657_Project1
{
    public class Character
    {
        public enum AbilityScore
        {
            Strength = 0,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        };

        public enum SkillBonus
        {
            Athletics = 0, //STR
            Acrobatics, //DEX
            SleightOfHand,
            Stealth,
            Arcana, //INT
            History,
            Investigation,
            Nature,
            Religion,
            AnimalHandling, //WIS
            Insight,
            Medicine,
            Perception,
            Survival,
            Deception, //CHA
            Intimidation,
            Performance,
            Persuasion
        };

        private string _characterName = "Kel Yurok";
        private int _level = 5;
        private int _hp = 25;
        private int[] _abilityScores = { 8, 12, 18, 8, 14, 20};
        private int[] _skillBonuses = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private bool[] _skillProficiencies = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

        private Inventory inventory = new Inventory();
        private Class characterClass = new Class();
        private SpellList spells = new SpellList();

        public String CharacterName
        {
            get
            {
                return _characterName;
            }
            set
            {
                _characterName = value;
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public int[] AbilityScores
        {
            get
            {
                return _abilityScores;
            }
            set
            {
                _abilityScores = value;
            }
        }

        public int[] SkillBonuses
        {
            get
            {
                return _skillBonuses;
            }
            set
            {
                _skillBonuses = value;
            }
        }

        public bool[] SkillProficiencies
        {
            get
            {
                return _skillProficiencies;
            }
            set
            {
                _skillProficiencies = value;
            }
        }

        public Class CharacterClass
        {
            get
            {
                return characterClass;
            }
            set
            {
                characterClass = value;
            }
        }

        public int getProficiency()
        {
            if (_level <= 4)
                return 2;
            else if (_level <= 8)
                return 3;
            else if (_level <= 11)
                return 4;
            else if (_level <= 16)
                return 5;
            else if (_level <= 20)
                return 6;
            else
                return 0;
        }
        public void changeStat(AbilityScore name, int newValue)
        {
            AbilityScores[(int)name] = newValue;

            SkillBonuses[(int)SkillBonus.Athletics] = AbilityScores[(int)AbilityScore.Strength];

            for (int i = (int)SkillBonus.Acrobatics; i < (int)SkillBonus.Arcana; i++)
            {
                SkillBonuses[i] = (AbilityScores[(int)AbilityScore.Dexterity] - 10)/2;
                if (SkillProficiencies[i])
                    SkillBonuses[i] += getProficiency();
            }
            for (int i = (int)SkillBonus.Arcana; i < (int)SkillBonus.AnimalHandling; i++)
            {
                SkillBonuses[i] = (AbilityScores[(int)AbilityScore.Intelligence] - 10) / 2;
                if (SkillProficiencies[i])
                    SkillBonuses[i] += getProficiency();
            }
            for (int i = (int)SkillBonus.AnimalHandling; i < (int)SkillBonus.Survival; i++)
            {
                SkillBonuses[i] = (AbilityScores[(int)AbilityScore.Wisdom] - 10) / 2;
                if (SkillProficiencies[i])
                    SkillBonuses[i] += getProficiency();
            }
            for (int i = (int)SkillBonus.Survival; i <= (int)SkillBonus.Persuasion; i++)
            {
                SkillBonuses[i] = (AbilityScores[(int)AbilityScore.Charisma] - 10) / 2;
                if (SkillProficiencies[i])
                    SkillBonuses[i] += getProficiency();
            }

            SkillBonuses = SkillBonuses;

        }

        public void changeClass(string name)
        {
            characterClass.getClass(name);
            changeStat(AbilityScore.Charisma, AbilityScores[(int)AbilityScore.Charisma]);
        }
    }
}
