public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int zeroCount = 0;
        int[] prefixMult = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == 0) zeroCount++;

        if (zeroCount >= 2) {
            for (int i = 0; i < nums.Length; i++)
                output[i] = 0;

            return output;
        }

        prefixMult[0] = 1;

        for (int i = 1; i < prefixMult.Length; i++) {
            if (nums[i - 1] == 0) {
                prefixMult[i] = prefixMult[i - 1];
            }
            else {
                prefixMult[i] = prefixMult[i - 1] * nums[i - 1];
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (zeroCount == 1) {
                if (nums[i] == 0) {
                    output[i] = prefixMult[nums.Length];
                }
                else {
                    output[i] = 0;
                }
            }
            else {
                output[i] = prefixMult[nums.Length] / nums[i];
            }
        }

        return output;
    }
}
