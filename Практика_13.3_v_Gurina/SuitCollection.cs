using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_13._3_v_Gurina
{
    public class SuitCollection
    {
        private SortedSet<Suit> suits;
        public SuitCollection()
        {
            suits = new SortedSet<Suit>();
        }
        public void AddSuit(Suit suit)
        {
            suits.Add(suit);
        }
        public bool RemoveSuit(Suit suit)
        {
            return suits.Remove(suit);
        }
        public IEnumberable<Suit> GetAllSuits()
        {
            return suits;
        }
        public int Count()
        {
            return suits.Count;
        }
    }
}
