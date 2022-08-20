using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Geneneric
{
    class GenericSum
    {
        public class Addition<T>
        {
            public void Add(T val1, T val2)
            {
                var input_1 = Convert.ToDouble(val1);
                var input_2 = Convert.ToDouble(val2);

                var sum = (T)(dynamic)(input_1 + input_2);
                Console.WriteLine("(Generic) Sum: " + sum);
                return;

            }
        }
    }
}
