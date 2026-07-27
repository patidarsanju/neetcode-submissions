class Solution:
    def isPalindrome(self, s: str) -> bool:
        input = "".join(char for char in s.lower() if char.isalnum())

        return input==input[::-1]
        