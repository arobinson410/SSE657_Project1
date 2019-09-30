using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE657_Project1
{
    public class MainWindowVM
    {
        public Character c;

        public MainWindowVM(Character c)
        {
            this.c = c;
        }

        public string CharacterName
        {
            get
            {
                return c.CharacterName;
            }
            set
            {
                c.CharacterName = value;
            }
        }

        public int[] AbilityScores
        {
            get
            {
                return c.AbilityScores;
            }
            set
            {
                c.AbilityScores = value;
            }
        }

        public Character character
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }

        }
    }
}
