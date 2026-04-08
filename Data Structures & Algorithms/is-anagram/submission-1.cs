public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length)
            return false;
        
        int[] c = new int[26];

        foreach(char a in s){
            c[a-'a']++;
        }

        foreach(char a in t){
            if(c[a-'a'] == 0)
                return false;
            c[a-'a']--;
        }

        return true;
    }
}
