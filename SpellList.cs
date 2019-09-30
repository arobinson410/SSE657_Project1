using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE657_Project1
{
    public class SpellList
    {
        private int[] _spellSlots = { 4, 3, 3, 3, 3, 2, 2, 1, 1};

        public int[] spellSlots
        {
            get
            {
                return _spellSlots;
            }
            set
            {
                _spellSlots = value;
            }
        }
    }
}
