class Solution:
    def lengthOfLIS(self, nums: List[int]) -> int:
        result = 0
        n=len(nums)
        memo = [-1]*n

        def dfs(i):
            if(memo[i] !=-1):
                return memo[i]
            
            result = 1
            for j in range(i+1, n):
                if nums[i] < nums[j]:
                    result = max(result, 1+ dfs(j))
            memo[i] = result
            return result

        return max(dfs(i) for i in range(n))
        