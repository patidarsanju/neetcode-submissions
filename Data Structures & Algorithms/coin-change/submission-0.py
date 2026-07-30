class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        n =  len(coins)
        INF = float('inf')
        dp = [[INF] * (amount + 1) for _ in range(n +1)]

        for i in range(n+1):
            dp[i][0] = 0
        
        for i in range(1, n +1 ):
            coin = coins[i-1]
            for j in range(1, amount +1 ): 
                dp[i][j] = dp[i-1][j]
                if j >=coin:
                    dp[i][j] = min( dp[i][j] , 1 + dp[i][j-coin] ) 
        
        return dp[n][amount] if dp[n][amount] != INF else -1