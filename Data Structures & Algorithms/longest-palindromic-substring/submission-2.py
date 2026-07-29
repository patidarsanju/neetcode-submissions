class Solution:
    def longestPalindrome(self, s: str) -> str:
        rIdx , rLen, n = 0,  0, len(s)
 
        for  i in range(n):
            l, r = i, i 
            while l>=0 and r < n and s[l] == s[r]: 
                if (r-l + 1)  >  rLen:
                    rIdx = l
                    rLen = r-l + 1 
                r += 1
                l -= 1 
            l , r = i, i+ 1 

            while l>= 0 and r< n and s[l] == s[r]:
                if (r-l+1) > rLen:
                    rIdx = l
                    rLen = r-l+1
                r +=1
                l -= 1
        return s[rIdx: rIdx + rLen]


 

                