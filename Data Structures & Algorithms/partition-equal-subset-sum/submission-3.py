class Solution:
    def canPartition(self, nums: List[int]) -> bool:
         
        if sum(nums)%2 : 
            return False
        
        target = sum(nums)//2
        n = len(nums)
        dp = [[-1] * (target+1) for _ in range(n+1)]

         
        def targetSum(i , target ):
            if target == 0:
                return True
            
            if i>= n or target < 0:
                return False

            if dp[i][target] != -1:
                return dp[i] [target]
            
            dp[i][target] = (targetSum(i+1, target) or  targetSum(i+1, target-nums[i]))
            
            return dp[i][target]
        return targetSum(0, target)

    
     
