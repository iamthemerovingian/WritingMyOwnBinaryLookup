using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMyOwnBinaryLookup
{
    class DataFinder
    {
        private Random random = new Random();

        public DataFinder()
        {

        }

        public int[] GenerateArray(int size)
        {
            int[] theArray = new int[size];
            theArray = FillArray(theArray);

            return theArray;
        }

        private int[] FillArray(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = random.Next(0, 65500);
            }

            return theArray;
        }

        public bool FindIntBuiltIn(int value, int[] theArray)
        {
            bool successFlag = false;

            var matched = theArray.Where(x => x == value);

            if (matched.Count() > 0)
            {
                successFlag = true;
            }

            return successFlag;
        }

        public bool FindInt(int value, int[] theArray)
        {
            int match = 0;
            bool SuccessFlag = false;

            foreach (var integerValue in theArray)
            {
                if(integerValue == value)
                {
                    match = integerValue;
                    SuccessFlag = true;
                }
            }

            return SuccessFlag;
        }

        public TValue Find<TValue>(TValue value, TValue[] theArray)
        {
            TValue foundItem = value;



            return foundItem;
        }
    }
}
