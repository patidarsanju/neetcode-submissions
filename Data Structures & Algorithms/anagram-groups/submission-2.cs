public class Solution {
     internal string GetOccuranceKey(string s)
    {  
        var chars = new int[26]; 
        for (int i = 0; i < s.Length; i++){
            chars[s[i] - 'a']++;
        } 
        return string.Join(",", chars); 
    }

    public List<List<string>> GroupAnagrams(string[] strs) {  
        Dictionary<string, List<string>> resHash = new();
        
        for(int i = 0; i < strs.Length; i++)
        {
            var key = GetOccuranceKey(strs[i]);
            
            if(resHash.ContainsKey(key))
            {
                resHash[key].Add(strs[i]); 
            }
            else
            {
                resHash[key] = new List<string>();
                resHash[key].Add(strs[i]); 
            } 
        }
        
        // Converts each inner List<string> explicitly to match List<List<string>>
        return resHash.Values.Select(x => x.ToList()).ToList();
    }
}
