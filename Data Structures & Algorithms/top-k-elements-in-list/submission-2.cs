public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> numsMap = new();
        List<int>[] freq = new List<int>[nums.Length+1];
        var result = new int[k]; 

        for(int i = 0 ; i< freq.Length; i++){
             freq[i] = new List<int>();
        }
        for (int i = 0; i< nums.Length; i++ )
        {
            if(numsMap.ContainsKey(nums[i]))
                numsMap[nums[i]]++;
            else
               numsMap[nums[i]] = 1;
        } 
 
        foreach (var pair in numsMap)
        {
            freq[pair.Value].Add(pair.Key); 
        }

        int index = 0;
        for(int i = freq.Length-1; i > 0 && index < k ; i--){
          foreach(int n in freq[i]){
            result[index++] = n;
            if(index == k){
                return result;
            }
          }
        }  
      return result;
    }
}
