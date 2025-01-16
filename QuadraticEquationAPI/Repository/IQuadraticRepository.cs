using QuadraticEquationAPI.Models;

namespace QuadraticEquationAPI.Repository
{
    public interface IQuadraticRepository
    {
        public ResultModel SolveEquation(QuadraticModel input);
    }
}
