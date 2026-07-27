public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         var res = new int[2];
        Dictionary<int, int> nn = new();

        int  diff = 0;
 

        for (int i = 0; i< nums.Length; i++ )
        {
            nn.Add(i, nums[i] );
        }
         
         for(int i =0 ; i< nums.Length; i++)
         {
           
           diff = target - nums[i]; 
           
           if(nn.FirstOrDefault(_=> _.Value == diff && _.Key !=i).Key > 0){
               res[0] = i;
               res[1] = nn.FirstOrDefault(_=> _.Value == diff && _.Key !=i).Key;
               break;
           } 
         }
         return res;
    }
}
