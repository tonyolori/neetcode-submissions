public class Solution {
    public string Encode(IList<string> strs) {
        string result = "";

        foreach (string word in strs) {
            result += word;
            result += "~";
        }
        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        string word = "";

        foreach (char letter in s) {
            if (letter == '~') {
                result.Add(word);
                word = "";
            } else {
                word += letter;
            }
        }
        return result;
    }
}
