using System.Linq;

namespace PerfectlyBalanced
{
    public sealed class BalancedInput
    {
        public BalancedInput(string input) 
            => Input = input;

        public string Input { get; }

        public bool IsBalanced()
        {
            if (Input.Length > 0) {
                var charGroups = Input.ToCharArray()
                    .GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count());

                int checkCount = charGroups.First().Value;
                return charGroups.All(c => c.Value == checkCount);
            }

            return true;
        }
    }
}
