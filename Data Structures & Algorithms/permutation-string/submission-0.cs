public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if(s1.Length > s2.Length){
            return false;
        }
        int[] s1Freq = new int[26];
        int[] windowFreq = new int[26];
        //get the freq of each character
        for(int i = 0; i<s1.Length; i++){
            s1Freq[s1[i]-'a']++;
            windowFreq[s2[i] - 'a']++;
        }

        if(Matches(s1Freq,windowFreq)){
            return true;
        }

        int left = 0; 

        for(int right = s1.Length; right<s2.Length;right++){
            windowFreq[s2[right] - 'a']++;
            
            windowFreq[s2[left] - 'a']--;
            left++;

            if(Matches(s1Freq,windowFreq)){
                return true;
            }
        }
        return false;
    }
    private bool Matches(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if(a[i] != b[i]){
                return false;
            }
        }
        return true;
    }
}
