public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //self practice
        var map = new Dictionary<int, int>();

        for (int i = 0; i<nums.Length; i++){
            int complement = target - nums[i];

            if(map.ContainsKey(complement)){
                int j = map[complement];
                return i < j ? new int[] { i , j} : new int[] { j , i};
            }

            map[nums[i]] =  i;
        }
        return new int[]{0,0};
    }
}
