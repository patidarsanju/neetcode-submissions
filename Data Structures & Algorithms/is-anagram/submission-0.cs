public class Solution {
    public bool IsAnagram(string s, string t) {
      Dictionary<char, int> ana = new();

      if(s.Length != t.Length) return false;

      for(int i = 0; i< s.Length; i++){
         if(ana.ContainsKey(s[i]))
         {
           ana[s[i]] = ana[s[i]] +1;
         }
         else {
           ana.Add(s[i], 1 );
         }
      }
      for(int i = 0; i< t.Length; i++){
         if(ana.ContainsKey(t[i])){
           ana[t[i]] = ana[t[i]] - 1;
           if(ana[t[i]] < 0) return false;
         }
         else {
          return false;
         }
      }

      return true;
    }
}
