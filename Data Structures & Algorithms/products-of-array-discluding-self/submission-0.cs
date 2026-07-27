public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        
        int prod = 1;
        prefix[0] = 1;
        for(int i = 1; i< nums.Length; i++)
        {
            prod = prod*nums[i-1];
            prefix[i] = prod;
         //   Console.WriteLine("I" + i + " product : " + prod);
        } 
        prod = 1; 
        suffix[nums.Length-1] = 1;
        for( int i = nums.Length-2; i >=0; i--)
        {
            prod = prod*nums[i+1];
            suffix[i] = prod;
         // Console.WriteLine("I" + i + " product : " + prod);
        }

        for (int i = 0; i< nums.Length; i++){
            result[i] = prefix[i] * suffix[i];
        }
        return result;
    }
}
