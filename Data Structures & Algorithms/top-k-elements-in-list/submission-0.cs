public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> numsMap = new();
        var result = new int[k]; 
        for (int i = 0; i< nums.Length; i++ )
        {
            if(numsMap.ContainsKey(nums[i]))
                numsMap[nums[i]]++;
            else
               numsMap[nums[i]] = 1;
        } 

        PriorityQueue<int, int> minHeap = new();

        foreach (var pair in numsMap)
        {
           minHeap.Enqueue(pair.Key, pair.Value);

           if(minHeap.Count> k){
            minHeap.Dequeue();
           }
        }
 
        for(int i = 0; i< k ; i++){
              result[i] = minHeap.Dequeue();
        }

    return result;
    }
}
