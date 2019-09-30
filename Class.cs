using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE657_Project1
{
    public class Class
    {
        private int _movementSpeed = 30;
        private string _className = "";
        private bool[] _savingThrowProficiencies = { false, false, false, false, false, false };//Str, dex, con, int, wis, cha

        public int MovementSpeed
        {
            get
            {
                return _movementSpeed;
            }
            set
            {
                _movementSpeed = value;
            }
        }

        public string ClassName
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }

        public bool[] SavingThrowProficiencies
        {
            get
            {
                return _savingThrowProficiencies;
            }
            set
            {
                _savingThrowProficiencies = value;
            }
        }

        public void getClass(string s)
        {

            if(s.CompareTo("Barbarian") == 0)
            {
                _movementSpeed = 40;
                _savingThrowProficiencies = new bool[] { true, false, true, false, false, false };
            }
            else if (s.CompareTo("Bard") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, true, false, false, false, true };
            }
            else if (s.CompareTo("Cleric") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, false, false, true, true };
            }
            else if (s.CompareTo("Druid") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, false, true, true, false };
            }
            else if (s.CompareTo("Fighter") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { true, false, true, false, false, false };
            }
            else if (s.CompareTo("Monk") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { true, true, false, false, false, false };
            }
            else if (s.CompareTo("Paladin") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, false, false, true, true };
            }
            else if (s.CompareTo("Ranger") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { true, true, false, false, false, false };
            }
            else if (s.CompareTo("Rogue") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, true, false, true, false, false };
            }
            else if (s.CompareTo("Sorcerer") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, true, false, false, true };
            }
            else if (s.CompareTo("Warlock") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, false, false, true, true };
            }
            else if (s.CompareTo("Wizard") == 0)
            {
                _movementSpeed = 30;
                _savingThrowProficiencies = new bool[] { false, false, false, true, true, false };
            }

            ClassName = s;
        }
    }
}
