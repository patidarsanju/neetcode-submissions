class MedianFinder:

    def __init__(self):
        self.minh = []
        self.maxh = []
        

    def addNum(self, num: int) -> None:
        if self.maxh and num > self.maxh[0]:
            heapq.heappush(self.maxh, num)
        else:
            heapq.heappush(self.minh, -1 * num)

        if len(self.minh) > len(self.maxh) + 1:
            val = -1 * heapq.heappop(self.minh)
            heapq.heappush(self.maxh, val)
        if len(self.maxh) > len(self.minh) + 1:
            val = heapq.heappop(self.maxh)
            heapq.heappush(self.minh, -1 * val)
        

    def findMedian(self) -> float:
        if len(self.minh) > len(self.maxh):
            return -1 * self.minh[0]
        elif len(self.maxh) > len(self.minh):
            return self.maxh[0]
        return (-1 * self.minh[0] + self.maxh[0]) / 2.0
        
        