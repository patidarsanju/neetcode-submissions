public class Solution {
    public bool IsPalindrome(string s) {
        bool result = true;
        var input = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLowerInvariant();
        int f = 0, r = input.Length-1;
        while(f<r){
            if(input[f] != input[r]){
               return false;
            }
            f++;
            r--;
        }
        return result;
    }
}
