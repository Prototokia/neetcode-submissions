public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var differences = new Dictionary<int, int>();
        int[] ans = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (!differences.ContainsKey(difference)) {
                differences.Add(difference, i);
            }
            
            if (differences.ContainsKey(nums[i]) && i != differences[nums[i]]) {
                ans[0] = Math.Min(i, differences[nums[i]]);
                ans[1] = Math.Max(i, differences[nums[i]]);
                break;
            }

        }

        return ans;
    }
}

