class Solution:
    def leastInterval(self, tasks: List[str], n: int) -> int:
        taskCount = Counter(tasks)

        maxFreq = max(taskCount.values())

        maxFreqCount = sum(1 for count in taskCount.values() if count == maxFreq)
    
        cycles = (maxFreq-1) * (n +1 ) + maxFreqCount 

        return max(len(tasks), cycles)
        