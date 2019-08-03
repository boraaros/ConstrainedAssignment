using System;

namespace LinearAssignment
{
    public interface ILinearAssignmentSolver
    {
        /// <summary>
        /// Solve the classic linear assignment problem.
        /// </summary>
        /// <param name="costs">squared cost matrix</param>
        /// <returns>minimum-cost perfect matching (column assigned to row)</returns>
        int[] Solve(int[,] costs);
    }
}