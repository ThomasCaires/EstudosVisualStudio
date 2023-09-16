
namespace Genericsexception.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new Exception("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                max = list[i];
            }
            return max;
        }
    }
}
