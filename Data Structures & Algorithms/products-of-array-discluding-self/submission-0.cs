public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        for(int i = 0;i<nums.Length;i++){
            int totalProduct = 1;

            for(int j = 0; j<nums.Length; j++){
                if(j == i) continue;

                totalProduct *= nums[j];

            }
            result[i] = totalProduct;
        }
    return result;
    }
}
