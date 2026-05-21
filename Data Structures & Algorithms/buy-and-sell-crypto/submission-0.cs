public class Solution {
    public int MaxProfit(int[] prices) {
        int profit,maxProfit = 0;
        int minPrice = prices[0];
        int max = 0;

        for(int i =0; i<prices.Length; i++){

            minPrice = Math.Min(minPrice,prices[i]);

            profit = prices[i] - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}
