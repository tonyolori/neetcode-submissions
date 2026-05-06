public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            
            string key = new string(letters);
            if(!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            map[key].Add(word);

        }

        return map.Values.ToList();
    }
}
