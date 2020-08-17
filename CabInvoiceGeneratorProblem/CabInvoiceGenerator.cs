using System;

namespace CabInvoiceGeneratorProblem
{
    public class CabInvoiceGenerator
    {
        public readonly int COST_PER_MIN = 1;
        public readonly int COST_MIN = 5;
        public readonly int COST_PER_KM = 10;
        public double CalculateFare(double distance, int time)
        {
            double fare = distance * COST_PER_KM + time * COST_PER_MIN;
            if (fare < COST_MIN)
                return COST_MIN;
            return fare;
        }
    }
}
