public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();

        foreach (string word in strs) {
            result.Append(word.Length);
            result.Append('#');
            result.Append(word);
            //format Length#word
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i= 0;

        while(i<s.Length){
            int j = i; 

            //move j forward to the hashTag
            while(s[j]!= '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));
            j++;
            i=j;

            result.Add(s.Substring(i,length));
            i+= length;

        }

        
        return result;
    }
}
