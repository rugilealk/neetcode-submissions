public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int startProduct = 1, endProduct = 1; // the current product of every passed element from the start or the end respectively
        int end = nums.Length - 1; // the end pointer
        int[] result = new int[nums.Length];

        for(int i = 0; i < nums.Length; ++i)
            result[i] = 1;

        for(int start = 0; start < nums.Length; ++start)
        {
            result[start] = result[start] * startProduct;
            result[end] = result[end] * endProduct;
            startProduct *= nums[start];
            endProduct *= nums[end];
            --end;
        }

        return result;
    }
}
