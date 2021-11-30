using System;

namespace Demo.Lib
{
    public class Demo
    {
        public int GetTwoMin(int[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (data.Length < 2) throw new ArgumentException(nameof(data));

            var firstMin = int.MaxValue;
            var secondMin = int.MaxValue;

            foreach (var current in data)
            {
                if (current < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = current;
                }
                else if (current < secondMin && current != firstMin)
                {
                    secondMin = current;
                }
            }

            return firstMin + secondMin;
        }
    }
}
