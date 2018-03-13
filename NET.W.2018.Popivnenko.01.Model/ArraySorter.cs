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
        public void MergeSort<T>(T[] array) where T : IComparable<T>
        {
            if ((array != null) && (array.Length != 0))
            {
                SortMerge(array, 0, array.Length - 1);
            }
            else
            {
                throw new ArgumentNullException("array is null");
            }
        }


        private void MainMerge<T>(T[] numbers, int left, int mid, int right) where T: IComparable<T>

        {
            T[] temp = new T[numbers.Length];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) < 0)
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        private void SortMerge<T>(T[] numbers, int left, int right) where T:IComparable<T>
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);

            }

        }


        public void QuickSort<T>(T[] array) where T : IComparable<T>
        {
            if ((array != null) && (array.Length != 0))
            {
                DoQuickSort(array, 0, array.Length - 1);
            }
            else
            {
                throw new ArgumentNullException("array is null");
            }
        }

        private void DoQuickSort<T>(T[] array, int leftBorder,int rightBorder) where T: IComparable<T>
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
