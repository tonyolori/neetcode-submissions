public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new HashSet<char>();
        int l = 0;
        int maxLength = 0;

        for (int r = 0; r < s.Length; r++) {
            while (seen.Contains(s[r])) {
                seen.Remove(s[l]);
                l++;
            }

            seen.Add(s[r]);
            maxLength = Math.Max(r - l + 1, maxLength);
        }
        return maxLength;
    }
}
