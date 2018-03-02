using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTask
{
    public class Duck : IComparable<Duck>
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override bool Equals(object obj)
        {
            Duck duck = obj as Duck;
            if (duck == null)
            {
                return false;
            }

            return Name == duck.Name && 
                   Type == duck.Type && 
                   WeightInGrams == duck.WeightInGrams && 
                   AgeInMonths == duck.AgeInMonths;
        }

        public override string ToString()
        {
            return string.Format("\n\n Name : {0}," +
                                 "\n\n Type: {1}," +
                                 "\n\n Weight : {2} Grams," +
                                 "\n\n Age : {3} Months",
                                 Name, Type, WeightInGrams, AgeInMonths);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 31;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Type.GetHashCode();
                hash = hash * 23 + WeightInGrams.GetHashCode();
                hash = hash * 23 + AgeInMonths.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(Duck otherDuck)
        {
            if (AgeInMonths < otherDuck.AgeInMonths)
            {
                return 1;
            }
            else if (AgeInMonths > otherDuck.AgeInMonths)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
