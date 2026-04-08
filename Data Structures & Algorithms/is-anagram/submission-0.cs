public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] sc = s.ToCharArray();
        char[] tc = t.ToCharArray();

        Array.Sort(sc);
        Array.Sort(tc);
        

        return new string(sc) == new string(tc);
    }
}
