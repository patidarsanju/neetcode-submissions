class Solution:
    def leastInterval(self, tasks: List[str], n: int) -> int:
        freq = Counter(tasks)

        maxHeap = [-c for c in freq.values()]

        heapq.heapify(maxHeap)

        time = 0 

        q = deque() # pairs 

        while maxHeap or q:
            time += 1 
            if maxHeap :
                count = 1 + heapq.heappop(maxHeap)

                if count:
                    q.append([count, time + n])
            if q and q[0][1] == time:
                heapq.heappush(maxHeap, q.popleft()[0])
        
        return time
              


        

        