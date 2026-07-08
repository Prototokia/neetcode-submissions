public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequency = new Dictionary<int, int>();
        var ans = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if (!frequency.ContainsKey(nums[i]))
                frequency.Add(nums[i], 1);
            else 
                frequency[nums[i]]++;
        }

        var sortedFrequency = frequency.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        int iter = 0;
        foreach (var kvp in sortedFrequency) {
            if (iter >= k)
                break;
            ans[iter] = kvp.Key;
            iter++;
        }

        return ans;
    }
}
