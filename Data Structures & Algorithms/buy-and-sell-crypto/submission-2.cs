public class Solution {
    public int MaxProfit(int[] prices) {
        int maxPrice = 0;
        for(int i = 0; i<prices.Length; i++){
            for(int j = i+1; j< prices.Length; j++){
                int price = prices[j] - prices[i];
                maxPrice = Math.Max(maxPrice,price);  
            }
        }

        return maxPrice;
    }
}
