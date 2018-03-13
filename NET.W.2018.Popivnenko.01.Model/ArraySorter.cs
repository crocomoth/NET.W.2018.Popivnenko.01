using NET.W._2018.Popivnenko._01.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.Model
{
    public class ArraySorter : IArraySorter
    {
        public void MergeSort<T>(T[] array) where T : IComparable
        {
            throw new NotImplementedException();
        }

        public void QuickSort<T>(T[] array) where T : IComparable
        {
            if (array != null)
            {
                DoQuickSort<T>(array, 0, array.Length - 1);
            }
            else
            {
                throw new NullReferenceException("array is null");
            }
        }

        private void DoQuickSort<T>(T[] array, int leftBorder,int rightBorder) where T: IComparable
        {
            int i = leftBorder;
            int j = rightBorder;
            T baseElement = array[(rightBorder + leftBorder) / 2];
            // dividing input array into parts
            do
            {
                while (array[i].CompareTo(baseElement) < 0) // using compareTo due to the fact that we can try to sort objects
                {
                    i++;
                }
                while (array[j].CompareTo(baseElement) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // swap elements
                    T buf = array[i];
                    array[i] = array[j];
                    array[j] = buf;
                    i++;
                    j--;
                }
                // i++;//move left and right borders
            }
            while (i <= j);
            //recursion
            if (leftBorder < j)
            {
                DoQuickSort<T>(array, leftBorder, j);
            }
            if (i < rightBorder)
            {
                DoQuickSort<T>(array, i, rightBorder);
            }
        }

    }
}
