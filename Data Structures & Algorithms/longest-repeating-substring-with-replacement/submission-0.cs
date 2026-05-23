public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left= 0;
        int maxFreq = 0;
        int result = 0;
        Dictionary<char, int> count = new Dictionary<char, int>();

        for(int right= 0; right<s.Length; right++){
            char c = s[right];

            if(!count.ContainsKey(c)){
                count[c] = 0;
            }
            count[c]++;
            
            maxFreq = Math.Max(maxFreq,count[c]);

            while((right- left +1) - maxFreq >k){
                count[s[left]]--;
                left++;
            }

            result = Math.Max(
                result,
                right - left + 1
            );
        }
        return result;
    }
}
