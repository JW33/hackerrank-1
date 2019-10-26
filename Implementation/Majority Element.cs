/* Majority Element */ success and the runtime was decent compared to other solutions (and languages)

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int x = 0; x < nums.Length; x++)
            {
                if (dictionary.ContainsKey(nums[x]))
                {
                    dictionary[nums[x]]++;
                }
                else
                {
                    dictionary.Add(nums[x], 1);
                }
            }

            int max = -1;
            int majorityElement = 0;
            foreach(var x in dictionary)
            {
                if(x.Value > max)
                {
                    max = x.Value;
                    majorityElement = x.Key;
                }
            }
            return majorityElement;
    }
}
