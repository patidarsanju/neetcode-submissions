public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new int[2];
        Dictionary<int, int> nn = new(); 
        for(int i =0 ; i< nums.Length; i++)
        {
           var diff = target - nums[i]; 
           if(nn.ContainsKey(diff))
           {
               res[1] = i;
               res[0] = nn[diff];
               break;
           } 
            nn.Add( nums[i] , i);
         }
        return res;
    }
}
