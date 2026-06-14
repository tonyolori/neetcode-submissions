public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        int[][] cars = new int[n][];

        for(int i = 0; i<n; i++){
            cars[i] = new int[]{position[i], speed[i]};
        }

        //sort by position descending
        Array.Sort(cars,(a,b) => b[0].CompareTo(a[0]));

        int fleets = 0; 
        double prevTime = 0; 

        foreach(int[] car in cars){
            int pos = car[0];
            int spd = car[1];

            double time = (double)(target - pos) / spd;
            //calculate the fleets
            if(time> prevTime){
                fleets++;
                prevTime = time;
            }
            
        }
        return fleets;
    }
}
