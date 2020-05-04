using System.Collections.Generic;

namespace CaspianDeveloperExercise
{
    public interface IMenuBillCalculation
    {
        public double CalculateBill(List<MenuItem> items);
    }
}