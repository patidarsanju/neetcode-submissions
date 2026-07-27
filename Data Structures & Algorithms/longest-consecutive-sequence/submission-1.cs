public class Solution {
    public int LongestConsecutive(int[] nums) {
        int result = 0;
        
        var set = new HashSet<int>(nums);

        foreach(int num in nums){
         
         if(!set.Contains(num-1)){
            int len = 0; 
            while(set.Contains(num+len)){
                len++;
            }
            result = Math.Max(len, result) ;
         }

        }
        return result;
    }
}
