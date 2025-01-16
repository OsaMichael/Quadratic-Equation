using QuadraticEquationAPI.Models;

namespace QuadraticEquationAPI.Repository
{
    public class QuadraticRepository: IQuadraticRepository
    {
        public QuadraticRepository() { }

        public ResultModel SolveEquation(QuadraticModel input) 
        {
            if (input.A == 0)
            {
                return new ResultModel{ Message = "Coefficient 'A' must not be zero." };
            }

            double discriminant = (input.B * input.B) - (4 * input.A * input.C);

            if (discriminant < 0)
            {
                return new ResultModel
                {
                    Message = "No real roots. The discriminant is negative."
                };
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-input.B + sqrtDiscriminant) / (2 * input.A);
            double root2 = (-input.B - sqrtDiscriminant) / (2 * input.A);

            return new ResultModel
            {
                Root1 = root1,
                Root2 = root2,
                Message = "Roots calculated successfully."
            };
        }
    }
}
