public class Solution {
    public int LongestConsecutive(int[] nums) {
        int len = 0;
        int start = 0;

        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!set.Contains(nums[i])) {
                set.Add(nums[i]);
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!set.Contains(nums[i] - 1)) {
                int currentNum = nums[i];
                int currentLen = 1;

                while (set.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentLen += 1;
                }

                if (currentLen > len) {
                    len = currentLen;
                }
            }
        }


        return len;
    }
}
