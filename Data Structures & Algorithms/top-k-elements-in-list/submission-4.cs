// Using bucket sort
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Step 1: Count frequencies
        foreach (int num in nums) {
            if (!frequencyMap.ContainsKey(num)) {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }

        // Step 2: Create buckets where index = frequency
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in frequencyMap) {
            int value = pair.Key;
            int frequency = pair.Value;

            if (buckets[frequency] == null) {
                buckets[frequency] = new List<int>();
            }

            buckets[frequency].Add(value);
        }

        // Step 3: Traverse from highest frequency to lowest
        List<int> results = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && results.Count < k; i--) {
            if (buckets[i] != null) {
                foreach (int num in buckets[i]) {
                    results.Add(num);

                    if (results.Count == k) {
                        break;
                    }
                }
            }
        }

        return results.ToArray();
    }
}