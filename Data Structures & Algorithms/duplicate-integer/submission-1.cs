public class Solution {
    public bool hasDuplicate(int[] nums) {
        var result = false;
        Dictionary<int, int> res = new(); 
         for(int i = 0 ; i< nums.Length; i++ ){
            if(res.ContainsKey(nums[i]))
            {
               res[nums[i]] = res[nums[i]] +1 ;
               result = true;
               break;
            } else
            {
              res.Add(nums[i], 1);
            }
         }
        return result;
    }
}