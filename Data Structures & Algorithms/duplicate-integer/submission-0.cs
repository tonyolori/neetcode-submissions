public class Solution {
    public bool hasDuplicate(int[] nums) {
        //create a map 
        HashSet<int> seen = new HashSet<int>();

        //loop through the array , check if a value has been seen before
        foreach(int num in nums){
            if(seen.Contains(num)){
                return true;
            }

        // if not add it, if yes return true
            seen.Add(num);
        }
            return false;

        
        

    }
}