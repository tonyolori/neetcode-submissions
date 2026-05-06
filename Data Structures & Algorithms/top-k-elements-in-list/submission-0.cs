public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }
            map[num]++;
        }

        // convert dictionary to list and sort
        var sortedList = map.OrderByDescending(x => x.Value).ToList();

        // then take the top k elements
        int[] result = new int[k];

        for (int i = 0; i < k; i++) {
            result[i] = sortedList[i].Key;
        }
    return result;
    }
}
