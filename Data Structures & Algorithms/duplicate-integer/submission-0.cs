public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool hasDuplicate = false;
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i])) {
                hasDuplicate = true;
                break;
            }
            else {
                set.Add(nums[i]);
            }
        }

        return hasDuplicate;
    }
}