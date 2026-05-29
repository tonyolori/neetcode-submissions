public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new HashSet<char>();
        int l =0;
        int maxLength =0, length=0;

        for(int i =0; i<s.Length; i++){

            while(seen.Contains(s[i])){
                seen.Remove(s[l]);
                l++;
            }
            
            seen.Add(s[i]);
            maxLength = Math.Max(i-l + 1,maxLength);
        }
        return maxLength;
    }
}
