public class Solution {
    public bool IsPalindrome(string s) {
        bool result = true;
        var input = s.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray();
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
