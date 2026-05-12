public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;

        while(left<right){
            //skip non alpha numeric on the left 
            while(left<right && !char.IsLetterOrDigit(s[left])){
                left++;
            };

            //skip non alpha numeric on the right
            while(right>left && !char.IsLetterOrDigit(s[right])){
                right--;
            }

            //compare lowercase characters 
            if(char.ToLower(s[left]) != char.ToLower(s[right])){
                return false;
            }

            left++;
            right--;

        }
        return true;
    }
}
