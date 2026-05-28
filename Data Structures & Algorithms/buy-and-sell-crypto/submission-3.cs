public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];
        for (int i = 1; i < prices.Length; i++) {
            int price = prices[i];
            if (price < minPrice) {
                minPrice = price;
                continue;
            }

            int profit = price - minPrice;
            maxProfit = Math.Max(profit, maxProfit);
        }

        return maxProfit;
    }
}
