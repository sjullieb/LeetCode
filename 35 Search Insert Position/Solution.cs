public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
                return i;
        }
        //if (i == nums.Length - 1)
        result = nums.Length;
        return result;
    }
}