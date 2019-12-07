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

To keep it simple we suppose that the input is always a square matrix. If not, we can convert easily to square matrix with constant costs (virtual rows or columns).

In summary, we can model the classic LAP as follows:
```cs
// INPUT: 
// squared (n x n) cost matrix
// OUTPUT: 
// minimum-cost perfect matching (column assigned to row)
int[] Solve(int[,] costs)
```

For example if the cost matrix is
```cs
int[,] costs = new int[,]
{
  { 2, 5, 1 },
  { 1, 3, 1 },
  { 7, 3, 4 }
};
```
then the correct result is
```cs
int[] result = new int[] { 2, 0, 1 };
```
### Upper bound
