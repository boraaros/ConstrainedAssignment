# ConstrainedAssignment

### Introduction

It is well known that the classic linear assignment problem (LAP) can be solved in polynomial time.
https://en.wikipedia.org/wiki/Assignment_problem \
https://en.wikipedia.org/wiki/Time_complexity

The most popular and effective methods to solve LAP are the Hungarian type, the shortest path (network flow) based, the linear programming based and the auction algorithms. \
https://en.wikipedia.org/wiki/Hungarian_algorithm \
https://en.wikipedia.org/wiki/Flow_network \
https://en.wikipedia.org/wiki/Linear_programming \
https://en.wikipedia.org/wiki/Auction_algorithm

```cs
// INPUT: 
// squared (n x n) cost matrix
// OUTPUT: 
// minimum-cost perfect matching (column assigned to row)
int[] Solve(int[,] costs)
```
