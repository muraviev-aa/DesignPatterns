using System.Collections.Generic;

namespace CreationalPatterns.Prototype
{
    internal class Phonebook : Copyable
    {
        private Dictionary<string, long> namesAndNums;


        public Phonebook(Dictionary<string, long> namesAndNums)
        {
            this.namesAndNums = namesAndNums;
        }

        public void SetNamesAndNums(Dictionary<string, long> namesAndNums)
        {
            this.namesAndNums = namesAndNums;
        }

        public override string ToString()
        {
            return "Phonebook{" +
                "namesAndNums=" + namesAndNums.GetString() +
                '}';
        }

        public object Copy()
        {
            return new Phonebook(this.namesAndNums);
        }

        public object Clone()
        {
            return this;
        }
    }
}
